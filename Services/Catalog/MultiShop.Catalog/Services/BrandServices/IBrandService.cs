using MultiShop.Catalog.Dtos.BrandDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.BrandServices
{
    public interface IBrandService : IGenericRepository<CreateBrandDto, UpdateBrandDto, ResultBrandDto, string>
    {
    }
}
