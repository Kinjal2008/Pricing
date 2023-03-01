namespace ProjectPricing.Models
{
    public class Promotion
    {
        public int PromotionId { get; set; }

        public string PromotionCode { get; set; }

        public string PromotionName { get; set; }

        public bool IsActive { get; set; }
    }
}
