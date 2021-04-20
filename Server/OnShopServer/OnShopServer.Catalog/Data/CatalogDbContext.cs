namespace OnShopServer.Catalog.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
            : base(options)
        {
        }

        protected DbSet<Category> Categories { get; set; }

        protected DbSet<Product> Products { get; set; }
      

    }
}
