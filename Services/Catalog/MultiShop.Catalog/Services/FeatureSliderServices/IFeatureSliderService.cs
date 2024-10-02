using MultiShop.Catalog.Dtos.FeatureSliderDtos;
using MultiShop.Catalog.Services.Interfaces;

namespace MultiShop.Catalog.Services.FeatureSliderServices
{
    public interface IFeatureSliderService : IGenericRepository<CreateFeatureSliderDto, UpdateFeatureSliderDto, ResultFeatureSliderDto, string>
    {
        Task FeatureSliderChangeStatusToTrue(string id);

        Task FeatureSliderChangeStatusToFalse(string id);
    }
}
