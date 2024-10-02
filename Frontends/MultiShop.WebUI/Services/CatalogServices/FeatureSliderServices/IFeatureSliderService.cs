using MultiShop.DtoLayer.CatalogDtos.FeatureSliderDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.FeatureSliderServices
{
    public interface IFeatureSliderService : ICatalogGenericRepository<CreateFeatureSliderDto, UpdateFeatureSliderDto, ResultFeatureSliderDto>
    {
        Task FeatureSliderChageStatusToTrue(string id);
        Task FeatureSliderChageStatusToFalse(string id);
    }
}
