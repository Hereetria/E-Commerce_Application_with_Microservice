using MultiShop.Catalog.Dtos.ContactDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.ContactServices
{
    public interface IContactService : IGenericRepository<CreateContactDto, UpdateContactDto, ResultContactDto, string>
    {
    }
}
