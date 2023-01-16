using System.ComponentModel.DataAnnotations;

namespace PropertyManager.API.Entities
{
    public class PropertyNumberDTO
	{
		[Required]
		public int PropertyNum { get; set; }
		public string Details { get; set; }
	}
}
