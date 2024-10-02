using MultiShop.DtoLayer.CatalogDtos.FeatureSliderDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.FeatureSliderServices
{
    public class FeatureSliderService : CatalogGenericRepository<CreateFeatureSliderDto, UpdateFeatureSliderDto, ResultFeatureSliderDto>, IFeatureSliderService
    {
        public FeatureSliderService(HttpClient httpClient)
            : base(httpClient, "featuresliders")
        {
        }

        public Task FeatureSliderChageStatusToFalse(string id)
        {
            throw new NotImplementedException();
        }

        public Task FeatureSliderChageStatusToTrue(string id)
        {
            throw new NotImplementedException();
        }
    }
}
