using MultiShop.DtoLayer.CatalogDtos.ContactDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.ContactServices
{
    public class ContactService : CatalogGenericRepository<CreateContactDto, UpdateContactDto, ResultContactDto>, IContactService
    {
        public ContactService(HttpClient httpClient)
            : base(httpClient, "contacts")
        {
        }
    }
}
