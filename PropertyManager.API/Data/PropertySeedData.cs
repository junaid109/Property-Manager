using PropertyManager.API.Models;

namespace PropertyManager.API.Data
{
    public static class PropertySeedData
    {
        public static void Seed(PropertyContext context)
        {
			if (!context.Properties.Any())
			{
                context.Properties.AddRange(
					new Property { Name = "Property 1", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 1 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true },
					new Property { Name = "Property 2", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 2 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true },
					new Property { Name = "Property 3", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 3 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true },
					new Property { Name = "Property 4", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 4 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true },
					new Property { Name = "Property 5", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 5 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true },
					new Property { Name = "Property 6", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 6 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true },
					new Property { Name = "Property 7", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 7 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true },
					new Property { Name = "Property 8", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 8 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true },
					new Property { Name = "Property 9", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 9 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true },
					new Property { Name = "Property 10", Address = "123 Main St", City = "Seattle", State = "WA", Zip = "98101", Country = "USA", Description = "Property 10 Description", Image = "https://via.placeholder.com/150", ImageThumbnail = "https://via.placeholder.com/150", IsRental = true }
					);
				context.SaveChanges();
			}

				if (!context.PropertyTypes.Any())
            {
                context.PropertyTypes.AddRange(
                    new PropertyType { Name = "Single Family" },
                    new PropertyType { Name = "Condo" },
                    new PropertyType { Name = "Townhouse" },
                    new PropertyType { Name = "Multi Family" },
                    new PropertyType { Name = "Mobile Home" },
                    new PropertyType { Name = "Land" },
                    new PropertyType { Name = "Commercial" },
                    new PropertyType { Name = "Farm" },
                    new PropertyType { Name = "Other" }
                );

                context.SaveChanges();

            }

            if (!context.PropertyStatuses.Any())
            {
                context.PropertyStatuses.AddRange(
                    new PropertyStatus { Name = "Active" },
                    new PropertyStatus { Name = "Pending" },
                    new PropertyStatus { Name = "Sold" },
                    new PropertyStatus { Name = "Rented" },
                    new PropertyStatus { Name = "Leased" },
                    new PropertyStatus { Name = "Withdrawn" },
                    new PropertyStatus { Name = "Expired" },
                    new PropertyStatus { Name = "Canceled" },
                    new PropertyStatus { Name = "Off Market" },
                    new PropertyStatus { Name = "Other" }
                );

                context.SaveChanges();
            }

            if (!context.PropertyStyles.Any())
            {
                context.PropertyStyles.AddRange(
                    new PropertyStyle { Name = "Ranch" },
                    new PropertyStyle { Name = "Two Story" },
                    new PropertyStyle { Name = "Tri-Level" },
                    new PropertyStyle { Name = "Split Level" },
                    new PropertyStyle { Name = "Bi-Level" },
                    new PropertyStyle { Name = "Patio Home" },
                    new PropertyStyle { Name = "Other" }
                );

                context.SaveChanges();
            }

            if (!context.PropertyConditions.Any())
            {
                context.PropertyConditions.AddRange(
                    new PropertyCondition { Name = "New Construction" },
                    new PropertyCondition { Name = "Excellent" },
                    new PropertyCondition { Name = "Good" },
                    new PropertyCondition { Name = "Fair" },
                    new PropertyCondition { Name = "Poor" },
                    new PropertyCondition { Name = "Needs Work" },
                    new PropertyCondition { Name = "Fixer Upper" },
                    new PropertyCondition { Name = "Other" }
                );

                context.SaveChanges();
            }

            if (!context.PropertyHeatings.Any())
            {
                context.PropertyHeatings.AddRange(
                    new PropertyHeating
                    {
                        Name = "Forced Air",
                        Description = "Forced air heating is a central heating system in which the inside air is heated by a furnace or heat pump and then distributed throughout the home by a system of ducts."
                    },
                    new PropertyHeating
                    {
                        Name = "Radiant",
                        Description = "Radiant heating is a system in which heat is generated by electric, gas, or oil-fired elements and then transferred to the air or water in a room by convection or radiation."
                    },
                    new PropertyHeating
                    {
                        Name = "Heat Pump",
                        Description = "A heat pump is a device that transfers heat energy from a source of heat to what is called a heat sink. Heat pumps move thermal energy in the opposite direction of spontaneous heat transfer, by absorbing heat from a cold space and releasing it to a warmer one."
                    },
                    new PropertyHeating
                    {
                        Name = "Solar",
                        Description = "Solar heating is the conversion of sunlight into heat, either directly using photovoltaic panels, or indirectly using concentrated solar power."
                    },

                    new PropertyHeating
                    {
                        Name = "Other",
                        Description = "Other"
                    }
                    );

                context.SaveChanges();

                
            }
            
            
        }

        
    }
}
