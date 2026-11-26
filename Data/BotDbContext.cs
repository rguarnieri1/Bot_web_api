using System;
using System.Collections.Generic;
using Bot_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Bot_web_api.Data;

public partial class BotDbContext : DbContext
{
    public BotDbContext(DbContextOptions<BotDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bot10Cycle> Bot10Cycles { get; set; }

    public virtual DbSet<Bot10OperazioniChiuse> Bot10OperazioniChiuses { get; set; }

    public virtual DbSet<Bot10Signal> Bot10Signals { get; set; }

    public virtual DbSet<Bot10Trade> Bot10Trades { get; set; }

    public virtual DbSet<Bot11Cycle> Bot11Cycles { get; set; }

    public virtual DbSet<Bot11OperazioniChiuse> Bot11OperazioniChiuses { get; set; }

    public virtual DbSet<Bot11Signal> Bot11Signals { get; set; }

    public virtual DbSet<Bot11Trade> Bot11Trades { get; set; }

    public virtual DbSet<Bot12Cycle> Bot12Cycles { get; set; }

    public virtual DbSet<Bot12OperazioniChiuse> Bot12OperazioniChiuses { get; set; }

    public virtual DbSet<Bot12Signal> Bot12Signals { get; set; }

    public virtual DbSet<Bot12Trade> Bot12Trades { get; set; }

    public virtual DbSet<Bot13Cycle> Bot13Cycles { get; set; }

    public virtual DbSet<Bot13OperazioniChiuse> Bot13OperazioniChiuses { get; set; }

    public virtual DbSet<Bot13Signal> Bot13Signals { get; set; }

    public virtual DbSet<Bot13Trade> Bot13Trades { get; set; }

    public virtual DbSet<Bot14Cycle> Bot14Cycles { get; set; }

    public virtual DbSet<Bot14OperazioniChiuse> Bot14OperazioniChiuses { get; set; }

    public virtual DbSet<Bot14Signal> Bot14Signals { get; set; }

    public virtual DbSet<Bot14Trade> Bot14Trades { get; set; }

    public virtual DbSet<Bot15Cycle> Bot15Cycles { get; set; }

    public virtual DbSet<Bot15OperazioniChiuse> Bot15OperazioniChiusees { get; set; }

    public virtual DbSet<Bot15Signal> Bot15Signals { get; set; }

    public virtual DbSet<Bot15Trade> Bot15Trades { get; set; }
    public virtual DbSet<Bot16Cycle> Bot16Cycles { get; set; }

    public virtual DbSet<Bot16OperazioniChiuse> Bot16OperazioniChiusees { get; set; }

    public virtual DbSet<Bot16Signal> Bot16Signals { get; set; }

    public virtual DbSet<Bot16Trade> Bot16Trades { get; set; }


    public virtual DbSet<Bot17Cycle> Bot17Cycles { get; set; }

    public virtual DbSet<Bot17OperazioniChiuse> Bot17OperazioniChiusees { get; set; }

    public virtual DbSet<Bot17Signal> Bot17Signals { get; set; }

    public virtual DbSet<Bot17Trade> Bot17Trades { get; set; }

    public virtual DbSet<Bot18Cycle> Bot18Cycles { get; set; }

    public virtual DbSet<Bot18OperazioniChiuse> Bot18OperazioniChiusees { get; set; }

    public virtual DbSet<Bot18Signal> Bot18Signals { get; set; }

    public virtual DbSet<Bot18Trade> Bot18Trades { get; set; }

    public virtual DbSet<Bot19Cycle> Bot19Cycles { get; set; }

    public virtual DbSet<Bot19OperazioniChiuse> Bot19OperazioniChiusees { get; set; }

    public virtual DbSet<Bot19Signal> Bot19Signals { get; set; }

    public virtual DbSet<Bot19Trade> Bot19Trades { get; set; }

    public virtual DbSet<Bot1Cycle> Bot1Cycles { get; set; }

    public virtual DbSet<Bot1OperazioniChiuse> Bot1OperazioniChiuses { get; set; }

    public virtual DbSet<Bot1Signal> Bot1Signals { get; set; }

    public virtual DbSet<Bot1Trade> Bot1Trades { get; set; }

    public virtual DbSet<Bot20Cycle> Bot20Cycles { get; set; }

    public virtual DbSet<Bot20OperazioniChiuse> Bot20OperazioniChiusees { get; set; }

    public virtual DbSet<Bot20Signal> Bot20Signals { get; set; }

    public virtual DbSet<Bot20Trade> Bot20Trades { get; set; }

    public virtual DbSet<Bot6Cycle> Bot6Cycles { get; set; }

    public virtual DbSet<Bot6OperazioniChiuse> Bot6OperazioniChiuses { get; set; }

    public virtual DbSet<Bot6Signal> Bot6Signals { get; set; }

    public virtual DbSet<Bot6Trade> Bot6Trades { get; set; }

    public virtual DbSet<Bot7Cycle> Bot7Cycles { get; set; }

    public virtual DbSet<Bot7OperazioniChiuse> Bot7OperazioniChiuses { get; set; }

    public virtual DbSet<Bot7Signal> Bot7Signals { get; set; }

    public virtual DbSet<Bot7Trade> Bot7Trades { get; set; }

    public virtual DbSet<Bot8Cycle> Bot8Cycles { get; set; }

    public virtual DbSet<Bot8OperazioniChiuse> Bot8OperazioniChiuses { get; set; }

    public virtual DbSet<Bot8Signal> Bot8Signals { get; set; }

    public virtual DbSet<Bot8Trade> Bot8Trades { get; set; }

    public virtual DbSet<Bot9Cycle> Bot9Cycles { get; set; }

    public virtual DbSet<Bot9OperazioniChiuse> Bot9OperazioniChiuses { get; set; }

    public virtual DbSet<Bot9Signal> Bot9Signals { get; set; }

    public virtual DbSet<Bot9Trade> Bot9Trades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bot10Cycle>(entity =>
        {
            entity.ToTable("bot10_cycles", "bot10");

            entity.HasIndex(e => e.StartTime, "IX_bot10_cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 10", "DF_bot10_cycles_Bot");
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot10OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot10_operazioni_chiuse", "bot10");

            entity.HasIndex(e => e.CloseTime, "IX_bot10_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "IX_bot10_operazioni_chiuse_TradeId");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 10", "DF_bot10_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot10Signal>(entity =>
        {
            entity.ToTable("bot10_signals", "bot10");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_bot10_signals_Symbol_SignalCandleTime");

            entity.Property(e => e.Atr)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("ATR");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 10", "DF_bot10_signals_Bot");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Sma200)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("SMA200");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot10Trade>(entity =>
        {
            entity.ToTable("bot10_trades", "bot10");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_bot10_trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 10", "DF_bot10_trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot11Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("bot11_cycles", "bot11");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 11", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot11OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot11_operazioni_chiuse", "bot11");

            entity.HasIndex(e => e.CloseTime, "IX_bot11_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_bot11_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 11", "DF_bot11_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot11Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("bot11_signals", "bot11");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 11", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot11Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("bot11_trades", "bot11");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 11", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot12Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("bot12_cycles", "bot12");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 12", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot12OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot12_operazioni_chiuse", "bot12");

            entity.HasIndex(e => e.CloseTime, "IX_bot12_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_bot12_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 12", "DF_bot12_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot12Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("bot12_signals", "bot12");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 12", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot12Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("bot12_trades", "bot12");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 12", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot13Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("bot13_cycles", "bot13");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 13", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot13OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot13_operazioni_chiuse", "bot13");

            entity.HasIndex(e => e.CloseTime, "IX_bot13_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_bot13_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 13", "DF_bot13_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot13Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("bot13_signals", "bot13");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 13", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot13Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("bot13_trades", "bot13");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 13", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot14Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("bot14_cycles", "bot14");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 14", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot14OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot14_operazioni_chiuse", "bot14");

            entity.HasIndex(e => e.CloseTime, "IX_bot14_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_bot14_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 14", "DF_bot14_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot14Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("bot14_signals", "bot14");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 14", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot14Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("bot14_trades", "bot14");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 14", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });
        modelBuilder.Entity<Bot15Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("Bot15_cycles", "Bot15");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 15", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot15OperazioniChiuse>(entity =>
        {
            entity.ToTable("Bot15_operazioni_chiuse", "Bot15");

            entity.HasIndex(e => e.CloseTime, "IX_Bot15_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_Bot15_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 15", "DF_Bot15_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot15Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("Bot15_signals", "Bot15");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 15", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot15Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("Bot15_trades", "Bot15");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 15", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot16Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("Bot16_cycles", "Bot16");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 16", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot16OperazioniChiuse>(entity =>
        {
            entity.ToTable("Bot16_operazioni_chiuse", "Bot16");

            entity.HasIndex(e => e.CloseTime, "IX_Bot16_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_Bot16_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 16", "DF_Bot16_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot16Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("Bot16_signals", "Bot16");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 16", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot16Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("Bot16_trades", "Bot16");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 16", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot17Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("Bot17_cycles", "Bot17");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 17", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot17OperazioniChiuse>(entity =>
        {
            entity.ToTable("Bot17_operazioni_chiuse", "Bot17");

            entity.HasIndex(e => e.CloseTime, "IX_Bot17_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_Bot17_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 17", "DF_Bot17_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot17Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("Bot17_signals", "Bot17");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 17", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot17Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("Bot17_trades", "Bot17");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 17", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot18Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("Bot18_cycles", "Bot18");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 18", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot18OperazioniChiuse>(entity =>
        {
            entity.ToTable("Bot18_operazioni_chiuse", "Bot18");

            entity.HasIndex(e => e.CloseTime, "IX_Bot18_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_Bot18_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 18", "DF_Bot18_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot18Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("Bot18_signals", "Bot18");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 18", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot18Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("Bot18_trades", "Bot18");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 18", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot19Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("Bot19_cycles", "Bot19");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 19", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot19OperazioniChiuse>(entity =>
        {
            entity.ToTable("Bot19_operazioni_chiuse", "Bot19");

            entity.HasIndex(e => e.CloseTime, "IX_Bot19_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_Bot19_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 19", "DF_Bot19_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot19Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("Bot19_signals", "Bot19");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 19", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot19Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("Bot19_trades", "Bot19");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 19", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });


        modelBuilder.Entity<Bot1Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("bot1_cycles", "bot1");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 1", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot1OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot1_operazioni_chiuse", "bot1");

            entity.HasIndex(e => e.CloseTime, "IX_bot1_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_bot1_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 1", "DF_bot1_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot1Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("bot1_signals", "bot1");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 1", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot1Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("bot1_trades", "bot1");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 1", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot20Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cycles");

            entity.ToTable("Bot20_cycles", "Bot20");

            entity.HasIndex(e => e.StartTime, "IX_Cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 20", "DF_Cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot20OperazioniChiuse>(entity =>
        {
            entity.ToTable("Bot20_operazioni_chiuse", "Bot20");

            entity.HasIndex(e => e.CloseTime, "IX_Bot20_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_Bot20_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 20", "DF_Bot20_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot20Signal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Signals");

            entity.ToTable("Bot20_signals", "Bot20");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_Signals_Symbol_SignalCandleTime");

            entity.Property(e => e.AvgVolume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 20", "DF_Signals_Bot");
            entity.Property(e => e.CandleBodyStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Ema10)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA10");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema30)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA30");
            entity.Property(e => e.Ema5)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA5");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
            entity.Property(e => e.Volume).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.VolumeRatio).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot20Trade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Trades");

            entity.ToTable("Bot20_trades", "Bot20");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_Trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 20", "DF_Trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Isin).HasMaxLength(12);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });


        modelBuilder.Entity<Bot6Cycle>(entity =>
        {
            entity.ToTable("bot6_cycles", "bot6");

            entity.HasIndex(e => e.StartTime, "IX_bot6_cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 6", "DF_bot6_cycles_Bot");
            entity.Property(e => e.BtcRegime).HasMaxLength(20);
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot6OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot6_operazioni_chiuse", "bot6");

            entity.HasIndex(e => e.CloseTime, "IX_bot6_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "UX_bot6_operazioni_chiuse_TradeId").IsUnique();

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 6", "DF_bot6_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot6Signal>(entity =>
        {
            entity.ToTable("bot6_signals", "bot6");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_bot6_signals_Symbol_SignalCandleTime");

            entity.Property(e => e.Atr)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("ATR");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 6", "DF_bot6_signals_Bot");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema200)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA200");
            entity.Property(e => e.Ema50)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA50");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot6Trade>(entity =>
        {
            entity.ToTable("bot6_trades", "bot6");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_bot6_trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 6", "DF_bot6_trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot7Cycle>(entity =>
        {
            entity.ToTable("bot7_cycles", "bot7");

            entity.HasIndex(e => e.StartTime, "IX_bot7_cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 7", "DF_bot7_cycles_Bot");
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot7OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot7_operazioni_chiuse", "bot7");

            entity.HasIndex(e => e.CloseTime, "IX_bot7_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "IX_bot7_operazioni_chiuse_TradeId");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 7", "DF_bot7_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot7Signal>(entity =>
        {
            entity.ToTable("bot7_signals", "bot7");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_bot7_signals_Symbol_SignalCandleTime");

            entity.Property(e => e.Atr)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("ATR");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 7", "DF_bot7_signals_Bot");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema50)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA50");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot7Trade>(entity =>
        {
            entity.ToTable("bot7_trades", "bot7");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_bot7_trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 7", "DF_bot7_trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot8Cycle>(entity =>
        {
            entity.ToTable("bot8_cycles", "bot8");

            entity.HasIndex(e => e.StartTime, "IX_bot8_cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 8", "DF_bot8_cycles_Bot");
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot8OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot8_operazioni_chiuse", "bot8");

            entity.HasIndex(e => e.CloseTime, "IX_bot8_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "IX_bot8_operazioni_chiuse_TradeId");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 8", "DF_bot8_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot8Signal>(entity =>
        {
            entity.ToTable("bot8_signals", "bot8");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_bot8_signals_Symbol_SignalCandleTime");

            entity.Property(e => e.Atr)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("ATR");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 8", "DF_bot8_signals_Bot");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema50)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA50");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot8Trade>(entity =>
        {
            entity.ToTable("bot8_trades", "bot8");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_bot8_trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 8", "DF_bot8_trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        modelBuilder.Entity<Bot9Cycle>(entity =>
        {
            entity.ToTable("bot9_cycles", "bot9");

            entity.HasIndex(e => e.StartTime, "IX_bot9_cycles_StartTime");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 9", "DF_bot9_cycles_Bot");
            entity.Property(e => e.CapitalCommitted).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RealizedPnl).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
        });

        modelBuilder.Entity<Bot9OperazioniChiuse>(entity =>
        {
            entity.ToTable("bot9_operazioni_chiuse", "bot9");

            entity.HasIndex(e => e.CloseTime, "IX_bot9_operazioni_chiuse_CloseTime");

            entity.HasIndex(e => e.TradeId, "IX_bot9_operazioni_chiuse_TradeId");

            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 9", "DF_bot9_operazioni_chiuse_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot9Signal>(entity =>
        {
            entity.ToTable("bot9_signals", "bot9");

            entity.HasIndex(e => new { e.Symbol, e.SignalCandleTime }, "IX_bot9_signals_Symbol_SignalCandleTime");

            entity.Property(e => e.Atr)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("ATR");
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 9", "DF_bot9_signals_Bot");
            entity.Property(e => e.Ema20)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA20");
            entity.Property(e => e.Ema50)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("EMA50");
            entity.Property(e => e.ExpectedProfit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.RiskRewardRatio).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Rs)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RS");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(38, 18)")
                .HasColumnName("RSI");
            entity.Property(e => e.Signal).HasMaxLength(200);
            entity.Property(e => e.SignalStrength).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Target).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Timeframe).HasMaxLength(10);
            entity.Property(e => e.TradeId).HasMaxLength(36);
        });

        modelBuilder.Entity<Bot9Trade>(entity =>
        {
            entity.ToTable("bot9_trades", "bot9");

            entity.HasIndex(e => new { e.Symbol, e.Status }, "IX_bot9_trades_Symbol_Status");

            entity.Property(e => e.Id).HasMaxLength(36);
            entity.Property(e => e.Bot)
                .HasMaxLength(50)
                .HasDefaultValue("Bot 9", "DF_bot9_trades_Bot");
            entity.Property(e => e.EntryPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitPrice).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExitReason).HasMaxLength(100);
            entity.Property(e => e.PositionSize).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Profit).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ProfitPercentage).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StopLoss).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.Strategy).HasMaxLength(200);
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.TargetPrice).HasColumnType("decimal(38, 18)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
