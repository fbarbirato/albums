using Albums.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Albums.MusicProvider
{
    public interface IMusicGateway
    {
        Task<IEnumerable<Album>> GetAlbumsFor(int userId);
    }
}
