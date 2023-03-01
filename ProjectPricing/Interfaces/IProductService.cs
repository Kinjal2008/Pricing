using ProjectPricing.Models;

namespace ProjectPricing.Interfaces
{
    public interface IProductService
    {
        Product GetProduct(string sku);

        Product GetProduct(int id);
    }
}
