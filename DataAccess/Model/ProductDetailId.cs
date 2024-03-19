using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class ProductDetailId
    {
        public int ProductId { get; set; } // รหัสสินค้า
        public string ProductName { get; set; } // ชื่อสิ้นค้า
        public string PrimaryUnit { get; set; }
        public string SecondaryUnit { get; set; }

    }
}
