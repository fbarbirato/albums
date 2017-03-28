using System;
using System.Collections.Generic;
using System.Text;

namespace Albums.DTO
{
    public class DeezerAlbumsDTO
    {
        public List<Album> data { get; set; }
        public int total { get; set; }
        public string next { get; set; }
    }
}
