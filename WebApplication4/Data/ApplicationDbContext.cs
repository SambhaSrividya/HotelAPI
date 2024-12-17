using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.ConfigureWarnings(warnings =>
        //        warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 1,
                    Name = "diamond",
                    Details = "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals",
                    Rate = 43245,
                    rooms = 4,
                    password = "fhj123",
                    ImageUrl = "https://hotels.razola.xyz/i/g-b790c4f3d4e705af6e7d4b7801e217fe0a0ed75fd4451861442ded35692135af.jpeg?z=1589047845#s1500x1000",
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Hotel()
                {
                    Id = 2,
                    Name = "GOLD",
                    Details = "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals",
                    Rate = 33245,
                    rooms = 4,
                    password = "JHG123",
                    ImageUrl = "https://q-xx.bstatic.com/xdata/images/hotel/max1200/138405161.jpg?k=e447b65d28d229f95cb41ee219d36d8588548fe8bbb7f6495af2441c086ecea6&o=",
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Hotel()
                {
                    Id = 3,
                    Name = "SILVER",
                    Details = "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals",
                    Rate = 23245,
                    rooms = 4,
                    password = "POI123",
                    ImageUrl = "https://r1imghtlak.mmtcdn.com/971eaf269e7f11eb98f10242ac110002.jpg",
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Hotel()
                {
                    Id = 4,
                    Name = "CLASSIC",
                    Details = "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals",
                    Rate = 13245,
                    rooms = 4,
                    password = "FDS123",
                    ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.HSxTr3mBPKE7vGRHlvZhCQHaE8&pid=Api&P=0&h=180",
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                 new Hotel()
                 {
                     Id = 5,
                     Name = "BASIC",
                     Details = "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals",
                     Rate = 10000,
                     rooms = 4,
                     password = "SDR123",
                     ImageUrl = "http://pix6.agoda.net/hotelImages/148/148753/148753_15091018110035867258.jpg?s=1100x825",
                     Amenity = "",
                     CreatedDate = DateTime.Now,
                     UpdatedDate = DateTime.Now
                 }
            );
        }
    }
}
