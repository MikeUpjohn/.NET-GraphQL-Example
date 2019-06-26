using GraphQLExample.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQLExample.Data.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetAllProducts();
        Task<Product> AddNewProduct(Product product);
    }
}
