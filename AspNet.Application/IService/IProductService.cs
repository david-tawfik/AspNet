using AspNet.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet.Application.IService
{
    public interface IProductService
    {
        Task AddProduct(Product product);
        Task<ActionResult> DeleteProduct(int id);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<ActionResult> UpdateProduct(int id, Product product);


    }
}
