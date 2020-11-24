using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dependency.Injection.Core.Services
{
    public interface IAlbumService
    {
        Task<List<Album>> GetAlbumsAsync();
    }
}