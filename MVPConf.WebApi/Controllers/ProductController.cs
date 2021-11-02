using Microsoft.AspNetCore.Mvc;
using MVPConf.Application.Models;
using MVPConf.Application.Services.Interfaces;
using System.Collections.Generic;

namespace MVPConf.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }
    }
}
