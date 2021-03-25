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

        public async Task OnGetAsync(string text)
        {
            try
            {
                string key_countries = "countries_key";
                if (!MemoryCache.TryGetValue<Country[]>(key_countries, out Country[] values))
                {
                    var create = RestService.For<IGetRoot>("https://api.covid19api.com/summary");
                    var result = await create.GetAsync();
                    Countries = result.Countries;
                    buscaCountryAsync(Countries, text);
                    MemoryCache.Set(key_countries, Countries, System.TimeSpan.FromMinutes(30));
                }
                else
                {
                  buscaCountryAsync(values, text);
                }
            }
            catch (Exception e)
            {
                _logger.LogInformation("Erro na requisição http: " + e.Message);
            }
        }

        public void buscaCountryAsync(Country[] values, string text)
        {
            foreach (var item in values)
            {
                if (item.Name == text)
                {
                    Country = item;
                }
            }
        }
    }
}
