using ProjectPricing;
using ProjectPricing.Interfaces;
using Unity;

namespace PricingTest
{
    public class BaseTest
    {
        public IUnityContainer dependancies()
        {
            return new UnityContainer()
                .RegisterType<IBasketService, BasketService>();                

        }
    }
}
