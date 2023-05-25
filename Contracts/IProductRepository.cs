using Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IProductRepository
    {
        Task<PagedList<Product>> GetAllProducts(ProductParameters productParameters);
        Task<Product> GetProductById(int id);
        void CreateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
