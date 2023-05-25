using Contracts;
using Microsoft.EntityFrameworkCore;
using Models;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateProduct(Product product) =>
            Create(product);

        public void DeleteProduct(Product product)
        {
            Delete(product);
        }

        public async Task<PagedList<Product>> GetAllProducts(ProductParameters productParameters)
        {
            var products = await FindAll().OrderBy(p => p.Name).ToListAsync();

            return PagedList<Product>
                .ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }

        public async Task<Product> GetProductById(int id)=>
           await FindByCondition(p=> p.Id.Equals(id)).SingleOrDefaultAsync();
    }
}
