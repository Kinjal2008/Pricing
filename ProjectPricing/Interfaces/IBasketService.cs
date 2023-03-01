using System;
using System.Collections.Generic;

namespace ProjectPricing.Interfaces
{
    public interface IBasketService
    {
        decimal AddProducts(List<Tuple<int, string>> skusWithQty);
    }
}
