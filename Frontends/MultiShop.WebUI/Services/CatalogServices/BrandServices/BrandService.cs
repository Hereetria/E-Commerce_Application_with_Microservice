using MultiShop.DtoLayer.CatalogDtos.BrandDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.BrandServices
{
    public class BrandService : CatalogGenericRepository<CreateBrandDto, UpdateBrandDto, ResultBrandDto>, IBrandService
    {
        public BrandService(HttpClient httpClient)
            : base(httpClient, "brands")
        {
        }
    }
}
