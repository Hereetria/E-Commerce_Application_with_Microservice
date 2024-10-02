using MultiShop.Catalog.Dtos.AboutDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.AboutServices
{
    public interface IAboutService : IGenericRepository<CreateAboutDto, UpdateAboutDto, ResultAboutDto, string>
    {
    }
}
