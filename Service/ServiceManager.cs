﻿using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAdminService> _adminService;
        private readonly Lazy<ICartService> _cartService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<ICustomerService> _customersService;
        private readonly Lazy<IContactService> _contactService;
        private readonly Lazy<IOrderService> _orderService;
        private readonly Lazy<IAuthenticationService> _authenticationService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger , IMapper mapper , 
            UserManager<User> userManager, IConfiguration configuration)
        {
            _adminService = new Lazy<IAdminService>(() => new AdminService(logger, repositoryManager , mapper));
            _cartService = new Lazy<ICartService>(() => new CartService(repositoryManager, logger , mapper));
            _contactService = new Lazy<IContactService>(() => new ContactService(repositoryManager, logger, mapper));
            _customersService = new Lazy<ICustomerService>(() => new CustomerService(repositoryManager, logger, mapper));
            _orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager, logger, mapper));
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() =>
            new AuthenticationService(logger, mapper,configuration,
            userManager));
        }

        public IAdminService Admin => _adminService.Value;
        public ICartService Cart => _cartService.Value;
        public IContactService Contact => _contactService.Value;
        public ICustomerService Customer => _customersService.Value;
        public IOrderService Order => _orderService.Value;
        public IProductService Product => _productService.Value;
        public IAuthenticationService Authentication => _authenticationService.Value;

    }
}
