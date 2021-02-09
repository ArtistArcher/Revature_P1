using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.ViewModels
{
    public class CartViewModel
    {
        public Guid CartId { get; set; }
        public Guid StoreId { get; set; }
        public Guid UserId { get; set; }
        public string CartStatus { get; set; }

        public string StoreName { get; set; }
        public string UserName { get; set; }

        // List of Order Items in Cart
        public List<Order> OrderItems { get; set; } = new List<Order>();
    }
}
