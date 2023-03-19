using Contracts;
using Microsoft.EntityFrameworkCore;
using Models;
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

        public IEnumerable<Product> GetAllProducts()=>
            FindAll()
            .OrderBy(p=>p.Name)
            .ToList();

        public Product GetProductById(int id)=>
            FindByCondition(p=> p.Id.Equals(id)).SingleOrDefault();
    }
}
