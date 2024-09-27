using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment.Models
{
    public class Details
    {
        [Key]
        public int  ProductID { get; set; }
        public required string ProductName { get; set; }
        public required string Brand { get; set; }
        public required string StockQuantity { get; set; }
        public required int Price { get; set; }
        public required string Inventory { get; set; }
        public required int Weight { get; set; }
        public required string Description { get; set; }

    }
}
