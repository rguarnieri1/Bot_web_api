@echo off
rem Rigenera modelli e DbContext da TUTTE le tabelle del database "bot".
rem Da rieseguire quando si aggiungono/modificano tabelle: i nuovi endpoint compaiono da soli.
cd /d "%~dp0"
dotnet tool restore
dotnet dotnet-ef dbcontext scaffold "Server=(localdb)\MSSQLLocalDB;Database=bot;Integrated Security=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer --context BotDbContext --context-dir Data --output-dir Models --no-onconfiguring --force
