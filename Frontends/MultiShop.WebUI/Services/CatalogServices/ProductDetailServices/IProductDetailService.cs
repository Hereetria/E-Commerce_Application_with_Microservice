using MultiShop.DtoLayer.CatalogDtos.ProductDetailDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.ProductDetailServices
{
    public interface IProductDetailService : ICatalogGenericRepository<CreateProductDetailDto, UpdateProductDetailDto, ResultProductDetailDto>
    {
        Task<GetByIdProductDetailDto> GetByProductIdProductDetailAsync(string id);
    }
}
