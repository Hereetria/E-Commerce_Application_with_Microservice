using MultiShop.DtoLayer.CatalogDtos.ContactDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.ContactServices
{
    public interface IContactService : ICatalogGenericRepository<CreateContactDto, UpdateContactDto, ResultContactDto>
    {
    }
}
