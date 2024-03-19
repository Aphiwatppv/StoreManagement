using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class GenerateCarProductTransactionForm
    {
        public string TransactionId { get; set; }
        public string ProductName { get; set; }
        public string PrimaryUnit { get; set; }
        public string SecondaryUnit { get; set; }
        public decimal TakeQuantityPrimaryUnit { get; set; } = 0;
        public decimal ReturnQuantityPrimaryUnit { get; set; } = 0;
        public decimal TakeQuantitySecondaryUnit { get; set; } = 0;
        public decimal ReturnQuantitySecondaryUnit { get; set; } = 0;
        public decimal SalePrimaryUnit { get; set; } = 0;
        public decimal SaleSecondaryUnit { get; set; } = 0;
        public decimal? CostPricePrimaryUnit { get; set; }
        public decimal? PricePrimaryUnit { get; set; }
        public decimal? CostPriceSecondaryUnit { get; set; }
        public decimal? PriceSecondaryUnit { get; set; }
    }
}
