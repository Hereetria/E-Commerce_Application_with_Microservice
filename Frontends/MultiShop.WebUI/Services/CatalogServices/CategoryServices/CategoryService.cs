using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;
using MultiShop.WebUI.Services.CatalogServices.Repositories;

namespace MultiShop.WebUI.Services.CatalogServices.CategoryServices
{
    public class CategoryService : CatalogGenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto>, ICategoryService
    {
        public CategoryService(HttpClient httpClient)
            : base(httpClient, "categories")
        {
        }
    }
}
