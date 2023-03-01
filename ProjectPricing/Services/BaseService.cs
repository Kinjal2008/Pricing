using ProjectPricing.Interfaces;
using Unity;



namespace ProjectPricing.Services
{
    public class BaseService
    {
        public IUnityContainer dependancies()
        {
            return new UnityContainer()
                .RegisterType<IProductService, ProductService>()
                .RegisterType<IPromotionService, PromotionService>();

        }
    }
}
