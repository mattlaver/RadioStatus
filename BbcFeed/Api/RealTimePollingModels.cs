using System;
using Newtonsoft.Json;

namespace BbcFeed.Api
{
    public class RealtimePollingResult
    {
        [JsonProperty("generated")] public DateTimeOffset Generated { get; set; }

        [JsonProperty("providers")] public string[] Providers { get; set; }

        [JsonProperty("packages")] public Packages Packages { get; set; }

        [JsonProperty("timeouts")] public Timeouts Timeouts { get; set; }
    }

    public class Packages
    {
        [JsonProperty("richtracks")] public Richtrack[] Richtracks { get; set; }

        [JsonProperty("on-air")] public OnAir OnAir { get; set; }
    }

    public class OnAir
    {
        [JsonProperty("broadcasts")] public Next[] Broadcasts { get; set; }

        [JsonProperty("broadcastNowIndex")] public long BroadcastNowIndex { get; set; }

        [JsonProperty("now")] public Next Now { get; set; }

        [JsonProperty("next")] public Next Next { get; set; }
    }

    public class Next
    {
        [JsonProperty("entityName")] public string EntityName { get; set; }

        [JsonProperty("pid")] public string Pid { get; set; }

        [JsonProperty("imagePID")] public string ImagePid { get; set; }

        [JsonProperty("imageTemplateURL")] public string ImageTemplateUrl { get; set; }

        [JsonProperty("url")] public string Url { get; set; }

        [JsonProperty("title")] public string Title { get; set; }

        [JsonProperty("shortSynopsis")] public string ShortSynopsis { get; set; }

        [JsonProperty("shortestSynopsis")] public string ShortestSynopsis { get; set; }

        [JsonProperty("mediumSynopsis")] public string MediumSynopsis { get; set; }

        [JsonProperty("mediumestSynopsis")] public string MediumestSynopsis { get; set; }

        [JsonProperty("longSynopsis")] public string LongSynopsis { get; set; }

        [JsonProperty("longestSynopsis")] public string LongestSynopsis { get; set; }

        [JsonProperty("duration")] public string Duration { get; set; }

        [JsonProperty("mediaType")] public string MediaType { get; set; }

        [JsonProperty("canShare")] public bool CanShare { get; set; }

        [JsonProperty("canFavourite")] public bool CanFavourite { get; set; }

        [JsonProperty("canPlay")] public bool CanPlay { get; set; }

        [JsonProperty("canLove")] public bool CanLove { get; set; }

        [JsonProperty("percentage")] public long Percentage { get; set; }

        [JsonProperty("isOnNow")] public bool IsOnNow { get; set; }

        [JsonProperty("start_time")] public string StartTime { get; set; }

        [JsonProperty("end_time")] public string EndTime { get; set; }

        [JsonProperty("primary_title")] public string PrimaryTitle { get; set; }

        [JsonProperty("secondary_title")] public string SecondaryTitle { get; set; }
    }

    public class Richtrack
    {
        [JsonProperty("record_id")] public string RecordId { get; set; }

        [JsonProperty("artist")] public string Artist { get; set; }

        [JsonProperty("contributions")] public Contribution[] Contributions { get; set; }

        [JsonProperty("title")] public string Title { get; set; }

        [JsonProperty("duration")] public Duration Duration { get; set; }

        [JsonProperty("start")] public string Start { get; set; }

        [JsonProperty("end")] public string End { get; set; }

        [JsonProperty("service")] public Service Service { get; set; }

        [JsonProperty("musicbrainz_id")] public string MusicbrainzId { get; set; }

        [JsonProperty("image")] public Image Image { get; set; }

        [JsonProperty("is_now_playing")] public bool IsNowPlaying { get; set; }

        [JsonProperty("programme_offset")] public long ProgrammeOffset { get; set; }

        [JsonProperty("has_snippet")] public bool HasSnippet { get; set; }

        [JsonProperty("last_played")] public long LastPlayed { get; set; }

        [JsonProperty("track_type")] public string TrackType { get; set; }
    }

    public class Contribution
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("role")] public string Role { get; set; }

        [JsonProperty("musicbrainz_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MusicbrainzId { get; set; }

        [JsonProperty("sort_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SortName { get; set; }

        [JsonProperty("image_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string ImagePid { get; set; }

        [JsonProperty("contributor_pid")] public string ContributorPid { get; set; }

        [JsonProperty("contribution_pid")] public string ContributionPid { get; set; }
    }

    public class Duration
    {
        [JsonProperty("seconds")] public long Seconds { get; set; }

        [JsonProperty("minutes")] public long Minutes { get; set; }
    }

    public class Image
    {
        [JsonProperty("pid")] public string Pid { get; set; }

        [JsonProperty("type")] public string Type { get; set; }
    }

    public class Service
    {
        [JsonProperty("sid")] public string Sid { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("region")] public string Region { get; set; }
    }

    public class Timeouts
    {
        [JsonProperty("polling_timeout")] public long PollingTimeout { get; set; }
    }
}
