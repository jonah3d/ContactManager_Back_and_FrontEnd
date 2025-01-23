using AutoMapper;
using ContactManagerApi.DTO;
using ContactManagerApi.Models;

namespace ContactManagerApi.Mappings
{
    public class AutoMapperProfiles : Profile
    {
       public AutoMapperProfiles() { 
        
            CreateMap<Contact,ContactDTO>().ReverseMap();
            CreateMap<Contact, AddContactDTO>().ReverseMap();
            CreateMap<Contact, UpdateContactDTO>().ReverseMap();

        }
    }
}
