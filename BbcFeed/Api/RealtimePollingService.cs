using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BbcFeed.Api
{
    internal class RealtimePollingService
    {
        private readonly IRealtimePolling _realtimePolling;
        private readonly string _callbackPrefix = "nhprealtimepolling(";

        public RealtimePollingService(IRealtimePolling realtimePolling)
        {
            _realtimePolling = realtimePolling;
        }

        public async Task<RealtimePollingResult> Poll(string station)
        {
            var payloadWithCallback = await _realtimePolling.Get(station);
            var payloadJson = payloadWithCallback
                .Remove(payloadWithCallback.Length - 1)
                .Replace(_callbackPrefix, string.Empty);
            return JsonConvert.DeserializeObject<RealtimePollingResult>(payloadJson);
        }
    }


}
