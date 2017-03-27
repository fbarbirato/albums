using System;
using System.Collections.Generic;
using System.Text;
using Albums.DTO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Albums.MusicProvider;

namespace Albums.Deezer.Client
{
    public class DeezerMusicGateway : IMusicGateway
    {
        public async Task<IEnumerable<Album>> GetAlbumsFor(int userId)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri($"https://api.deezer.com/user/{userId}/albums");
                var response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                var albums = JsonConvert.DeserializeObject<DeezerAlbumsDTO>(content);

                return albums.data;
            }
        }
    }
}
