using AspNet.Domain;
using Microsoft.AspNetCore.Mvc;


namespace AspNet.Application.IRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task AddProduct(Product product);

        Task<Product> GetProductById(int id);

        Task<ActionResult> DeleteProduct(int id);

        Task<ActionResult> UpdateProduct(int id, Product product);
    }
}
