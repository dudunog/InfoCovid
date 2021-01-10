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
    public DateTime Date { get; private set; }
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
        string key_global = "global_cache"; // Chave do cache.
        string key_date = "date_cache";

        Global global = null;
        DateTime date = DateTime.MinValue;

        if (!MemoryCache.TryGetValue<Global>(key_global, out global) &&
              (!MemoryCache.TryGetValue<DateTime>(key_date, out date))) // Verifica se há dados em cache.
        {
          var create = RestService.For<IGetRoot>("https://api.covid19api.com/summary");
          var result = await create.GetAsync(); // ou var result = create.GetAsync().GetAwaiter().GetResult();
          Global = result.Global;
          Date = result.Date;
          MemoryCache.Set(key_global, Global, System.TimeSpan.FromMinutes(30)); // Salva os dados em cache e define um tempo de expiração.
          MemoryCache.Set(key_date, Date, System.TimeSpan.FromMinutes(30));
        }
        else
        {
          Global = global;
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