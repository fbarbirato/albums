using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Albums.Api.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Albums.Business;

namespace Albums.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Albums")]
    public class AlbumsController : Controller
    {
        private IAlbumService AlbumService { get; set; }

        public AlbumsController(IAlbumService albumservice)
        {
            if (albumservice == null)
            {
                throw new ArgumentNullException(nameof(albumservice));
            }

            AlbumService = albumservice;
        }

        // GET: api/Albums
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var felipe = 668264557;

            var albums = await AlbumService.GetAlbumsFor(felipe);

            return Ok(albums);
        }

        // GET: api/Albums/5
        [HttpGet("{albumId}")]
        public async Task<IActionResult> GetAsync(int albumId)
        {
            var album = await AlbumService.GetIndividualAlbum(albumId);

            return Ok(album);
        }

        // POST: api/Albums
        [HttpPost("{albumId}")]
        public void AddToFavorite(int albumId)
        {
            AlbumService.AddToFavorite(albumId);
        }
        
        // PUT: api/Albums/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
