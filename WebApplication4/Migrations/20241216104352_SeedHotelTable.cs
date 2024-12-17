using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class SeedHotelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "UpdatedDate", "password", "rooms" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals", "https://hotels.razola.xyz/i/g-b790c4f3d4e705af6e7d4b7801e217fe0a0ed75fd4451861442ded35692135af.jpeg?z=1589047845#s1500x1000", "diamond", 43245.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fhj123", 4 },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals", "https://q-xx.bstatic.com/xdata/images/hotel/max1200/138405161.jpg?k=e447b65d28d229f95cb41ee219d36d8588548fe8bbb7f6495af2441c086ecea6&o=", "GOLD", 33245.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JHG123", 4 },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals", "https://r1imghtlak.mmtcdn.com/971eaf269e7f11eb98f10242ac110002.jpg", "SILVER", 23245.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "POI123", 4 },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals", "https://tse2.mm.bing.net/th?id=OIP.HSxTr3mBPKE7vGRHlvZhCQHaE8&pid=Api&P=0&h=180", "CLASSIC", 13245.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDS123", 4 },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotels in Goa Book Now, Hotels in Goa! Don't Miss Today's Best Deals", "http://pix6.agoda.net/hotelImages/148/148753/148753_15091018110035867258.jpg?s=1100x825", "BASIC", 10000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SDR123", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
