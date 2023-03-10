using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManger
    {
        public IAdminRepository Admin { get; }
        public ICartRepository Cart { get; }
        public IContactRepository Contact { get; }
        public ICustomerRepository Customer { get; }
        public IOrderRepository Order { get; }
        public IProductRepository Product { get; }

        void Save();

    }
}
