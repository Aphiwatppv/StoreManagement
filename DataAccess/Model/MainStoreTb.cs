using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class MainStoreTb
    {
        public int ProductId { get; set; } // รหัสสินค้า
        public string ProductName { get; set; } // ชื่อสิ้นค้า
        public decimal RemainingStockPrimaryUnit { get; set; } 
        public string PrimaryUnit { get; set; }
        public decimal RemainingStockSecondaryUnit { get; set; }
        public string SecondaryUnit { get; set; }
        public decimal? RelationUnit { get; set; }
        public decimal? CostPricePrimaryUnit { get; set; }
        public decimal? PricePrimaryUnit { get; set; }
        public decimal? CostPriceSecondaryUnit { get; set; }
        public decimal? PriceSecondaryUnit { get; set; }
        public string UnitPrice { get; set; }
    }
}
