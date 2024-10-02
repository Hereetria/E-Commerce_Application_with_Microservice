using MultiShop.DtoLayer.CatalogDtos.FeatureDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.FeatureServices
{
    public interface IFeatureService : ICatalogGenericRepository<CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto>
    {
    }
}
