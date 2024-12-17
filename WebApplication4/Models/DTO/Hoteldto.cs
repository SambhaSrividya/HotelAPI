using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models.DTO
{
    public class Hoteldto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
        public int rooms { get; set; }
        public string password { get; set; }
    }
}
