using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService : IGenericRepository<CreateProductDetailDto, UpdateProductDetailDto, ResultProductDetailDto, string>
    {
        Task<GetByIdProductDetailDto> GetByProductIdProductDetailAsync(string id);
    }
}
