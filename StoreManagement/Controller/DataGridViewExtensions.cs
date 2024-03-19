using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Controller
{
    public static class DataGridViewExtensions
    {
        public static void SaveAsCsv(this DataGridView dgv, string filePath)
        {
            StringBuilder csvContent = new StringBuilder();

            // Header
            string[] columnNames = new string[dgv.Columns.Count];
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                columnNames[i] = dgv.Columns[i].HeaderText;
            }
            csvContent.AppendLine(string.Join(",", columnNames));

            // Rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] cellValues = new string[dgv.Columns.Count];
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        cellValues[i] = "\"" + row.Cells[i].Value?.ToString().Replace("\"", "\"\"") + "\""; // Handle commas, quotes, and nulls
                    }
                    csvContent.AppendLine(string.Join(",", cellValues));
                }
            }

            // Write to file
            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
        }
    }
}
