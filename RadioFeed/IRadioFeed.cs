using System.Threading.Tasks;
using RadioFeed.Models;

namespace RadioFeed
{
    public interface IRadioFeed
    {
        Task<Track> NowPlaying(string station);

        bool HasStation(string station);
    }
}
