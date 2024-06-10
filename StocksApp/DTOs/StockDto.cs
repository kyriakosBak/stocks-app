namespace StocksApp.DTOs;

public class StockDto
{
    public string Name { get; set; } = string.Empty;
    public string Symbol { get; set; } = string.Empty;
    public double Price { get; set; }
    public float PercentChange { get; set; }
}