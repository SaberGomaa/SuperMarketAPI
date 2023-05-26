using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IAdminService Admin { get; }
        ICartService Cart { get; }
        IContactService Contact { get; }
        ICustomerService Customer { get; }
        IOrderService Order { get; }
        IProductService Product { get; }
        IAuthenticationService Authentication { get; }
    }
}
