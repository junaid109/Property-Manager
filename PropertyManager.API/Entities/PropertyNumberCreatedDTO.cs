using System.ComponentModel.DataAnnotations;

namespace PropertyManager.API.Entities
{
    public class PropertyNumberCreatedDTO
	{
		[Required]
		public int PropertyNum { get; set; }
		public string Details { get; set; }
	}
}
