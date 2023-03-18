using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Models;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            var products = _repository.Product.GetAllProducts();

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            return productsDto;
        }

        public ProductDto GetProductById(int id)
        {
            var product = _repository.Product.GetProductById(id);
            if (product == null)
            {
                throw new ProductNotFoundException(id);
            }

            var productDto = _mapper.Map<ProductDto>(product);

            return productDto;
        }
    }
}
