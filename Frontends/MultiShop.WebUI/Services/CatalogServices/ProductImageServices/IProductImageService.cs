using MultiShop.DtoLayer.CatalogDtos.ProductImageDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.ProductImageServices
{
    public interface IProductImageService : ICatalogGenericRepository<CreateProductImageDto, UpdateProductImageDto, ResultProductImageDto>
    {
        Task<GetByIdProductImageDto> GetByProductIdProductImageAsync(string id);
    }
}
