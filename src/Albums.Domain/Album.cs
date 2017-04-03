using System;

namespace Albums.Domain
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public int NumberOfTracks { get; set; }
        public string ReleaseDate { get; set; }

        public int DeezerId { get; set; }
    }
}
