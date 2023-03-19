﻿using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAllProducts();
        ProductDto GetProductById(int id);
        ProductDto CreateProduct(ProductDtoForCreation product);
    }
}
