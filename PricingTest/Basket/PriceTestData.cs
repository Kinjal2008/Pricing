using System;
using System.Collections.Generic;

namespace PricingTest
{
    public static class PriceTestData
    {
        public static List<Tuple<int, string>> AddProducts_AllPromotions_Data()
        {
            var purchasedProducts = new List<Tuple<int, string>>();
            purchasedProducts.Add(Tuple.Create(2, "P001")); //Apple
            purchasedProducts.Add(Tuple.Create(1, "P002")); //Orange
            purchasedProducts.Add(Tuple.Create(3, "P003")); //Banana
            purchasedProducts.Add(Tuple.Create(2, "P004")); //Mango
            purchasedProducts.Add(Tuple.Create(5, "P005")); //Watermelon

            return purchasedProducts;
        }

        public static List<Tuple<int, string>> AddProducts_AllBuy2Get1Free_TwoProductsWithPromotions_SingleOfferProductAdded_Data()
        {
            var purchasedProducts = new List<Tuple<int, string>>();
            purchasedProducts.Add(Tuple.Create(5, "P001")); //Apple
            purchasedProducts.Add(Tuple.Create(1, "P002")); //Orange
            purchasedProducts.Add(Tuple.Create(2, "P005")); //Watermelon

            return purchasedProducts;
        }

        public static List<Tuple<int, string>> AddProducts_AllBuy2Get1Free_TwoProductsWithPromotions_DoubleOfferProductAdded_Data()
        {
            var purchasedProducts = new List<Tuple<int, string>>();
            purchasedProducts.Add(Tuple.Create(2, "P001")); //Apple
            purchasedProducts.Add(Tuple.Create(1, "P002")); //Orange
            purchasedProducts.Add(Tuple.Create(2, "P005")); //Watermelon
            purchasedProducts.Add(Tuple.Create(2, "P003")); //Banana

            return purchasedProducts;
        }

        public static List<Tuple<int, string>> AddProducts_AllBuy2Get10PerOff_OfferApplied_Data()
        {
            var purchasedProducts = new List<Tuple<int, string>>();
            purchasedProducts.Add(Tuple.Create(3, "P004")); //Mango
            purchasedProducts.Add(Tuple.Create(1, "P003")); //Banana

            return purchasedProducts;
        }

        public static List<Tuple<int, string>> AddProducts_AllItemsWithoutPromotions_Data()
        {
            var purchasedProducts = new List<Tuple<int, string>>();
            purchasedProducts.Add(Tuple.Create(1, "P001")); //Apple
            purchasedProducts.Add(Tuple.Create(1, "P002")); //Orange
            purchasedProducts.Add(Tuple.Create(1, "P003")); //Banana
            purchasedProducts.Add(Tuple.Create(1, "P004")); //Mango
            purchasedProducts.Add(Tuple.Create(1, "P005")); //Watermelon

            return purchasedProducts;
        }
    }
}
