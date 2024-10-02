using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService : IGenericRepository<CreateProductImageDto, UpdateProductImageDto, ResultProductImageDto, string>
    {
        Task<GetByIdProductImageDto> GetByProductIdProductImageAsync(string id);
    }
}
