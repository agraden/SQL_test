using SQLTest.Models;

namespace SQLTest.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}