using StocksApp.Data;
using StocksApp.Data.Models;

public interface IStockService
{
    public IEnumerable<Stock> GetAllStocks();
}

public class StockService : IStockService
{
    private readonly StockDbContext _context;

    public StockService(StockDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Stock> GetAllStocks()
    {
        return _context.Stocks.ToList();
    }
}
