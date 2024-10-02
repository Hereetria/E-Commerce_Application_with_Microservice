using MultiShop.WebUI.Models;
using MultiShop.WebUI.Services.IdentityServices.Interfaces;

namespace MultiShop.WebUI.Services.IdentityServices.Concrete
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserDetailViewModel> GetUserInfo()
        {
            return await _httpClient.GetFromJsonAsync<UserDetailViewModel>("/api/users/getuser");
        }
    }
}
