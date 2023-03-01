namespace ProjectPricing.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public int? PromotionId { get; set; }
        public int? PromotionProductId { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
