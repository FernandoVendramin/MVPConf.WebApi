using MVPConf.Application.Models;
using MVPConf.Application.Repositories.Interfaces;
using MVPConf.Application.Services.Interfaces;
using System.Collections.Generic;

namespace MVPConf.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
