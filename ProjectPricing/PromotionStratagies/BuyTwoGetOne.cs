using ProjectPricing.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPricing.PromotionStratagies
{
    public class BuyTwoGetOne : IPromotions
    {
        //Buy two, get one free promotion calculation
        public decimal CalculatePromotionDiscount(Tuple<int, string> item, Product product = null, List<Tuple<int, string>> skusWithQty = null)
        {
            var discountPrice = 0M;
            var applicableDiscountItemCount = item.Item1 / 2;
            if (product.PromotionProductId.HasValue)
            {
                ProductService productService = new ProductService();
                var productForDicount = productService.GetProduct(product.PromotionProductId.Value);
                var promotionalAvailableProduct = skusWithQty.FirstOrDefault(x => x.Item2 == productForDicount.Sku);
                if (promotionalAvailableProduct != null)
                {
                    if (applicableDiscountItemCount >= promotionalAvailableProduct.Item1)
                    {
                        discountPrice = (productForDicount.UnitPrice * promotionalAvailableProduct.Item1);
                    }
                    else
                    {
                        discountPrice = (productForDicount.UnitPrice * applicableDiscountItemCount);
                    }
                }
            }

            return discountPrice;
        }
    }
}
