using APO_TEST.Interfaces;
using APO_TEST.Models;
using System.Xml.Linq;

namespace APO_TEST.Services
{
    public class ProductService : IProductService
    {
        private List<ProductModel> _products = new List<ProductModel>
        {
         new ProductModel( 1, "Laptop","A high-performance laptop", 1200 ),
         new ProductModel( 2, "ROG Phone","A high-performance smartphone", 1200 ),
         new ProductModel( 3, "AI Station","A Multiple GPU server computer", 1200 ),
        };

        public Task AddProductAsync(ProductModel product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
            return Task.CompletedTask;
        }

        public Task DeleteProductAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
            return Task.CompletedTask;
        }

        public Task<IEnumerable<ProductModel>> GetAllProductsAsync()
        {
            return Task.FromResult<IEnumerable<ProductModel>>(_products);
        }

        public Task<ProductModel> GetProductByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return product == null ? throw new HttpRequestException() : Task.FromResult(product);
        }

        public Task UpdateProductAsync(ProductModel product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
            }
            return Task.CompletedTask;
        }
    }
}
