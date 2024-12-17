using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Data;
using WebApplication4.Models;
using WebApplication4.Models.DTO;

namespace WebApplication4.Controllers
{
    //[Route("API/ [Controller]")]
    [Route("API/ HotelsApi")]
    [ApiController]
    public class HotelsApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public HotelsApiController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Hoteldto>> GetHotels()
        {
            return Ok(_db.Hotels.ToList());
        }
        [HttpGet("Id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200,Type=typeof(Hoteldto))]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(404)]
        public ActionResult<Hoteldto> GetHotel(int id)
        {
            if (id == 0)
            {
                
                return BadRequest();
            }
            var Hotel = _db.Hotels.FirstOrDefault(U => U.Id == id);
            if (Hotel == null)
            {
                return NotFound();
            }
            return Ok(Hotel);
        }
        [HttpPost]
        public ActionResult<Hoteldto> CreateHotel([FromBody] Hoteldto hotel)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            if (_db.Hotels.FirstOrDefault(U => U.Name.ToLower() == hotel.Name.ToLower()) != null)
            {
                ModelState.AddModelError(" ", "Hotel already exists!");
                return BadRequest(ModelState);
            }
            if (hotel == null)
            {
                return BadRequest(hotel);
            }
            if (hotel.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Hotel model = new()
            {
                Amenity = hotel.Amenity,
                Details = hotel.Details,
                Id = hotel.Id,
                ImageUrl = hotel.ImageUrl,
                Name = hotel.Name,
                Rate = hotel.Rate,
                rooms = hotel.rooms,
                password = hotel.password
            };
            _db.Hotels.Add(model);
            _db.SaveChanges();
            return CreatedAtRoute("GetHotel", new { id = hotel.Id },hotel);
        }
        [HttpDelete("id")]
        public IActionResult DeleteHotel(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var Hotel = _db.Hotels.FirstOrDefault(U => U.Id == id);
            if (Hotel == null)
            {
                return NotFound();
            }
            _db.Hotels.Remove(Hotel);
            _db.SaveChanges();
            return NoContent();
        }
        [HttpPut("id")]
        public IActionResult UpdateHotel(int id, [FromBody] Hoteldto hoteldto)
        {
            if (hoteldto == null || id != hoteldto.Id)
            {
                return BadRequest();
            }
            //var Hotel = HotelStore.hotellist.FirstOrDefault(U => U.Id == id);
            //Hotel.Name = hoteldto.Name;
            //Hotel.rooms = hoteldto.rooms;
            //Hotel.password = hoteldto.password;
            Hotel model = new()
            {
                Amenity = hoteldto.Amenity,
                Details = hoteldto.Details,
                Id = hoteldto.Id,
                ImageUrl = hoteldto.ImageUrl,
                Name = hoteldto.Name,
                Rate = hoteldto.Rate,
                rooms = hoteldto.rooms,
                password = hoteldto.password
            };
            _db.Hotels.Update(model);
            _db.SaveChanges();
            return NoContent();
        }
        [HttpPatch("{id:int}", Name = "UpdatePartialHotel")]
        public IActionResult UpdatePartialHotel(int id, JsonPatchDocument<Hotel> document)
        {
            if (document == null || id == 0)
            {
                return BadRequest();
            }
            var Hotel = _db.Hotels.FirstOrDefault(U => U.Id == id);
            Hoteldto hoteldt = new()
            {
                Amenity = Hotel.Amenity,
                Details = Hotel.Details,
                Id = Hotel.Id,
                ImageUrl = Hotel.ImageUrl,
                Name = Hotel.Name,
                Rate = Hotel.Rate,
                rooms = Hotel.rooms,
                password = Hotel.password
            };
            if (Hotel != null)
            {
                return BadRequest();
            }
            //document.ApplyTo(hoteldt, ModelState);
            Hotel model = new Hotel()
            {
                Amenity = hoteldt.Amenity,
                Details = hoteldt.Details,
                Id = hoteldt.Id,
                ImageUrl = hoteldt.ImageUrl,
                Name = hoteldt.Name,
                Rate = hoteldt.Rate,
                rooms = hoteldt.rooms,
                password = hoteldt.password
            };
            _db.Hotels.Update(model);
            _db.SaveChanges();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}
