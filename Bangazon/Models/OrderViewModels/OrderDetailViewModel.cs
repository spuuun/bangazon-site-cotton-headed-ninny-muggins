using System.Collections.Generic;

namespace Bangazon.Models.OrderViewModels
{
    public class OrderDetailViewModel
    {
        public Order Order { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
        public IEnumerable<OrderLineItem> LineItems { get; set; }
    }
}