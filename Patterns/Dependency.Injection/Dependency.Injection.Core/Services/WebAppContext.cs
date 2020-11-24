using Microsoft.EntityFrameworkCore;

namespace Dependency.Injection.Core.Services
{
    public class WebAppContext: DbContext
    {
        public WebAppContext()
        { }

        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("DI_DB");
        }
    }
}