using System.Threading.Tasks;
using Refit;
using InfoCovid.Models;

namespace InfoCovid
{
  public interface IGetRoot
  {
    [Get("")]
    Task<Root> GetAsync();
  }
}