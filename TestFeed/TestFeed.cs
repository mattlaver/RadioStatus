using System.Threading.Tasks;
using RadioFeed;
using RadioFeed.Models;

namespace TestFeed
{
    public class TestFeed : IRadioFeed
    {
        public async Task<Track> NowPlaying(string station)
        {
            return await Task.FromResult(new Track("test_artist", "test_title"));
        }

        public bool HasStation(string station) => station == "test";
    }
}
