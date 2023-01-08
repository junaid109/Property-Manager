using Microsoft.AspNetCore.Mvc;
using PropertyManager.API.Data;
using PropertyManager.API.Entities;
using PropertyManager.API.Models;

namespace PropertyManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAPIController: ControllerBase
    {
        private readonly PropertyContext _context;

        public PropertyAPIController(PropertyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProperties()
        {
            return Ok(_context.Properties);
        }

        [HttpGet("{id}")]
        public IActionResult GetProperty(int id)
        {
            var property = _context.Properties.FirstOrDefault(p => p.Id == id);

            if (property == null)
            {
                return NotFound();
            }

            return Ok(property);
        }

        [HttpPost]
        public IActionResult CreateProperty([FromBody] PropertyDTO property)
        {
            if (property == null)
            {
                return BadRequest();
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
        public IActionResult UpdateProperty(Guid id, [FromBody] PropertyDTO property)
        {
            if (property == null)
            {
                return BadRequest();
            }

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

        [HttpDelete("{id}")]
        public IActionResult DeleteProperty(Guid id)
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

        

        

    }
}
