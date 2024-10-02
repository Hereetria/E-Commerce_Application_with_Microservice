namespace MultiShop.WebUI.Services.CatalogServices.Repositories
{
    public interface ICatalogGenericRepository<TCreateDto, TUpdateDto, TResultDto>
        where TCreateDto : class
        where TUpdateDto : class
        where TResultDto : class
    {
        Task<List<TResultDto>> GetAllAsync();

        Task CreateAsync(TCreateDto dto);

        Task UpdateAsync(TUpdateDto dto);

        Task DeleteAsync(string id);

        Task<TUpdateDto> GetByIdAsync(string id);
    }
}
