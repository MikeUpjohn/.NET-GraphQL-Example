using System.Collections.Generic;

namespace GraphQLExample.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Address BillingAddress { get; set; }
        public Address DeliveryAddress { get; set; }
        public bool IsEnabled { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
