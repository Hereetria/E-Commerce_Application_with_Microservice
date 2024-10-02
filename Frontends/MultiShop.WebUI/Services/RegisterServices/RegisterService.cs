using MultiShop.DtoLayer.IdentityDtos.RegisterDtos;

namespace MultiShop.WebUI.Services.RegisterServices
{
    public class RegisterService : IRegisterService
    {
        private readonly HttpClient _httpClient;

        public RegisterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateRegisterAsync(CreateRegisterDto createRegisterDto)
        {
            await _httpClient.PostAsJsonAsync("Registers", createRegisterDto);
        }
    }
}
