using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StocksApp.DTOs;
using StocksApp.Mappings;

namespace StocksApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IStockService _stockDataService;
    private readonly IPhraseService _phraseService;

    public IndexModel(ILogger<IndexModel> logger, IPhraseService phraseService, IStockService stockDataService)
    {
        _logger = logger;
        _phraseService = phraseService;
        _stockDataService = stockDataService;
    }

    public IEnumerable<StockDto> AllStockData { get; set; } = new List<StockDto>();

    public void OnGet()
    {
        AllStockData = _stockDataService.GetAllStocks().Select(x => x.ToDto());
    }

    public string GetRandomPhrase() => "Random phrase";
}
