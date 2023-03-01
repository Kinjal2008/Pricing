using ProjectPricing.Interfaces;
using ProjectPricing.Models;
using ProjectPricing.Data;
using System.Linq;

namespace ProjectPricing
{
    public class ProductService : IProductService
    {
        public Product GetProduct(string sku)
        {
            return DBContext.GetProductData().FirstOrDefault(x => x.Sku == sku);
        }

        public Product GetProduct(int id)
        {
            return DBContext.GetProductData().FirstOrDefault(x => x.ProductId == id);
        }
    }
}
