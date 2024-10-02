using MultiShop.Catalog.Dtos.OfferDiscountDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.OfferDiscountServices
{
    public interface IOfferDiscountService : IGenericRepository<CreateOfferDiscountDto, UpdateOfferDiscountDto, ResultOfferDiscountDto, string>
    {
    }
}
