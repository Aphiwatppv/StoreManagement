using System.Windows.Forms;

namespace StoreManagement.Controller
{
    public static class LogicBusiness
    {
        public static List<decimal> CalculateActualMoney(DataGridView dataGridView)
        {
            decimal totalSalePrice = 0m, totalCostPrice = 0m;

            if (dataGridView != null && dataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (decimal.TryParse(row.Cells["SalePrimaryUnit"].Value?.ToString(), out decimal salePrimaryUnit) &&
                            decimal.TryParse(row.Cells["SaleSecondaryUnit"].Value?.ToString(), out decimal saleSecondaryUnit) &&
                            decimal.TryParse(row.Cells["CostPricePrimaryUnit"].Value?.ToString(), out decimal costPricePrimaryUnit) &&
                            decimal.TryParse(row.Cells["PricePrimaryUnit"].Value?.ToString(), out decimal pricePrimaryUnit) &&
                            decimal.TryParse(row.Cells["CostPriceSecondaryUnit"].Value?.ToString(), out decimal costPriceSecondaryUnit) &&
                            decimal.TryParse(row.Cells["PriceSecondaryUnit"].Value?.ToString(), out decimal priceSecondaryUnit))
                        {
                            totalSalePrice += (salePrimaryUnit * pricePrimaryUnit) + (saleSecondaryUnit * priceSecondaryUnit);
                            totalCostPrice += (salePrimaryUnit * costPricePrimaryUnit) + (saleSecondaryUnit * costPriceSecondaryUnit);
                        }
                    }
                }
            }
            return new List<decimal> { totalSalePrice, totalCostPrice };
        }


        public static void UpdateRows(int rowIndex, DataGridView dataGridView)
        {
            // Safeguard checks
            if (dataGridView == null || rowIndex < 0 || rowIndex >= dataGridView.Rows.Count) return;

            // Column pairs for calculation: (A,B,C) and (D,E,F)
            // Assuming A,B,D,E are input columns and C,F are the calculated columns
            var columnPairs = new List<(int input1, int input2, int output)>
    {
        (4, 5, 8), // Column indices for A, B, and C
        (6, 7, 9)  // Column indices for D, E, and F
    };

            foreach (var (input1, input2, output) in columnPairs)
            {
                CalculateAndSetDifference(rowIndex, dataGridView, input1, input2, output);
            }
        }

        private static void CalculateAndSetDifference(int rowIndex, DataGridView dataGridView, int columnIndexInput1, int columnIndexInput2, int columnIndexOutput)
        {
            // Fetch the cell values
            var cellInput1 = dataGridView.Rows[rowIndex].Cells[columnIndexInput1].Value;
            var cellInput2 = dataGridView.Rows[rowIndex].Cells[columnIndexInput2].Value;

            // Attempt to parse the cell values as decimals
            if (cellInput1 != null && cellInput2 != null &&
                decimal.TryParse(cellInput1.ToString(), out decimal value1) &&
                decimal.TryParse(cellInput2.ToString(), out decimal value2))
            {
                // Calculate difference and assign to the output cell
                dataGridView.Rows[rowIndex].Cells[columnIndexOutput].Value = value1 - value2;
            }
            else
            {
                // Clear the output cell if inputs are invalid or missing
                dataGridView.Rows[rowIndex].Cells[columnIndexOutput].Value = DBNull.Value;
            }
        }

        public static decimal DiffMoney(decimal MoneyA , decimal MoneyB)
        {
            var result = MoneyA - MoneyB;
            return result;
        }
    }
}
