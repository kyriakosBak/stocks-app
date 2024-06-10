using Microsoft.EntityFrameworkCore;
using StocksApp.Data.Models;

namespace StocksApp.Data;

public class StockDbContext : DbContext
{
    public DbSet<Stock> Stocks { get; set; } = null!;
    
    public StockDbContext(DbContextOptions<StockDbContext> options) : base(options)
    {
    }
}
