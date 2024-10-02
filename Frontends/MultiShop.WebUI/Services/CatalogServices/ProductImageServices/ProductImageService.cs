using MultiShop.DtoLayer.CatalogDtos.ProductImageDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.ProductImageServices
{
    public class ProductImageService : CatalogGenericRepository<CreateProductImageDto, UpdateProductImageDto, ResultProductImageDto>, IProductImageService
    {
        public ProductImageService(HttpClient httpClient)
            : base(httpClient, "productimages")
        {
        }

        public async Task<GetByIdProductImageDto> GetByProductIdProductImageAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("productimages/ProductImagesByProductId/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<GetByIdProductImageDto>();
            return values;
        }
    }
}
