using Microsoft.EntityFrameworkCore;

namespace Web.API.Data
{
    public class EfContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("moooo");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int itemId = 1;

            modelBuilder.Entity<ItemEntity>().HasData(
                new ItemEntity()
                {
                    Id = itemId++,
                    Title = "Big Tractor",
                    Description = "For moving big things",
                    PhotoUrl = @"https://gray-wmtv-prod.cdn.arcpublishing.com/resizer/2_gyrYkEs51z_TukWoXsi3IsDoE=/1200x675/smart/filters:quality(85)/cloudfront-us-east-1.images.arcpublishing.com/gray/P55U7GBEB5D4ZM7UJ7DUUBH4FE.jpg"
                },
                new ItemEntity()
                {
                    Id = itemId++,
                    Title = "Bigger Tractor",
                    Description = "For moving bigger things",
                    PhotoUrl = @"https://media.npr.org/assets/img/2017/04/07/ap_302681179763-d9f2338c25a2b6d103da939eac3c71f67a54e6dc.jpg"
                },
                new ItemEntity()
                {
                    Id = itemId++,
                    Title = "Biggest Tractor",
                    Description = "Kevin Neilsen's tractor pull tractor",
                    PhotoUrl = @"https://www.carlogos.org/uploads/2021/biggest-tractors-in-the-world.jpg"
                },
                new ItemEntity()
                {
                    Id = itemId++,
                    Title = "Little Tractor",
                    Description = "the little tractor that could",
                    PhotoUrl = @"https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Mahindra_tractor_model2.jpg/1200px-Mahindra_tractor_model2.jpg"
                },
                new ItemEntity()
                {
                    Id = itemId++,
                    Title = "Toy Tractor",
                    Description = "The thing John steps on in the night",
                    PhotoUrl = @"https://m.media-amazon.com/images/I/613+Gb9u3IL._AC_SX522_.jpg"
                }
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ItemEntity> Items { get; private set; }

        public DbSet<BidEntity> Bids { get; private set; }
    }
}
