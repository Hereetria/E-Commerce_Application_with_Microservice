namespace MultiShop.Catalog.Services.Interfaces
{
    public interface IGenericRepository<TCreateDto, TUpdateDto, TResultDto, TKey>
        where TCreateDto : class
        where TUpdateDto : class
        where TResultDto : class
    {
        Task<List<TResultDto>> GetAllAsync();

        Task CreateAsync(TCreateDto createDto);

        Task UpdateAsync(TUpdateDto updateDto);

        Task DeleteAsync(TKey id);

        Task<TResultDto> GetByIdAsync(TKey id);
    }
}
