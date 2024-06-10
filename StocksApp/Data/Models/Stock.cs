namespace StocksApp.Data.Models;

public class Stock
{
    public string Id { get; set; }
    public string Symbol { get; init; }
    public string Name { get; init; }
    public string Currency { get; init; }
    public double Price { get; init; }
    public float PercentChange { get; init; }
}