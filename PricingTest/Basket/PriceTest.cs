using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPricing;
using Unity;

namespace PricingTest
{
    [TestClass]
    public class PriceTest : BaseTest
    {
        BasketService basketService;
        public PriceTest()
        {
            var container = dependancies();
            basketService = container.Resolve<BasketService>();
        }

        [TestMethod]
        public void AddProducts_AllPromotions_IncludingInActivePromotions()
        {
            //Arrange
            var expectedVirtualBasketPrice = 21.8M;

            //Act
            decimal price = basketService.AddProducts(PriceTestData.AddProducts_AllPromotions_Data());

            //Assert
            Assert.AreEqual(expectedVirtualBasketPrice, price);

        }

        [TestMethod]
        public void AddProducts_AllBuy2Get1Free_TwoProductsWithPromotions_SingleOfferProductAdded()
        {
            //Arrange
            var expectedVirtualBasketPrice = 13.5M;

            //Act
            decimal price = basketService.AddProducts(PriceTestData.AddProducts_AllBuy2Get1Free_TwoProductsWithPromotions_SingleOfferProductAdded_Data());

            //Assert
            Assert.AreEqual(expectedVirtualBasketPrice, price);
        }

        [TestMethod]
        public void AddProducts_AllBuy2Get1Free_TwoProductsWithPromotions_DoubleOfferProductAdded()
        {
            //Arrange
            var expectedVirtualBasketPrice = 9.2M;

            //Act
            decimal price = basketService.AddProducts(PriceTestData.AddProducts_AllBuy2Get1Free_TwoProductsWithPromotions_DoubleOfferProductAdded_Data());

            //Assert
            Assert.AreEqual(expectedVirtualBasketPrice, price);
        }

        [TestMethod]
        public void AddProducts_AllBuy2Get10PerOff_OfferApplied()
        {
            //Arrange
            var expectedVirtualBasketPrice = 5.6M;

            //Act
            decimal price = basketService.AddProducts(PriceTestData.AddProducts_AllBuy2Get10PerOff_OfferApplied_Data());

            //Assert
            Assert.AreEqual(expectedVirtualBasketPrice, price);
        }

        [TestMethod]
        public void AddProducts_AllItemsWithoutPromotions()
        {
            //Arrange
            var expectedVirtualBasketPrice = 7.2M;

            //Act
            decimal price = basketService.AddProducts(PriceTestData.AddProducts_AllItemsWithoutPromotions_Data());


            //Assert
            Assert.AreEqual(expectedVirtualBasketPrice, price);
        }
    }
}
