﻿using Entities.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Presentation.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IServiceManager _service;

        public ProductController(IServiceManager service)
        {
            _service = service;
        }

        [Route("GetProducts")]
        [HttpGet]
        public ActionResult GetProducts()
        {
            var products = _service.Product.GetAllProducts();

            if (products is null) throw new Exception("No Products Found");

            return Ok(products);
        }

        [Route("{id:int}", Name = "GetProductById")]
        [HttpGet]
        public ActionResult GetProductById(int id)
        {
            var product = _service.Product.GetProductById(id);
            if (product is null) throw new ProductNotFoundException(id);

            return Ok(product);
        }
    }
}