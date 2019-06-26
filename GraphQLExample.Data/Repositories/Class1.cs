using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQLExample.Data.Models;

namespace GraphQLExample.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OrdersContext _db;

        public ProductRepository(OrdersContext db)
        {
            _db = db;
        }

        public Task<Product> AddNewProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Product>> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
