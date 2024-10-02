using MultiShop.Catalog.Dtos.SpecialOfferDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.SpecialOfferServices
{
    public interface ISpecialOfferService : IGenericRepository<CreateSpecialOfferDto, UpdateSpecialOfferDto, ResultSpecialOfferDto, string>
    {
    }
}

