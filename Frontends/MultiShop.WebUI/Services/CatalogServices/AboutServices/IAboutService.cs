using MultiShop.DtoLayer.CatalogDtos.AboutDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.AboutServices
{
    public interface IAboutService : ICatalogGenericRepository<CreateAboutDto, UpdateAboutDto, ResultAboutDto>    
    {
    }
}
