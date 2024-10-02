using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Services.Interfaces;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.Repositories
{
    public abstract class GenericRepository<TEntity, TCreateDto, TUpdateDto, TResultDto, TKey> : IGenericRepository<TCreateDto, TUpdateDto, TResultDto, TKey>
    where TEntity : class
    where TCreateDto : class
    where TUpdateDto : class
    where TResultDto : class
    {

        protected readonly IMongoCollection<TEntity> _collection;
        protected readonly IMapper _mapper;
        protected string idFieldName;

        protected GenericRepository(IMapper mapper, IDatabaseSettings databaseSettings, string collectionName)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _collection = database.GetCollection<TEntity>(collectionName);
            _mapper = mapper;
            idFieldName = getIdFieldName();
        }

        protected virtual string getIdFieldName()
        {
            return EntityBase<TEntity>.GetIdFieldName();
        }

        public async Task CreateAsync(TCreateDto createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);
            await _collection.InsertOneAsync(entity);
        }

        public async Task DeleteAsync(TKey id)
        {
            var filter = Builders<TEntity>.Filter.Eq(idFieldName, id);
            await _collection.DeleteOneAsync(filter);
        }

        public async Task<List<TResultDto>> GetAllAsync()
        {
            var values = await _collection.Find(x => true).ToListAsync();
            return _mapper.Map<List<TResultDto>>(values);
        }

        public async Task<TResultDto> GetByIdAsync(TKey id)
        {
            var filter = Builders<TEntity>.Filter.Eq(idFieldName, id);
            var values = await _collection.Find(filter).FirstOrDefaultAsync();
            return _mapper.Map<TResultDto>(values);

        }

        public async Task UpdateAsync(TUpdateDto updateDto)
        {
            var entity = _mapper.Map<TEntity>(updateDto);
            var idValue = updateDto.GetType().GetProperty(idFieldName)?.GetValue(updateDto, null);
            var filter = Builders<TEntity>.Filter.Eq(idFieldName, idValue);
            await _collection.FindOneAndReplaceAsync(filter, entity);
        }
    }
}
