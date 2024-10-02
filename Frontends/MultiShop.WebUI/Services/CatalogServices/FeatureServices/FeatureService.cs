using MultiShop.DtoLayer.CatalogDtos.FeatureDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.FeatureServices
{
    public class FeatureService : CatalogGenericRepository<CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto>, IFeatureService
    {
        public FeatureService(HttpClient httpClient)
            : base(httpClient, "features")
        {
        }
    }
}
