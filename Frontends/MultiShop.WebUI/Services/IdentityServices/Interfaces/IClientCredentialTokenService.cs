namespace MultiShop.WebUI.Services.IdentityServices.Interfaces
{
    public interface IClientCredentialTokenService
    {
        Task<string> GetToken();
    }
}
