using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;

namespace InfoCovid.Pages.Filters
{
  public class DeathsModel : PageModel
  {
    private readonly ILogger<DeathsModel> _logger;
    public IMemoryCache MemoryCache { get; private set; }

    public DeathsModel(ILogger<DeathsModel> logger, IMemoryCache memoryCache)
    {
      _logger = logger;
      MemoryCache = memoryCache;
    }

    public void OnGet()
    {
    }
  }
}