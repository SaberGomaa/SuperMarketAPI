using Contracts;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CartRepository : RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
