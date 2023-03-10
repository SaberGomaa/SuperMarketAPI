using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        public IAdminService Admin { get; }
        public ICartService Cart { get; }
        public IContactService Contact { get; }
        public ICustomerService Customer { get; }
        public IOrderService Order { get; }
        public IProductService Product { get; }
    }
}
