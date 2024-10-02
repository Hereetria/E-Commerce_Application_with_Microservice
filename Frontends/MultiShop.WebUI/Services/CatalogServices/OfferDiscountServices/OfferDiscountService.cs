using MultiShop.DtoLayer.CatalogDtos.OfferDiscountDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.OfferDiscountServices
{
    public class OfferDiscountService : CatalogGenericRepository<CreateOfferDiscountDto, UpdateOfferDiscountDto, ResultOfferDiscountDto>, IOfferDiscountService
    {
        public OfferDiscountService(HttpClient httpClient)
            : base(httpClient, "offerdiscounts")
        {
        }
    }
}
