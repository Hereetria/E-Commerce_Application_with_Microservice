using AutoMapper;
using MultiShop.Catalog.Dtos.FeatureDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Services.Repositories;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.FeaturesService
{
    public class FeatureService : GenericRepository<Feature, CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, string>, IFeatureService
    {
        public FeatureService(IMapper mapper, IDatabaseSettings databaseSettings)
            : base(mapper, databaseSettings, databaseSettings.FeatureCollectionName)
        {
        }
    }
}