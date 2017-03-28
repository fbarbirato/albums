using Albums.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albums.Api.Models
{
    public class GetMyAlbumsResponse
    {
        IEnumerable<Album> MyAlbums { get; set; }
    }
}
