using MultiShop.WebUI.Models;

namespace MultiShop.WebUI.Services.IdentityServices.Interfaces
{
    public interface IUserService
    {
        Task<UserDetailViewModel> GetUserInfo();
    }
}
