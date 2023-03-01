using ProjectPricing.Models;
using System.Collections.Generic;

namespace ProjectPricing.Data
{
    public static class DBContext
    {   
        public static List<Product> GetProductData()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { ProductId = 1, Sku = "P001", ProductName = "Apple", PromotionId = 1, PromotionProductId = 2, UnitPrice = 1.5M });
            products.Add(new Product() { ProductId = 2, Sku = "P002", ProductName = "Orange", UnitPrice = 0.5M });
            products.Add(new Product() { ProductId = 3, Sku = "P003", ProductName = "Banana", PromotionId = 3, UnitPrice = 0.2M });
            products.Add(new Product() { ProductId = 4, Sku = "P004", ProductName = "Mango", PromotionId = 2, UnitPrice = 2M });
            products.Add(new Product() { ProductId = 5, Sku = "P005", ProductName = "Watermelon", PromotionId = 1, PromotionProductId = 3, UnitPrice = 3M });

            return products;
        }

        public static List<Promotion> GetPromotionData()
        {
            List<Promotion> promotions = new List<Promotion>();
            promotions.Add(new Promotion() { PromotionId = 1, PromotionCode = "Buy2Get1Free", PromotionName = "Buy two, get one free", IsActive = true });
            promotions.Add(new Promotion() { PromotionId = 2, PromotionCode = "Buy2Get10Off", PromotionName = "Buy two, get 10% off", IsActive = true });
            promotions.Add(new Promotion() { PromotionId = 3, PromotionCode = "SeasonSale", PromotionName = "Flat £0.5 Off", IsActive = false });

            return promotions;
        }
    }
}
