using AutoMapper;
using MultiShop.Catalog.Context;
using MultiShop.Catalog.Dtos.AboutDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Services.Repositories;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.AboutServices
{
    public class AboutService : GenericRepository<About, CreateAboutDto, UpdateAboutDto, ResultAboutDto, string>, IAboutService
    {
        public AboutService(IMapper mapper, MongoDbContext context)
            : base(mapper, context, "About")
        {
        }
    }
}