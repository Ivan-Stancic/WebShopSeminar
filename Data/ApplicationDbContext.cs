using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Models.ViewModel;

namespace WebShopSeminar.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public override int SaveChanges()
        {

            var entries = ChangeTracker
                        .Entries()
                        .Where(e => e.Entity is IEntityBase && (
                          e.State == EntityState.Added
                          || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                switch (entityEntry.State)
                {
                    case EntityState.Added:
                        ((IEntityBase)entityEntry.Entity).Created = DateTime.Now;
                        break;
                    default:
                        break;
                }

            }
            return base.SaveChanges();

        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {

            var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is IEntityBase && (
              e.State == EntityState.Added
              || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                switch (entityEntry.State)
                {
                    case EntityState.Added:
                        ((IEntityBase)entityEntry.Entity).Created = DateTime.Now;
                        break;
                    default:
                        break;
                }

            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Role

            builder.Entity<IdentityRole>().HasData
            (
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = "1" },
                new IdentityRole { Name = "Editor", NormalizedName = "EDITOR", Id = "2" },
                new IdentityRole { Name = "BasicUser", NormalizedName = "BASICUSER", Id = "3" }
            );


            //Korisnici
            var hasher = new PasswordHasher<ApplicationUser?>();

            builder.Entity<ApplicationUser>().HasData
            (
                new ApplicationUser
                {
                    Id = "1",
                    Firstname = "Admin",
                    Lastname = "Adminović",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "admin@admin.com".ToUpper(),
                    Email = "admin@admin.com",
                    NormalizedEmail = "admin@admin.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password321"),
                    DOB = DateTime.Now,
                },

                new ApplicationUser
                {
                    Id = "2",
                    Firstname = "BasicUser",
                    Lastname = "Botić",
                    UserName = "user@user.com",
                    NormalizedUserName = "user@user.com".ToUpper(),
                    Email = "user@user.com",
                    NormalizedEmail = "user@user.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password321"),
                    DOB = DateTime.Now,
                });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = "1"
            },

            new IdentityUserRole<string>
            {
                RoleId = "2",
                UserId = "2"
            });


            //Kategorije
            builder.Entity<ProductCategory>().HasData(
                new ProductCategory
                {
                    Id = 1,
                    Title = "Kategorija 1",
                    Description = "Sometimes this is dangerous! Sometimes this is rough! But one thing is true… We never get, we never get enough"
                },
                new ProductCategory
                {
                    Id = 2,
                    Title = "Kategorija 2",
                    Description = "Yeah man Before success can manifest You got to go through the learning process Come... learn..."
                },
                new ProductCategory
                {
                    Id = 3,
                    Title = "Kategorija 3",
                    Description = "For sure I got my plan, don't really give a damn!"
                },
                new ProductCategory
                {
                    Id = 4,
                    Title = "Kategorija 4",
                    Description = "See the madness, watch the crowd, Fade the fear, without a doubt"
                });

            //Proizvodi
            builder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 1,
                    Title = "Balkon",
                    Description = "Izađite na balkone, pozdravite šampione!!! Dinamo!",
                    ProductCategoryId = 1,
                    Quantity = 1,
                    Price = 250,
                    ProductImgUrl = "https://www.novilist.hr/wp-content/uploads/2021/04/balcony-200431_1280.jpg"
                },

                new Product
                {
                    Id = 2,
                    Title = "Ljama",
                    Description = "pazi da te ne pljune",
                    ProductCategoryId = 2,
                    Quantity = 4,
                    Price = 50,
                    ProductImgUrl = "https://image.dnevnik.hr/media/images/1600x1067/May2022/62305330-alpake.jpg"
                },

                new Product
                {
                    Id = 3,
                    Title = "Kava",
                    Description = "Frankova kava , bar tako kažu",
                    ProductCategoryId = 3,
                    Quantity = 1,
                    Price = 560,
                    ProductImgUrl = "https://www.tportal.hr/media/thumbnail/w1000/182058.jpeg"
                },

                new Product
                {
                    Id = 4,
                    Title = "Izlet",
                    Description = "Jezero i planine",
                    ProductCategoryId = 4,
                    Quantity = 10,
                    Price = 380,
                    ProductImgUrl = "https://magic-croatia.hr/wp-content/uploads/2021/05/boat-tour-zadar-telascica-nature-park-870x555.jpg"
                },

                new Product
                {
                    Id = 5,
                    Title = "Vinčeko",
                    Description = "črnega vunčeka",
                    ProductCategoryId = 1,
                    Quantity = 250,
                    Price = 5,
                    ProductImgUrl = "https://upload.wikimedia.org/wikipedia/hr/thumb/5/54/Vino.jpg/800px-Vino.jpg"
                },

                new Product
                {
                    Id = 6,
                    Title = "BMW",
                    Description = "Jurilica",
                    ProductCategoryId = 2,
                    Quantity = 1,
                    Price = 9999,
                    ProductImgUrl = "https://static.jutarnji.hr/images/slike/2022/01/08/23256043.jpg"
                },

                new Product
                {
                    Id = 7,
                    Title = "Vikendica",
                    Description = "Gorski kotar",
                    ProductCategoryId = 3,
                    Quantity = 1,
                    Price = 5000,
                    ProductImgUrl = "https://zivotnimagazin.com/wp-content/uploads/2018/03/vikendica-iz-bajke-2.jpg"
                },

                new Product
                {
                    Id = 8,
                    Title = "Party",
                    Description = "Scooter rave again",
                    ProductCategoryId = 4,
                    Quantity = 100,
                    Price = 75,
                    ProductImgUrl = "https://i.ytimg.com/vi/jL083wMBMlM/maxresdefault.jpg"
                },

                new Product
                {
                    Id = 9,
                    Title = "Lapatop",
                    Description = "Črni lapatop",
                    ProductCategoryId = 1,
                    Quantity = 20,
                    Price = 15,
                    ProductImgUrl = "https://www.tportal.hr/media/thumbnail/w1000/1452357.jpeg"
                },

                new Product
                {
                    Id = 10,
                    Title = "Krekeri",
                    Description = "Krekeri uz čaj",
                    ProductCategoryId = 2,
                    Quantity = 25,
                    Price = 2,
                    ProductImgUrl = "https://gospodarski.hr/wp-content/uploads/2019/04/Krekeri.jpg"
                },

                new Product
                {
                    Id = 11,
                    Title = "Nokia 3310",
                    Description = "Jedna i jedinstvena",
                    ProductCategoryId = 3,
                    Quantity = 50,
                    Price = 2500,
                    ProductImgUrl = "https://www.backmarket.it/cdn-cgi/image/format=auto,quality=75,width=260/https://d1eh9yux7w8iql.cloudfront.net/product_images/1465986103.52.jpg"
                },

                new Product
                {
                    Id = 12,
                    Title = "Kolica",
                    Description = "Smart kolica",
                    ProductCategoryId = 4,
                    Quantity = 1,
                    Price = 100,
                    ProductImgUrl = "https://www.wobyhaus.co.rs/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/70000301_1200_900px_w.jpg"
                },

                new Product
                {
                    Id = 13,
                    Title = "Balon",
                    Description = "Vožnja balonom iznad Moslavine",
                    ProductCategoryId = 1,
                    Quantity = 7,
                    Price = 85,
                    ProductImgUrl = "https://www.skole.hr/wp-content/uploads/2017/05/balloon-transport.jpg"
                },

                new Product
                {
                    Id = 14,
                    Title = "Grunt",
                    Description = "Grunt u zagorju",
                    ProductCategoryId = 2,
                    Quantity = 1,
                    Price = 78,
                    ProductImgUrl = "https://www.odvjetnik-strniscak.hr/wp-content/uploads/2020/11/Odvjetnik-za-zemlji%C5%A1te-2.jpg"
                },

                new Product
                {
                    Id = 15,
                    Title = "Mačak maslačak",
                    Description = "Ikona",
                    ProductCategoryId = 3,
                    Quantity = 1,
                    Price = 2,
                    ProductImgUrl = "https://www.purina.hr/sites/default/files/2017-11/the-big-outdoors.jpg"
                },

                new Product
                {
                    Id = 16,
                    Title = "Bademantil",
                    Description = "....",
                    ProductCategoryId = 4,
                    Quantity = 10,
                    Price = 15,
                    ProductImgUrl = "https://i.factcool.com/cache2/410x615/catalog/products/14/86/6b/14-86-6b3e9651h5pkf4v2khq16ivbgq4s.jpg"
                }
                );
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ProductViewModel>? ProductViewModel { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public DbSet<FileStorage> FileStorage { get; set; }
    }
}