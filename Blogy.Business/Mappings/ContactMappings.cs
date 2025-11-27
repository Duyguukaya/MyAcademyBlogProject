using AutoMapper;
using Blogy.Business.DTOs.ContactDtos;
using Blogy.Entity.Entities;

namespace Blogy.Business.Mappings
{
    public class ContactMappings:Profile
    {
        public ContactMappings()
        {
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
        }
    }
}
