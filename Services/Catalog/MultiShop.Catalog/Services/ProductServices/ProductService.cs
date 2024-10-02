using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Services.Repositories;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.ProductServices
{
    public class ProductService : GenericRepository<Product, CreateProductDto, UpdateProductDto, ResultProductDto, string>, IProductService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        public ProductService(IMapper mapper, IDatabaseSettings databaseSettings)
            : base(mapper, databaseSettings, databaseSettings.ProductCollectionName)
        {
            _categoryCollection = _collection.Database.GetCollection<Category>(databaseSettings.CategoryCollectionName);
        }

        public async Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryAsync()
        {
            var values = await _collection.Find(x => true).ToListAsync();
            foreach (var item in values) 
            {
                item.Category = await _categoryCollection.Find(x=>x.CategoryId == item.CategoryId).FirstOrDefaultAsync();
            }
            return _mapper.Map<List<ResultProductsWithCategoryDto>>(values);
        }

        public async Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryByCategoryIdAsync(string categoryId)
        {
            var values = await _collection.Find(x => x.CategoryId == categoryId).ToListAsync();
            foreach (var item in values)
            {
                item.Category = await _categoryCollection.Find(x => x.CategoryId == item.CategoryId).FirstOrDefaultAsync();
            }
            return _mapper.Map<List<ResultProductsWithCategoryDto>>(values);
        }
    }

}
