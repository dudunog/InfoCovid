using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Refit;
using InfoCovid.Models;
using Microsoft.Extensions.Caching.Memory;

namespace InfoCovid.Pages
{
  public class IndexModel : PageModel
  {
    private readonly ILogger<IndexModel> _logger;
    public Global Global { get; private set; }
    public Country[] Countries { get; private set; }
    public IMemoryCache MemoryCache { get; private set; }
    public IndexModel(ILogger<IndexModel> logger, IMemoryCache memoryCache)
    {
      _logger = logger;
      MemoryCache = memoryCache;
    }

    public async Task OnGetAsync()
    {
      try
      {
        string key_contries = "contries_cache"; // Chave do cache.
        string key_global = "contries_global"; // Chave do cache.
        if (!MemoryCache.TryGetValue<Country[]>(key_contries, out Country[] values)) // Verifica se há dados em cache.
        {
          var create = RestService.For<IGetRootobject>("https://api.covid19api.com/summary");
          var result = await create.GetAsync(); // ou var result = create.GetAsync().GetAwaiter().GetResult();
          Global = result.Global;
          Countries = result.Countries;
          MemoryCache.Set(key_contries, Countries, System.TimeSpan.FromMinutes(30)); // Salva os dados em cache e define um tempo de expiração
          MemoryCache.Set(key_global, Global, System.TimeSpan.FromMinutes(30));
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