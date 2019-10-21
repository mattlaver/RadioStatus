using System.Threading.Tasks;
using Refit;

namespace BbcFeed.Api
{
    internal interface IRealtimePolling
    {
        [Get("/radio/nhppolling/{station}?&callback=nhprealtimepolling")]
        Task<string> Get(string station);
    }
}
