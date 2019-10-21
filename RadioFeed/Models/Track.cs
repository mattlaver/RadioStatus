namespace RadioFeed.Models
{
    public class Track
    {
        public string Artist { get; }
        public string Title { get; }


        public Track(string artist, string title)
        {
            Artist = artist;
            Title = title;
        }
    }
}