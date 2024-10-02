using AutoMapper;
using MultiShop.Catalog.Dtos.ContactDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Services.Repositories;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.ContactServices
{
    public class ContactService : GenericRepository<Contact, CreateContactDto, UpdateContactDto, ResultContactDto, string>, IContactService
    {
        public ContactService(IMapper mapper, IDatabaseSettings databaseSettings)
            : base(mapper, databaseSettings, databaseSettings.ContactCollectionName)
        {
        }
    }
}