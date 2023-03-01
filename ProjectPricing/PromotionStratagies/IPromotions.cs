using ProjectPricing.Models;
using System;
using System.Collections.Generic;

namespace ProjectPricing.PromotionStratagies
{
    public interface IPromotions
    {
        decimal CalculatePromotionDiscount(Tuple<int, string> item, Product product = null, List<Tuple<int, string>> skusWithQty = null);
    }
}
