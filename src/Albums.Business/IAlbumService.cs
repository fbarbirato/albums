using Albums.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Albums.Business
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAlbumsFor(int userId);
    }
}
