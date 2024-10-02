using MultiShop.DtoLayer.IdentityDtos.LoginDtos;

namespace MultiShop.WebUI.Services.IdentityServices.Interfaces
{
    public interface IIdentityService
    {
        Task<bool> SignIn(SignInDto signUpDto);

        Task<bool> GetRefreshToken();

        Task<bool> SignOut();
    }
}
