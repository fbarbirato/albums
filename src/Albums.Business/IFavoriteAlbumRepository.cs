using System.Threading.Tasks;
using Albums.DTO;

namespace Albums.Business
{
    public interface IFavoriteAlbumRepository
    {
        void Add(Task<Album> album);
    }
}