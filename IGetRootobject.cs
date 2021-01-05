using System.Threading.Tasks;
using Refit;
using InfoCovid.Models;

namespace InfoCovid
{
  public interface IGetRootobject
  {
    [Get("")]
    Task<Rootobject> GetAsync();
  }
}