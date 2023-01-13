namespace PropertyManager.API.Entities
{
	public class PropertyCreateDTO
	{
		public string Name { get; set; }

		public string Address { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string Zip { get; set; }

		public string Country { get; set; }

		public string Description { get; set; }

		public string Image { get; set; }

		public string ImageThumbnail { get; set; }

		public bool IsRental { get; set; }
	}
}
