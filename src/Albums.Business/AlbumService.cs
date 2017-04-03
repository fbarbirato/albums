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
        private IFavoriteAlbumRepository FavoriteAlbumRepository { get; set; }

        public AlbumService(IMusicGateway musicGateway, IFavoriteAlbumRepository favoriteAlbumRepository)
        {
            if (musicGateway == null)
            {
                throw new ArgumentNullException(nameof(musicGateway));
            }

            if(favoriteAlbumRepository == null)
            {
                throw new ArgumentNullException(nameof(favoriteAlbumRepository));
            }
            
            MusicGateway = musicGateway;

            FavoriteAlbumRepository = favoriteAlbumRepository;
        }

        public async Task<IEnumerable<Album>> GetAlbumsFor(int userId)
        {
            var albums = await MusicGateway.GetAlbumsFor(userId);

            return albums;
        }

        public Task<Album> GetIndividualAlbum(int albumId)
        {
            return MusicGateway.GetAlbumById(albumId);
        }

        public void AddToFavorite(int albumId)
        {
            var album = MusicGateway.GetAlbumById(albumId);

            FavoriteAlbumRepository.Add(album);
        }
    }
}
