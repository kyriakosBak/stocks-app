using StocksApp.Data.Models;
using StocksApp.DTOs;

namespace StocksApp.Mappings;

public static class StockMapping
{
    public static StockDto ToDto(this Stock stock)
    {
        return new StockDto
        {
            Name = stock.Name,
            Symbol = stock.Symbol,
            Price = stock.Price,
            PercentChange = stock.PercentChange
        };
    }

    public static Stock ToEntity(this StockDto stockDto)
    {
        return new Stock
        {
            Name = stockDto.Name,
            Symbol = stockDto.Symbol,
            Price = stockDto.Price,
            PercentChange = stockDto.PercentChange
        };
        
    }
}