using System.Threading.Tasks;
using BbcFeed;
using Xunit;

namespace RadioStatus.IntegrationTests
{
    public class BbcTests
    {
        [Theory]
        [InlineData("bbc_6music")]
        public async Task Should_Return_Current_Playing_Track(string station)
        {
            var bbcFeed = new BbcRadioFeed();

            var track = await bbcFeed.NowPlaying(station);

            Assert.NotNull(track);
            Assert.NotEmpty(track.Artist);
            Assert.NotEmpty(track.Title);
        }
    }
}
