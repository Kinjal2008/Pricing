using ProjectPricing.Models;
using System;
using System.Collections.Generic;

namespace ProjectPricing.PromotionStratagies
{
    public class BuyTwoGetTenPerOff : IPromotions
    {
        //Buy two, get ten percent off promotion calculation
        public decimal CalculatePromotionDiscount(Tuple<int, string> item, Product product, List<Tuple<int, string>> skusWithQty = null)
        {
            decimal discountPrice = 0M;
            if (item.Item1 > 1 && !product.PromotionProductId.HasValue)
            {
                discountPrice = (((product.UnitPrice * item.Item1) * 10) / 100);
            }
            return discountPrice;
        }
    }
}
