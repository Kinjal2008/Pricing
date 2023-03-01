using ProjectPricing.Enums;
using ProjectPricing.Interfaces;
using ProjectPricing.PromotionStratagies;
using ProjectPricing.Services;
using System;
using System.Collections.Generic;
using Unity;

namespace ProjectPricing
{
    public class BasketService : BaseService, IBasketService
    {
        /// <summary>
        /// Adding product to basket.
        /// </summary>
        /// <param name="skusWithQty">Provide quantity and sku of product</param>
        /// <returns>Total basket value for payment</returns>
        public decimal AddProducts(List<Tuple<int, string>> skusWithQty)
        {
            try
            {
                //Resolving Dependancies, atthe moment we have not start up to configure at that stage
                //However, we can implement in a better manner in real application
                var container = dependancies();
                var productService = container.Resolve<ProductService>();
                var promotionService = container.Resolve<PromotionService>();

                var discountPrice = 0M;
                var totalLineItemPrice = 0M;

                Dictionary<string, Func<IPromotions>> listPromotions = new Dictionary<string, Func<IPromotions>>() {
                            { PromotionTypes.Buy2Get1Free.ToString(), () => new BuyTwoGetOne() },
                            { PromotionTypes.Buy2Get10Off.ToString(), () => new BuyTwoGetTenPerOff() },
                            { PromotionTypes.SeasonSale.ToString(), () => new SeasonSale() },
                        };

                foreach (var item in skusWithQty)
                {
                    var product = productService.GetProduct(item.Item2);

                    //Total price calculation befor discount.
                    totalLineItemPrice = totalLineItemPrice + (product.UnitPrice * item.Item1);

                    //Promotion discount calculation.
                    if (product.PromotionId.HasValue)
                    {
                        var promotion = promotionService.GetPromotion(product.PromotionId.Value);
                        if (promotion != null)
                        {
                            //Strategy implementation to call function according promotion
                            discountPrice += listPromotions[promotion.PromotionCode]().CalculatePromotionDiscount(item, product, skusWithQty);
                        }
                    }
                }
                //Total payable amount for items in basket
                return totalLineItemPrice - discountPrice;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured while adding product. {0}", ex.Message);
                return 0;
            }
        }
    }
}
