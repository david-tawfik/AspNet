using AspNet.Application.IService;
using AspNet.Domain;
using AspNet.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.Application.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<IEnumerable<Product>> GetAllProducts()
        {
            return  _productRepository.GetAllProducts();
        }

        public Task AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public Task<Product> GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public Task<ActionResult> DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public Task<ActionResult> UpdateProduct(int id, Product product)
        {
            return _productRepository.UpdateProduct(id, product);
        }
    }
}
