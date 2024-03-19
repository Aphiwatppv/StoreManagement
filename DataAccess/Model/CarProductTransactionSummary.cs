using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class CarProductTransactionSummary
    {
        public string Id { get; set; }
        public string CarModel { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TotalProduct { get; set; }
        public decimal CostMoney { get; set; }
        public decimal ActualMoney { get; set; }
        public decimal? MoneyFromCar { get; set; } // Assuming this might be null if not filled
        public decimal DifferenceMoney { get; set; }
    }
}
