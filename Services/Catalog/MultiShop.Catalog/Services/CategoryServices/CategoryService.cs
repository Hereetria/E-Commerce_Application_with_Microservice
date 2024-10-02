using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Services.Interfaces;
using MultiShop.Catalog.Services.ProductImageServices;
using MultiShop.Catalog.Services.Repositories;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.CategoryServices
{
    public class CategoryService : GenericRepository<Category, CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, string>, ICategoryService
    {
        public CategoryService(IMapper mapper, IDatabaseSettings databaseSettings)
            : base(mapper, databaseSettings, databaseSettings.CategoryCollectionName)
        {
        }
    }
}
