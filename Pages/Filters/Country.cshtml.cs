using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;
using Refit;
using InfoCovid.Models;
using System.Linq;

namespace InfoCovid.Pages.Filters
{
  public class CountryModel : PageModel
  {
    private readonly ILogger<CountryModel> _logger;
    public Country Country { get; private set; }
    public Country[] Countries { get; private set; }
    public IMemoryCache MemoryCache { get; private set; }

    public CountryModel(ILogger<CountryModel> logger, IMemoryCache memoryCache)
    {
      _logger = logger;
      MemoryCache = memoryCache;
    }

    public async Task OnGetAsync(string pais)
    {
      try
      {
        string key_countries = "countries_key";
        if (!MemoryCache.TryGetValue<Country[]>(key_countries, out Country[] values))
        {
          var create = RestService.For<IGetRoot>("https://api.covid19api.com/summary");
          var result = await create.GetAsync();
          Countries = result.Countries;
          Country = (Country) from item in result.Countries where (item.Name == pais) select item;
          MemoryCache.Set(key_countries, Countries, System.TimeSpan.FromMinutes(30));
        }
        else
        {
          Country = (Country) from item in values where (item.Name == pais) select item;
        }
      }
      catch (Exception e)
      {
        _logger.LogInformation("Erro na requisição http: " + e.Message);
      }
    }
  }
}