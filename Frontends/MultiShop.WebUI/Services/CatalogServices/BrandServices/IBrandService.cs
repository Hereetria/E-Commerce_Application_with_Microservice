using MultiShop.DtoLayer.CatalogDtos.BrandDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.BrandServices
{
    public interface IBrandService : ICatalogGenericRepository<CreateBrandDto, UpdateBrandDto, ResultBrandDto>
    {
    }
}
