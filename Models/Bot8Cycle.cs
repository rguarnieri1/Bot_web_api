using System;
using System.Collections.Generic;

namespace Bot_web_api.Models;

public partial class Bot8Cycle
{
    public long Id { get; set; }

    public int CycleNumber { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Timeframe { get; set; }

    public bool NewCandle { get; set; }

    public DateTime? SignalCandleTime { get; set; }

    public int? CryptosAnalyzed { get; set; }

    public int TradesClosed { get; set; }

    public int SignalsFound { get; set; }

    public int SignalsFiltered { get; set; }

    public int OpenTrades { get; set; }

    public decimal CapitalCommitted { get; set; }

    public decimal RealizedPnl { get; set; }

    public string? RejectionCounts { get; set; }

    public string? Error { get; set; }

    public string Bot { get; set; } = null!;
}
