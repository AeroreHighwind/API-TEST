using API_TEST.Models;

namespace API_TEST.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetAllProductsAsync();
        Task<ProductModel> GetProductByIdAsync(int id);
        Task AddProductAsync(ProductModel product);
        Task UpdateProductAsync(ProductModel product);
        Task DeleteProductAsync(int id);
    }
}
