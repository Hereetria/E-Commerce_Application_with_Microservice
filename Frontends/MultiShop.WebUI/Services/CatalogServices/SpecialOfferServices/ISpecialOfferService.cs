using MultiShop.DtoLayer.CatalogDtos.SpecialOfferDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.SpecialOfferServices
{
    public interface ISpecialOfferService : ICatalogGenericRepository<CreateSpecialOfferDto, UpdateSpecialOfferDto, ResultSpecialOfferDto>
    {
    }
}
