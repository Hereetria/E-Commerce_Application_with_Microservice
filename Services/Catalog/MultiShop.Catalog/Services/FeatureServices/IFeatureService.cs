using MultiShop.Catalog.Dtos.FeatureDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.FeaturesService
{
    public interface IFeatureService : IGenericRepository<CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, string>
    {
    }
}
