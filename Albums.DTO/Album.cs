using System;

namespace Albums.DTO
{
    public class Album
    {
        public int id { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string cover { get; set; }
        public int nb_tracks { get; set; }
        public string release_date { get; set; }
        public string tracklist { get; set; }
    }
}
