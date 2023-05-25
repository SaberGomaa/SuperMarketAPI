using Shared.DTO;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IProductService
    {
        Task<(IEnumerable<ProductDto> productDtos , MetaData MetaData)> GetAllProducts(ProductParameters productParameters);
        Task<ProductDto> GetProductById(int id);
        Task<ProductDto> CreateProduct(ProductDtoForCreation product);
        Task<ProductDto> DeleteProduct(int id);
    }
}
