using MultiShop.DtoLayer.IdentityDtos.RegisterDtos;

namespace MultiShop.WebUI.Services.RegisterServices
{
    public interface IRegisterService
    {
        Task CreateRegisterAsync(CreateRegisterDto createRegisterDto);
    }
}
