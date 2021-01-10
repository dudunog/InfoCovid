using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;

namespace InfoCovid.Pages.Filters
{
  public class TodayModel : PageModel
  {
    private readonly ILogger<TodayModel> _logger;
    public IMemoryCache MemoryCache { get; private set; }

    public TodayModel(ILogger<TodayModel> logger, IMemoryCache memoryCache)
    {
      _logger = logger;
      MemoryCache = memoryCache;
    }

    public void OnGet()
    {
    }
  }
}