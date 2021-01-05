using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;
using Refit;
using InfoCovid.Models;

namespace InfoCovid.Pages.Filters
{
  public class CitiesModel : PageModel
  {
    private readonly ILogger<CitiesModel> _logger;
    public Country[] Countries { get; private set; }
    public IMemoryCache MemoryCache { get; private set; }

    public CitiesModel(ILogger<CitiesModel> logger, IMemoryCache memoryCache)
    {
      _logger = logger;
      MemoryCache = memoryCache;
    }

    public async Task OnGetAsync()
    {
      try
      {
        string key_contries = "contries_key";
        if (!MemoryCache.TryGetValue<Country[]>(key_contries, out Country[] values))
        {
          var create = RestService.For<IGetRootobject>("https://api.covid19api.com/summary");
          var result = await create.GetAsync();
          Countries = result.Countries;
          MemoryCache.Set(key_contries, Countries, System.TimeSpan.FromMinutes(30));
        }
        else
        {
          Countries = values;
        }
      }
      catch (Exception e)
      {
        _logger.LogInformation("Erro na requisição http: " + e.Message);
      }
    }
  }
}