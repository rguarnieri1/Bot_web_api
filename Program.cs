using System.Globalization;
using System.Reflection;
using Bot_web_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

var builder = WebApplication.CreateBuilder(args);

// La stringa di connessione "BotDb" sta in appsettings.local.json (escluso da git).
builder.Configuration.AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true);

var connectionString = builder.Configuration.GetConnectionString("BotDb")
    ?? throw new InvalidOperationException(
        "Stringa di connessione 'BotDb' non trovata: aggiungerla in appsettings.local.json (ConnectionStrings:BotDb).");

builder.Services.AddDbContext<BotDbContext>(options =>
    options.UseSqlServer(connectionString)
           .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

// Un endpoint per ogni tabella presente nel modello EF Core (= tutte le tabelle del database).
List<TableInfo> tables;
using (var scope = app.Services.CreateScope())
{
    var model = scope.ServiceProvider.GetRequiredService<BotDbContext>().Model;
    tables = model.GetEntityTypes()
        .Where(e => e.GetTableName() is not null)
        .Select(e => new TableInfo(e.GetSchema() ?? "dbo", e.GetTableName()!, e))
        .OrderBy(t => t.Schema.Length).ThenBy(t => t.Schema).ThenBy(t => t.Name)
        .ToList();
}

var mapTable = typeof(TableEndpoints).GetMethod(nameof(TableEndpoints.Map), BindingFlags.Public | BindingFlags.Static)!;
foreach (var table in tables)
    mapTable.MakeGenericMethod(table.EntityType.ClrType).Invoke(null, [app, table]);

app.MapGet("/api/tables", () => tables.Select(t => new
{
    schema = t.Schema,
    table = t.Name,
    url = t.Route,
    columns = t.EntityType.GetProperties().Select(p => p.GetColumnName())
})).WithTags("Tabelle");

app.MapGet("/", () => Results.Redirect("/api/tables")).ExcludeFromDescription();

app.Run();

record TableInfo(string Schema, string Name, IEntityType EntityType)
{
    public string Route => $"/api/{Schema}/{Name}";
}

static class TableEndpoints
{
    const int MaxPageSize = 1000;

    public static void Map<T>(WebApplication app, TableInfo table) where T : class
    {
        var key = table.EntityType.FindPrimaryKey()?.Properties.Count == 1
            ? table.EntityType.FindPrimaryKey()!.Properties[0]
            : null;

        // GET /api/{schema}/{tabella}?page=1&pageSize=100  -> righe paginate, le più recenti per prime
        app.MapGet(table.Route, async (BotDbContext db, int page = 1, int pageSize = 100) =>
        {
            page = Math.Max(page, 1);
            pageSize = Math.Clamp(pageSize, 1, MaxPageSize);

            IQueryable<T> query = db.Set<T>();
            var total = await query.CountAsync();
            if (key is not null)
                query = query.OrderByDescending(e => EF.Property<object>(e, key.Name));

            var rows = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return Results.Ok(new { schema = table.Schema, table = table.Name, total, page, pageSize, rows });
        }).WithTags(table.Schema);

        if (key is null) return;

        // GET /api/{schema}/{tabella}/{id}  -> singola riga per chiave primaria
        app.MapGet(table.Route + "/{id}", async (BotDbContext db, string id) =>
        {
            object keyValue;
            try
            {
                keyValue = Convert.ChangeType(id, Nullable.GetUnderlyingType(key.ClrType) ?? key.ClrType, CultureInfo.InvariantCulture);
            }
            catch (Exception ex) when (ex is FormatException or InvalidCastException or OverflowException)
            {
                return Results.BadRequest(new { error = $"Chiave '{id}' non valida per {table.Name}." });
            }

            var row = await db.Set<T>().FindAsync(keyValue);
            return row is null ? Results.NotFound() : Results.Ok(row);
        }).WithTags(table.Schema);
    }
}
