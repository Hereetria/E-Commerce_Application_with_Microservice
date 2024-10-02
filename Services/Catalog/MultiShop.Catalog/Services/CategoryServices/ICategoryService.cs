using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.CategoryServices
{
    public interface ICategoryService : IGenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, string>
    {
    }

}
