using PropertyManager.API.Data;
using AutoMapper;
using PropertyManager.API.Entities;
using Microsoft.EntityFrameworkCore;
using PropertyManager.API.Models;
using System.Linq.Expressions;
using System.Linq;

namespace PropertyManager.API.Repository
{
	public class PropertyRepository : IRepository
	{
		private readonly PropertyContext _context;
		private readonly IMapper _mapper;

		public PropertyRepository(PropertyContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public void CreateProperty(Property property)
		{

			_context.Properties.Add(property);
			Save();
		}

		public void DeleteProperty(Property property)
		{

			_context.Properties.Remove(property);
			Save();
		}

		public IEnumerable<Property> GetAllProperties(Expression<Func<Property>> filter = null)
		{
			IQueryable<Property> query = _context.Properties;
			
			if(filter != null)
			{
				//query = query.Where(filter);
			}
			return query.ToList();
		}

		//public Property GetProperty(Expression<Func<Property>>? filter = null, bool tracked = false)
		//{
		//	if (filter == null)
		//	{
		//		return _context.Properties.FirstOrDefault();
		//	}
		//	else
		//	{
		//		if (tracked)
		//		{
		//			//return _context.Properties.FirstOrDefault(filter as Expression<Func<Property, bool>>);
		//		}
		//		else
		//		{
		//			//return _context.Properties.AsNoTracking().FirstOrDefault(filter as Expression<Func<Property, bool>>);
		//		}
		//	}
		//}

		public Property GetPropertyById(int id)
		{
			return _context.Properties.FirstOrDefault(p => p.Id == id);
		}

		public void Save()
		{
			_context.SaveChanges();
		}

		public void UpdateProperty(Property property)
		{
			_context.Properties.Update(property);
			Save();
		}
	}
}
