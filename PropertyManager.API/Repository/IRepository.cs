using PropertyManager.API.Models;
using System.Linq.Expressions;

namespace PropertyManager.API.Repository
{
	public interface IRepository
	{
		// Get all properties
		IEnumerable<Property> GetAllProperties(Expression<Func<Property>> filter = null);
		Property GetPropertyAsyn(Expression<Func<Property>> filter = null, bool tracked = false);

		// Get property by id
		Property GetPropertyById(int id);
		// Create property
		void CreateProperty(Property property);
		// Update property
		void UpdateProperty(Property property);
		// Delete property
		void DeleteProperty(Property property);
		// Save changes
		void Save();
	}
}
