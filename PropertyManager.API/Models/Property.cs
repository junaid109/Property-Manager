namespace PropertyManager.API.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? ImageThumbnail { get; set; }
        public bool IsRental { get; set; }
        public bool IsSold { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsAvailable { get; set; }
        public decimal Price { get; set; }
        public decimal? RentalPrice { get; set; }
        public decimal? SquareFeet { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? YearBuilt { get; set; }
        public int? YearRenovated { get; set; }
        public int? GarageSize { get; set; }
        public int? LotSize { get; set; }
        public int? Stories { get; set; }
        public int? ParkingSpaces { get; set; }
        public int? PoolSize { get; set; }
        public int? PropertyTypeId { get; set; }
        public PropertyType? PropertyType { get; set; }
        public int? PropertyStatusId { get; set; }
        public PropertyStatus? PropertyStatus { get; set; }
        public int? PropertyStyleId { get; set; }
        public PropertyStyle? PropertyStyle { get; set; }
        public int? PropertyConditionId { get; set; }
        public PropertyCondition? PropertyCondition { get; set; }
        public int? PropertyHeatingId { get; set; }
        public PropertyHeating? PropertyHeating { get; set; }
        public int? PropertyCoolingId { get; set; }
        public PropertyCooling? PropertyCooling { get; set; }
        public int? PropertyRoofId { get; set; }
    }
}
