using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using RadioFeed;
using RadioFeed.Models;

namespace RadioStatus.Host.V1.Playing
{
    [Route("api/v1/[controller]")]
    public class StationController : ControllerBase
    {
        private readonly IRadioFeeds _radioFeeds;
        private readonly IMemoryCache _cache;


        public StationController(IRadioFeeds radioFeeds, IMemoryCache cache)
        {
            _radioFeeds = radioFeeds;
            _cache = cache;
        }

        [HttpGet("{station}/playing")]
        public async Task<ActionResult<Track>> Playing(string station)
        {
            if (_cache.TryGetValue<Track>(station, out var currentTrack)) return currentTrack;

            var radioFeed = _radioFeeds.Get(station);
            if (radioFeed == null) return NotFound($"Station {station} not found");

            var track = await radioFeed.NowPlaying(station);

            _cache.Set(station, track, TimeSpan.FromSeconds(20));

            return Ok(track);
        }
    }
}
