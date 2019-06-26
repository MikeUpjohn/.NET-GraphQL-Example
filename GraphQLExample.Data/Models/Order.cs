using System.Collections.Generic;
using System.Linq;

namespace GraphQLExample.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double OrderTotal
        {
            get
            {
                return Products.Sum(x => x.Price);
            }
        }

        public IList<Product> Products { get; set; }
    }
}
