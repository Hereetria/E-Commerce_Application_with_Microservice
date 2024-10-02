using MultiShop.DtoLayer.CatalogDtos.OfferDiscountDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.OfferDiscountServices
{
    public interface IOfferDiscountService : ICatalogGenericRepository<CreateOfferDiscountDto, UpdateOfferDiscountDto, ResultOfferDiscountDto>
    {
    }
}
