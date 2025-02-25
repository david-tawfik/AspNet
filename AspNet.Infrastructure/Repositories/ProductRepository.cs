using AspNet.Application.IRepository;
using AspNet.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await Task.FromResult(_context.Set<Product>().ToList());
        }

        public async Task AddProduct(Product product)
        {
            product.Id = 0;
            _context.Set<Product>().Add(product);
            _context.SaveChanges();
            await Task.CompletedTask;
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = await Task.FromResult(_context.Set<Product>().Find(id));
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id {id} not found.");
            }
            return product;
        }

        public async Task<ActionResult> DeleteProduct(int id)
        {
            var product = await _context.Set<Product>().FindAsync(id);
            if (product == null)
            {
                return new NotFoundResult();
            }

            _context.Set<Product>().Remove(product);
            await _context.SaveChangesAsync();
            return new OkResult();
        }

        public async Task<ActionResult> UpdateProduct(int id, Product product)
        {
            var existingProduct = await _context.Set<Product>().FindAsync(id);
            if (existingProduct == null)
            {
                return new NotFoundResult();
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            _context.Set<Product>().Update(existingProduct);
            await _context.SaveChangesAsync();
            return new OkResult();
        }
    }

}
