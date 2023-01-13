using AutoMapper;
using PropertyManager.API.Entities;
using PropertyManager.API.Models;

namespace PropertyManager.API
{
	public class MappingConfig: Profile
	{
		public MappingConfig()
		{
			CreateMap<Property, PropertyDTO>();
			CreateMap<PropertyDTO, Property>();

			CreateMap<Property, PropertyUpdateDTO>().ReverseMap();
			CreateMap<PropertyUpdateDTO, Property>();
			CreateMap<Property, PropertyCreateDTO>().ReverseMap();
			CreateMap<PropertyCreateDTO, Property>();
		}
		
	}
}
