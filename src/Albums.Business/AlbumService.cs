using System;
using System.Collections.Generic;
using System.Text;
using Albums.DTO;
using System.Threading.Tasks;
using Albums.MusicProvider;

namespace Albums.Business
{
    public class AlbumService : IAlbumService
    {
        private IMusicGateway MusicGateway { get; set; }

        public AlbumService(IMusicGateway musicGateway)
        {
            if (musicGateway == null)
            {
                throw new ArgumentNullException(nameof(musicGateway));
            }

            MusicGateway = musicGateway;
        }

        public async Task<IEnumerable<Album>> GetAlbumsFor(int userId)
        {
            var albums = await MusicGateway.GetAlbumsFor(userId);

            return albums;
        }
    }
}
