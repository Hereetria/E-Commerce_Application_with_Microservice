using MultiShop.DtoLayer.CatalogDtos.AboutDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.AboutServices
{
    public class AboutService : CatalogGenericRepository<CreateAboutDto, UpdateAboutDto, ResultAboutDto>, IAboutService
    {
        public AboutService(HttpClient httpClient) 
            : base(httpClient, "abouts")
        {
        }
    }
}
