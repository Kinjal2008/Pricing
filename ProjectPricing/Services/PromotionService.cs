using ProjectPricing.Interfaces;
using ProjectPricing.Models;
using ProjectPricing.Data;
using System.Linq;

namespace ProjectPricing
{
    public class PromotionService : IPromotionService
    {
        public Promotion GetPromotion(int id)
        {
            return DBContext.GetPromotionData().FirstOrDefault(x => x.PromotionId == id && x.IsActive);
        }
    }
}
