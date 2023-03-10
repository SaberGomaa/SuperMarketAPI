using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager :IRepositoryManger
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IAdminRepository> _adminRepository;
        private readonly Lazy<ICartRepository> _cartRepository;
        private readonly Lazy<IContactRepository> _contactRepository;
        private readonly Lazy<ICustomerRepository> _customerRepository;
        private readonly Lazy<IOrderRepository> _orderRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext= repositoryContext;
            _adminRepository = new Lazy<IAdminRepository>(() => new AdminRepository(repositoryContext));
            _cartRepository = new Lazy<ICartRepository>(() => new CartRepository(repositoryContext));
            _contactRepository = new Lazy<IContactRepository>(() => new ContactRepository(repositoryContext));
            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(repositoryContext));
            _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(repositoryContext));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));

        }

        public IAdminRepository Admin => _adminRepository.Value;

        public ICartRepository Cart => _cartRepository.Value;

        public IContactRepository Contact => _contactRepository.Value;

        public ICustomerRepository Customer => _customerRepository.Value;

        public IOrderRepository Order => _orderRepository.Value;

        public IProductRepository Product => _productRepository.Value;

        public void Save()=>_repositoryContext.SaveChanges();
        
    }
}
