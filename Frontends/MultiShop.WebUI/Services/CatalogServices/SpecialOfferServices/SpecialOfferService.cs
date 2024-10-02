using MultiShop.DtoLayer.CatalogDtos.SpecialOfferDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.SpecialOfferServices
{
    public class SpecialOfferService : CatalogGenericRepository<CreateSpecialOfferDto, UpdateSpecialOfferDto, ResultSpecialOfferDto>, ISpecialOfferService
    {
        public SpecialOfferService(HttpClient httpClient)
            : base(httpClient, "specialoffers")
        {
        }
    }
}
