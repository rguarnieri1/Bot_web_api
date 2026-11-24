using System;
using System.Collections.Generic;

namespace Bot_web_api.Models;

public partial class Bot18Signal
{
    public long Id { get; set; }

    public string Symbol { get; set; } = null!;

    public string? Isin { get; set; }

    public string? Strategy { get; set; }

    public string? Signal { get; set; }

    public bool IsLong { get; set; }

    public string? Timeframe { get; set; }

    public DateTime SignalCandleTime { get; set; }

    public DateTime AnalysisTime { get; set; }

    public decimal Price { get; set; }

    public decimal? Ema5 { get; set; }

    public decimal? Ema10 { get; set; }

    public decimal? Ema20 { get; set; }

    public decimal? Ema30 { get; set; }

    public int? Trend { get; set; }

    public decimal? Volume { get; set; }

    public decimal? AvgVolume { get; set; }

    public decimal? VolumeRatio { get; set; }

    public decimal? CandleBodyStrength { get; set; }

    public decimal? Rsi { get; set; }

    public decimal? SignalStrength { get; set; }

    public decimal? StopLoss { get; set; }

    public bool Accepted { get; set; }

    public string? RejectionReason { get; set; }

    public decimal? Target { get; set; }

    public decimal? PositionSize { get; set; }

    public decimal? RiskRewardRatio { get; set; }

    public decimal? ExpectedProfit { get; set; }

    public string? TradeId { get; set; }

    public string Bot { get; set; } = null!;
}
