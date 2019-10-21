using System.Linq;
using System.Threading.Tasks;
using BbcFeed.Api;
using RadioFeed;
using RadioFeed.Models;
using Refit;

namespace BbcFeed
{
    public class BbcRadioFeed : IRadioFeed
    {
        private readonly string[] _supportedStations =  {"bbc_6music"};
        public async Task<Track> NowPlaying(string station)
        {
            if (!_supportedStations.Contains(station)) return null;

            var realTimeFeed = RestService.For<IRealtimePolling>("https://polling.bbc.co.uk/");
            var pollingService = new RealtimePollingService(realTimeFeed);

            var track = await pollingService.Poll(station);

            return new Track(track.Packages.Richtracks[0].Artist, track.Packages.Richtracks[0].Title);
        }

        public bool HasStation(string station) => _supportedStations.Contains(station);
    }
}
