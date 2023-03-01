using ProjectPricing.Models;
using System;
using System.Collections.Generic;

namespace ProjectPricing.PromotionStratagies
{
    public class SeasonSale : IPromotions
    {
        //season sale calculation
        public decimal CalculatePromotionDiscount(Tuple<int, string> item, Product product = null, List<Tuple<int, string>> skusWithQty = null)
        {
            //Just to show extension purpose only
            //logic can be implemented when required 
            return 0;
        }
    }
}
