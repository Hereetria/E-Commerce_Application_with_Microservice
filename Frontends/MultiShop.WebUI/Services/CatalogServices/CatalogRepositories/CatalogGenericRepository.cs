
using Newtonsoft.Json;

namespace MultiShop.WebUI.Services.CatalogServices.Repositories
{
    public abstract class CatalogGenericRepository<TCreateDto, TUpdateDto, TResultDto> : ICatalogGenericRepository<TCreateDto, TUpdateDto, TResultDto>
    where TCreateDto : class
    where TUpdateDto : class
    where TResultDto : class
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _tableName;

        protected CatalogGenericRepository(HttpClient httpClient, string tableName)
        {
            _httpClient = httpClient;
            _tableName = tableName;
        }

        public async Task CreateAsync(TCreateDto createDto)
        {
            await _httpClient.PostAsJsonAsync(_tableName, createDto);
        }

        public async Task DeleteAsync(string id)
        {
            await _httpClient.DeleteAsync(_tableName + "?id=" + id);
        }

        public async Task<List<TResultDto>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync(_tableName);
            var values = await responseMessage.Content.ReadFromJsonAsync<List<TResultDto>>();
            return values;
        }

        public async Task<TUpdateDto> GetByIdAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync(_tableName + "/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<TUpdateDto>();
            return values;
        }

        public async Task UpdateAsync(TUpdateDto updateDto)
        {
            await _httpClient.PutAsJsonAsync(_tableName, updateDto);
        }
    }
}
