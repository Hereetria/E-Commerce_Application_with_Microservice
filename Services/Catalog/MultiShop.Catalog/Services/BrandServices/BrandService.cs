using AutoMapper;
using MultiShop.Catalog.Dtos.BrandDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Services.BrandServices;
using MultiShop.Catalog.Services.Repositories;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.BrandServices
{
    public class BrandService : GenericRepository<Brand, CreateBrandDto, UpdateBrandDto, ResultBrandDto, string>, IBrandService
    {
        public BrandService(IMapper mapper, IDatabaseSettings databaseSettings)
            : base(mapper, databaseSettings, databaseSettings.BrandCollectionName)
        {
        }
    }
}