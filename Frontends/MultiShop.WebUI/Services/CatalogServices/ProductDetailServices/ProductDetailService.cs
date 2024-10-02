using MultiShop.DtoLayer.CatalogDtos.ProductDetailDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;
using System.Net.Http;

namespace MultiShop.WebUI.Services.CatalogServices.ProductDetailServices
{
    public class ProductDetailService : CatalogGenericRepository<CreateProductDetailDto, UpdateProductDetailDto, ResultProductDetailDto>, IProductDetailService
    {
        public ProductDetailService(HttpClient httpClient)
            : base(httpClient, "productdetails")
        {
        }

        public async Task<GetByIdProductDetailDto> GetByProductIdProductDetailAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("productdetails/GetProductDetailByProductId/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<GetByIdProductDetailDto>();
            return values;
        }
    }
}
