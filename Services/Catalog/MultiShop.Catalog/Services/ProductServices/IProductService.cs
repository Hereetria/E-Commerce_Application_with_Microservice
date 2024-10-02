using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService : IGenericRepository<CreateProductDto, UpdateProductDto, ResultProductDto, string>
    {
        Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryAsync();
        Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryByCategoryIdAsync(string categoryId);
    }
}
