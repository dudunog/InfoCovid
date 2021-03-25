using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;
using Refit;
using InfoCovid.Models;
using Newtonsoft.Json;

namespace InfoCovid.Pages.Filters
{
  public class CountriesModel : PageModel
  {
    private readonly ILogger<CountriesModel> _logger;
    public DateTime Date { get; private set; }
    public Country[] Countries { get; private set; }
    public IMemoryCache MemoryCache { get; private set; }

    public CountriesModel(ILogger<CountriesModel> logger, IMemoryCache memoryCache)
    {
      _logger = logger;
      MemoryCache = memoryCache;
    }

    public async Task OnGetAsync()
    {
      try
      {
        string key_countries = "countries_key";
        string key_date = "date_key";

        Country[] countries = null;
        DateTime date = DateTime.MinValue;

        if (!MemoryCache.TryGetValue<Country[]>(key_countries, out countries) &&
            (!MemoryCache.TryGetValue<DateTime>(key_date, out date)))
        {
          var create = RestService.For<IGetRoot>("https://api.covid19api.com/summary");
          var result = await create.GetAsync();
          Countries = result.Countries;
          Date = result.Date;
          MemoryCache.Set(key_countries, Countries, System.TimeSpan.FromMinutes(30));
          MemoryCache.Set(key_date, Date, System.TimeSpan.FromMinutes(30));
        }
        else
        {
          Countries = countries;
          Date = (DateTime)MemoryCache.Get(key_date);
        }
      }
      catch (Exception e)
      {
        _logger.LogInformation("Erro na requisição http: " + e.Message);
      }
    }
  }
}
