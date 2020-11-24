using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dependency.Injection.Core.Services
{
    public class AlbumService: IAlbumService
    {
        private readonly WebAppContext context;

        public AlbumService()
        {
            context = new WebAppContext();
        }

        public async Task<List<Album>> GetAlbumsAsync()
        {
            var ret = new List<Album>();
            ret = await context.Albums.ToListAsync();
            return ret;
        }
    }
}
