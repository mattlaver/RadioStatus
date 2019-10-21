using BbcFeed;
using Xunit;

namespace RadioStatus.UnitTests
{
    public class BbcTests
    {
        [Theory]
        [InlineData("bbc_6music")]
        public void Should_Return_True_For_Supported_Stations(string station)
        {
            var bbcFeed = new BbcRadioFeed();

            var hasStation = bbcFeed.HasStation(station);
            Assert.True(hasStation);
        }

        [Theory]
        [InlineData("")]
        [InlineData("unsupported")]
        public void Should_Return_False_For_Unsupported_Stations(string station)
        {
            var bbcFeed = new BbcRadioFeed();

            var hasStation = bbcFeed.HasStation(station);
            Assert.False(hasStation);
        }
    }
}
