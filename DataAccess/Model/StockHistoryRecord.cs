using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model;

public class StockHistoryRecord
{
    public string HistoryId { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ChangeType { get; set; }
    public decimal? QuantityChanged { get; set; }
    public string Unit { get; set; }
    public decimal? NewQuantity { get; set; }
    public string Reason { get; set; }
    public DateTime DateChanged { get; set; }
}
