using AutoMapper;
using MultiShop.Catalog.Dtos.SpecialOfferDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Services.Repositories;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.SpecialOfferServices
{
    public class SpecialOfferService : GenericRepository<SpecialOffer, CreateSpecialOfferDto, UpdateSpecialOfferDto, ResultSpecialOfferDto, string>, ISpecialOfferService
    {
        public SpecialOfferService(IMapper mapper, IDatabaseSettings databaseSettings)
            : base(mapper, databaseSettings, databaseSettings.SpecialOfferCollectionName)
        {
        }
    }
}