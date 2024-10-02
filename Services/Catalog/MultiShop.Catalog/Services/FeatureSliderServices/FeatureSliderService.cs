using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.FeatureSliderDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Services.FeatureSliderServices;
using MultiShop.Catalog.Services.Interfaces;
using MultiShop.Catalog.Services.Repositories;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.FeatureSliderServices
{

    public class FeatureSliderService : GenericRepository<FeatureSlider, CreateFeatureSliderDto, UpdateFeatureSliderDto, ResultFeatureSliderDto, string>, IFeatureSliderService
    {
        public FeatureSliderService(IMapper mapper, IDatabaseSettings databaseSettings) 
            : base(mapper, databaseSettings, databaseSettings.FeatureSliderCollectionName)
        {
        }

        public Task FeatureSliderChangeStatusToFalse(string id)
        {
            throw new NotImplementedException();
        }

        public Task FeatureSliderChangeStatusToTrue(string id)
        {
            throw new NotImplementedException();
        }
    }
}
