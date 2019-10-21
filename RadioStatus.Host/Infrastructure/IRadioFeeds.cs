using System.Collections.Generic;
using System.Linq;
using RadioFeed;

namespace RadioStatus.Host.Infrastructure
{
    public class RadioFeeds : IRadioFeeds
    {
        private readonly IEnumerable<IRadioFeed> _feeds;

        public RadioFeeds(IEnumerable<IRadioFeed> feeds) => _feeds = feeds;

        public IRadioFeed Get(string station) => _feeds.SingleOrDefault(x => x.HasStation(station));
    }
}
