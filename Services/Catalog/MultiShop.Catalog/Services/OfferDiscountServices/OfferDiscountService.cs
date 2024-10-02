using AutoMapper;
using MultiShop.Catalog.Dtos.OfferDiscountDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Services.Repositories;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.OfferDiscountServices
{
    public class OfferDiscountService : GenericRepository<OfferDiscount, CreateOfferDiscountDto, UpdateOfferDiscountDto, ResultOfferDiscountDto, string>, IOfferDiscountService
    {
        public OfferDiscountService(IMapper mapper, IDatabaseSettings databaseSettings)
            : base(mapper, databaseSettings, databaseSettings.OfferDiscountCollectionName)
        {
        }
    }
}
