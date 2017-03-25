using Albums.Domain;
using System;
using System.Collections.Generic;

namespace Albums.Deezer.Client
{
    public interface IMusicGateway
    {
        IEnumerable<Album> GetAlbumsFor(int userId);
    }
}
