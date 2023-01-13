using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PropertyManager.API.Data;
using PropertyManager.API.Entities;
using PropertyManager.API.Models;

namespace PropertyManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAPIController : ControllerBase
    {
        private readonly PropertyContext _context;
        private ILogger logger;
        private readonly IMapper _mapper;

        public PropertyAPIController(PropertyContext context, ILogger<PropertyAPIController> logger, IMapper mapper)
        {
            _context = context;
            this.logger = logger;
            this.mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetProperties()
        {
            IEnumerable<Property> properties = _context.Properties.ToList();
            return Ok(_mapper.Map<IEnumerable<PropertyDTO>>(properties));
        }


        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetProperty(int id)
        {
            var property = _context.Properties.FirstOrDefault(p => p.Id == id);

            if (property == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PropertyDTO>);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateProperty([FromBody] PropertyDTO property)
        {
            if (property == null)
            {
                return BadRequest();
            }

            //check if duplicate property name then prevent creation show error
            var existingProperty = _context.Properties.FirstOrDefault(p => p.Name == property.Name);

            if (existingProperty != null)
            {
                ModelState.AddModelError("Name", "Property name must be unique");
                return BadRequest(ModelState);
            }


            var newProperty = new Property
            {
                Id = property.Id,
                Name = property.Name,
                Address = property.Address,
                City = property.City,
                State = property.State,
                Zip = property.Zip,
                Country = property.Country,
                Description = property.Description,
                Image = property.Image,
                ImageThumbnail = property.ImageThumbnail,
                IsRental = property.IsRental
            };

            _context.Properties.Add(newProperty);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProperty), new { id = newProperty.Id }, newProperty);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult UpdateProperty(int id, [FromBody] PropertyDTO property)
        {
            if (ModelState.IsValid)
            {
                var propertyToUpdate = _context.Properties.FirstOrDefault(p => p.Id == id);

                if (propertyToUpdate == null)
                {
                    return NotFound();
                }

                propertyToUpdate.Name = property.Name;
                propertyToUpdate.Address = property.Address;
                propertyToUpdate.City = property.City;
                propertyToUpdate.State = property.State;
                propertyToUpdate.Zip = property.Zip;
                propertyToUpdate.Country = property.Country;
                propertyToUpdate.Description = property.Description;
                propertyToUpdate.Image = property.Image;
                propertyToUpdate.ImageThumbnail = property.ImageThumbnail;
                propertyToUpdate.IsRental = property.IsRental;

                _context.Properties.Update(propertyToUpdate);
                _context.SaveChanges();

                return NoContent();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteProperty(int id)
        {
            var propertyToDelete = _context.Properties.FirstOrDefault(p => p.Id == id);

            if (propertyToDelete == null)
            {
                return NotFound();
            }

            _context.Properties.Remove(propertyToDelete);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("search")]
        public IActionResult Search(string q)
        {
            var properties = _context.Properties.Where(p => p.Name.Contains(q) || p.Description.Contains(q));

            return Ok(properties);
        }

        [HttpGet("rental")]
        public IActionResult Rental()
        {
            var properties = _context.Properties.Where(p => p.IsRental);

            return Ok(properties);
        }

        [HttpGet("sale")]
        public IActionResult Sale()
        {
            var properties = _context.Properties.Where(p => !p.IsRental);

            return Ok(properties);
        }

        [HttpGet("city")]
        public IActionResult City(string city)
        {
            var properties = _context.Properties.Where(p => p.City == city);

            return Ok(properties);
        }

        [HttpGet("state")]
        public IActionResult State(string state)
        {
            var properties = _context.Properties.Where(p => p.State == state);

            return Ok(properties);
        }

        [HttpGet("country")]
        public IActionResult Country(string country)
        {
            var properties = _context.Properties.Where(p => p.Country == country);

            return Ok(properties);
        }

        [HttpGet("zip")]
        public IActionResult Zip(string zip)
        {
            var properties = _context.Properties.Where(p => p.Zip == zip);

            return Ok(properties);
        }

        [HttpGet("rental/search")]
        public IActionResult RentalSearch(string q)
        {
            var properties = _context.Properties.Where(p => p.IsRental && (p.Name.Contains(q) || p.Description.Contains(q)));

            return Ok(properties);
        }

        [HttpGet("sale/search")]
        public IActionResult SaleSearch(string q)
        {
            var properties = _context.Properties.Where(p => !p.IsRental && (p.Name.Contains(q) || p.Description.Contains(q)));

            return Ok(properties);
        }

        [HttpGet("rental/city")]
        public IActionResult RentalCity(string city)
        {
            var properties = _context.Properties.Where(p => p.IsRental && p.City == city);

            return Ok(properties);
        }
    }
}