using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Models;
using Service.Contracts;
using Shared.DTO;
using Shared.RequestFeatures;
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

        public async Task<ProductDto> CreateProduct(ProductDtoForCreation product)
        {
            var prod = _mapper.Map<Product>(product);

            _repository.Product.CreateProduct(prod);
            await _repository.SaveAsync();

            var pro = _mapper.Map<ProductDto>(prod);

            return pro;

        }

        public async Task<IEnumerable<ProductDto>> GetAllProducts(ProductParameters productParameters)
        {
            var products =await _repository.Product.GetAllProducts(productParameters);

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            return productsDto;
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            var product = await _repository.Product.GetProductById(id);
            if (product == null)
            {
                throw new ProductNotFoundException(id);
            }

            var productDto = _mapper.Map<ProductDto>(product);

            return productDto;
        }

        public async Task<ProductDto> DeleteProduct(int id)
        {
            var prodoct = await _repository.Product.GetProductById(id);

            if(prodoct == null)
            {
                throw new ProductNotFoundException(id);
            }
            else
            {
                _repository.Product.DeleteProduct(prodoct);
                await _repository.SaveAsync();
            }

            var returnedProduct = _mapper.Map<ProductDto>(prodoct);

            return returnedProduct;

        }
        
    }
}
