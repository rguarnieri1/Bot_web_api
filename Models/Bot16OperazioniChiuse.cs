using System;
using System.Collections.Generic;

namespace Bot_web_api.Models;

public partial class Bot16OperazioniChiuse
{
    public long Id { get; set; }

    public string TradeId { get; set; } = null!;

    public string? Symbol { get; set; }

    public string? Isin { get; set; }

    public string? Strategy { get; set; }

    public bool IsLong { get; set; }

    public decimal? StopLoss { get; set; }

    public decimal? TargetPrice { get; set; }

    public string? ExitReason { get; set; }

    public decimal EntryPrice { get; set; }

    public decimal? ExitPrice { get; set; }

    public decimal? Profit { get; set; }

    public decimal? ProfitPercentage { get; set; }

    public string? Status { get; set; }

    public DateTime OpenTime { get; set; }

    public DateTime CloseTime { get; set; }

    public string Bot { get; set; } = null!;
}
