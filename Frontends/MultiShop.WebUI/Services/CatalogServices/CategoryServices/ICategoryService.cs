using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.CategoryServices
{
    public interface ICategoryService : ICatalogGenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto>
    {
    }
}
