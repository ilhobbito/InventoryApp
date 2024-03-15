using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory3.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
        public DateOnly PurchasingDate { get; set; }
        public DateOnly BestBefore { get; set; }
        public string? Place { get; set; }
    }
}
