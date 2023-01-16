using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManager.API.Models
{
	public class PropertyNumber
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int PropertyNum { get; set; }
		public string Details { get; set; }

		public DateTime CreatedDate { get; set; }

		public DateTime UpdatedDate { get; set; }

	}
}
