using StoreManagement.Controller;
using System.ComponentModel;

namespace StoreManagement.View
{
    public partial class UserControlMainStore : UserControl
    {
        IProductionService _productService;
        IStockHistoryService _stockHistoryService;
        MainStoreTb _mainStoreTb;
        StockHistoryRecord _stockHistoryRecord;
        Dictionary<string, string> _productUnitType;
        List<string> processType;
        private const string Increase = "Increase";
        private const string Decrease = "Decrease";

 

        int _productId;
        public UserControlMainStore()
        {
            InitializeComponent();
            _productService = new ProductionService(new SqlDataAccessInternal(new XmlAccess()));
            _stockHistoryService = new StockHistoryService(new SqlDataAccessInternal(new XmlAccess()));
            UserControlCheckStock.UpdateProduct += OtherUserControl_OnUpdateProduct;
        }

        private async void OtherUserControl_OnUpdateProduct(object? sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                var products = await _productService.GetAlldataAsync();
                if (products.Any())
                {
                    dvgProduction.DataSource = products;
                    dvgProduction.Refresh();
                    await LoadLabelProductAsync();
                }
                else
                {
                    MessageBox.Show("No products available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.LogMethod.LogError(ex);
                MessageBox.Show("Failed to load products. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadLabelProductAsync()
        {
            try
            {
                var Totalproducts = await _productService.GetTotalProductCountAsync();
                var TotalPrice = await _productService.CalculateTotalPriceAsync();
                var TotalCostPrice = await _productService.CalculateTotalCostPriceAsync();
                if (Totalproducts != 0)
                {
                    labelTotalproduct.Text = "สินค้าทั้งหมด:" + " " + Totalproducts.ToString() + " " + "รายการ";
                    labelTotalPrice.Text = "มูลค่าทั้งหมด : " + " " + TotalPrice.ToString("0.00") + " " + "บาท";
                    labelCostprice.Text = "ต้นทุนทั้งหมด : " + " " + TotalCostPrice.ToString("0.00") + " " + "บาท";
                }
                else
                {
                    MessageBox.Show("No products available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.LogMethod.LogError(ex);
                MessageBox.Show("Failed to load products. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadhistoricalRecordAsync()
        {
            try
            {
                var records = await _stockHistoryService.GetAllStockHistoryRecordAsync();
                if (records.Any())
                {
                    dgvhistoricalrecord.DataSource = records;
                    dgvhistoricalrecord.Refresh();
                }
                else
                {
                    var bindingList = new BindingList<StockHistoryRecord>();
                    var source = new BindingSource(bindingList, null);
                    dgvhistoricalrecord.DataSource = source;
                    dgvhistoricalrecord.Refresh();
                    //MessageBox.Show("No record available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.LogMethod.LogError(ex);
                MessageBox.Show("Failed to load record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void UserControlMainStore_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadUserControlDataAsync();
            }
            catch (Exception ex)
            {

                Logger.LogMethod.LogError(ex);
                MessageBox.Show("An error occurred while loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async Task LoadUserControlDataAsync()
        {
            await LoadProductsAsync();
            await LoadhistoricalRecordAsync();
            textBoxIdprocess.Enabled = false;
            textBoxNewQueantity.Enabled = false;
            textBoxproductNameP.Enabled = false;
            textBoxNewQueantity.Enabled = false;
            ConfigureDataGridView(dvgProduction);
            ConfigureDataGridViewHisRecord(dgvhistoricalrecord);
            ConfigureComboBox();
        }

        private void ConfigureComboBox()
        {
            processType = new List<string> { "Increase", "Decrease" };
            cbIncraseDecrease.DataSource = processType;
        }
        private async Task InitializeMainStoreRecord()
        {


            if (!decimal.TryParse(txtMainRemaining.Text, out decimal remainingStockPrimaryUnit) ||
                !decimal.TryParse(txtSecRemaing.Text, out decimal remainingStockSecondaryUnit) ||
                !decimal.TryParse(txtRelationUnit.Text, out decimal relationUnit) ||
                !decimal.TryParse(txtCostMain.Text, out decimal costPricePrimaryUnit) ||
                !decimal.TryParse(txtPriceMain.Text, out decimal pricePrimaryUnit) ||
                !decimal.TryParse(txtCostSec.Text, out decimal costPriceSecondaryUnit) ||
                !decimal.TryParse(txtpriceSec.Text, out decimal priceSecondaryUnit))
            {
                return;
            }
            var productId = await _productService.GenerateProductIdAsync();
            _mainStoreTb = new MainStoreTb
            {

                ProductId = productId,
                ProductName = txtProductName.Text,
                RemainingStockPrimaryUnit = remainingStockPrimaryUnit,
                PrimaryUnit = txtMainUnit.Text,
                RemainingStockSecondaryUnit = remainingStockSecondaryUnit,
                SecondaryUnit = txtSecUnit.Text,
                RelationUnit = relationUnit,
                CostPricePrimaryUnit = costPricePrimaryUnit,
                PricePrimaryUnit = pricePrimaryUnit,
                CostPriceSecondaryUnit = costPriceSecondaryUnit,
                PriceSecondaryUnit = priceSecondaryUnit,
                UnitPrice = txtMoney.Text,

            };
        }

        private void PopulateTextboxesFromRow(int rowIndex)
        {
            var row = dvgProduction.Rows[rowIndex];
            textBoxIdprocess.Text = row.Cells["ProductId"].Value.ToString();
            textBoxproductNameP.Text = row.Cells["ProductName"].Value.ToString();
            txtProductName.Text = row.Cells["ProductName"].Value.ToString();
            txtMainRemaining.Text = row.Cells["RemainingStockPrimaryUnit"].Value.ToString();
            txtMainUnit.Text = row.Cells["PrimaryUnit"].Value.ToString();
            txtSecRemaing.Text = row.Cells["RemainingStockSecondaryUnit"].Value.ToString();
            txtSecUnit.Text = row.Cells["SecondaryUnit"].Value.ToString();
            txtRelationUnit.Text = row.Cells["RelationUnit"].Value.ToString();
            txtCostMain.Text = row.Cells["CostPricePrimaryUnit"].Value.ToString();
            txtPriceMain.Text = row.Cells["PricePrimaryUnit"].Value.ToString();
            txtCostSec.Text = row.Cells["CostPriceSecondaryUnit"].Value.ToString();
            txtpriceSec.Text = row.Cells["PriceSecondaryUnit"].Value.ToString();
            txtMoney.Text = row.Cells["UnitPrice"].Value.ToString();

        }


        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = true;

            // Styling for a more modern look
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.Gainsboro;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Column Header Default Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34); // Dark background for headers
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // White text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Modern font for headers
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Default cell style
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightGray; // Color when a cell is selected
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[0].HeaderText = "รหัสสินค้า";
            dgv.Columns[1].HeaderText = "ชื่อสินค้า";
            dgv.Columns[2].HeaderText = "คงเหลือหลัก";
            dgv.Columns[3].HeaderText = "หน่วยหลัก";
            dgv.Columns[4].HeaderText = "คงเหลือรอง";
            dgv.Columns[5].HeaderText = "หน่วยรอง";
            dgv.Columns[6].HeaderText = "หน่วยสัมพันธ์";
            dgv.Columns[7].HeaderText = "ราคาทุนหลัก";
            dgv.Columns[8].HeaderText = "ราคาขายหลัก";
            dgv.Columns[9].HeaderText = "ราคาทุนรอง";
            dgv.Columns[10].HeaderText = "ราคาขายรอง";
            dgv.Columns[11].HeaderText = "หน่วยเงิน";



            // Row Headers Visibility
            dgv.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ConfigureDataGridViewHisRecord(DataGridView dgv)
        {
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = true;

            // Modern look with a white and gray tone
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray; // Subtle grid color
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Column Header Default Style
            Color columnHeaderColor = Color.FromArgb(240, 240, 240);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = columnHeaderColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray; // Dim gray text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Default cell style
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke; // Slightly off-white for the cells for better readability
            dgv.DefaultCellStyle.ForeColor = Color.DimGray; // Use a soft color for text to reduce contrast intensity
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(202, 222, 241); // Light blue for selection
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alternating rows with a very subtle gray to maintain readability without sacrificing the white theme
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.DimGray;

            // Turn off visual styles for headers to ensure our custom styles are applied
            dgv.EnableHeadersVisualStyles = false;

            dgv.Columns[0].HeaderText = "รหัสทำรายการ";
            dgv.Columns[1].HeaderText = "รหัสสินค้า";
            dgv.Columns[2].HeaderText = "ชื่อสินค้า";
            dgv.Columns[3].HeaderText = "ประเภท"; // Increase // Decrease 
            dgv.Columns[4].HeaderText = "จำนวน";
            dgv.Columns[5].HeaderText = "หน่วย";
            dgv.Columns[6].HeaderText = "จำนวนคงเหลือใหม่";
            dgv.Columns[7].HeaderText = "ข้อมูลเพิ่มเติม";
            dgv.Columns[8].HeaderText = "วันที่ทำรายการ";

            dgv.RowHeadersVisible = false;
            // Apply row style
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.CellFormatting += dgv_CellFormatting;
        }

        private void dgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;

                // Retrieve the value in the third column of the current row
                string value = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                // Use more modern, subtle colors for Increase and Decrease
                Color increaseColor = Color.FromArgb(235, 245, 251); // A very light blue
                Color decreaseColor = Color.FromArgb(251, 235, 235); // A very light red

                // Check the value and set the row's DefaultCellStyle.BackColor accordingly
                if (value == "Increase")
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = increaseColor;
                }
                else if (value == "Decrease")
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = decreaseColor;
                }
                // Apply a default color if needed, but for a white theme, it might be best to leave it as is
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                await InitializeMainStoreRecord();
                await _productService.AddNewProductAsync(_mainStoreTb);
                await LoadProductsAsync();
                clearForm();
                Logger.LogMethod.LogAction($"User added {_mainStoreTb.ProductName} to the database.");
            }
            catch (Exception ex)
            {
                Logger.LogMethod.LogError(ex);
                MessageBox.Show($"Failed to add product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void dvgProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgProduction.Rows[e.RowIndex];
                if (row.Cells["ProductId"].Value == null)
                {
                    MessageBox.Show("Product ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    PopulateTextboxesFromRow(e.RowIndex);

                    _productId = int.TryParse(row.Cells["ProductId"].Value.ToString(), out var id) ? id : 0;
                    if (_productId == 0)
                    {
                        MessageBox.Show("Invalid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var result = await _productService.GetUnitTypesAsync(_productId);
                    var filter = result.Where(rec => !string.IsNullOrEmpty(rec.Unit) && !string.IsNullOrEmpty(rec.UnitType));

                    _productUnitType = new Dictionary<string, string>();
                    foreach (var r in filter)
                    {
                        if (!_productUnitType.ContainsKey(r.Unit))
                        {
                            _productUnitType.Add(r.Unit, r.UnitType);
                        }
                    }

                    comboBoxUnit.DataSource = new List<string>(_productUnitType.Keys);

                }
                catch (Exception ex)
                {
                    Logger.LogMethod.LogError(ex);
                    MessageBox.Show($"Failed to select product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                clearForm(); // Ensure this method clears the form correctly and resets any used variables
            }
        }


        private async void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                await _productService.RemoveProductAsync(_productId);
                await LoadProductsAsync();
                clearForm();
                Logger.LogMethod.LogAction($"User removed product ID {_productId} from the database.");
            }
            catch (Exception ex)
            {
                Logger.LogMethod.LogError(ex);
                MessageBox.Show($"Failed to remove product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                await InitializeMainStoreRecord();
                await _productService.EditProductAsync(_productId, _mainStoreTb);
                await LoadProductsAsync();
                clearForm();
                Logger.LogMethod.LogAction($"User edited product ID {_productId}.");
            }
            catch (Exception ex)
            {
                Logger.LogMethod.LogError(ex);
                MessageBox.Show($"Failed to edit product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
            Logger.LogMethod.LogAction("User cleared the form.");
        }
        private void clearForm()
        {
            _productId = 0;
            textBoxIdprocess.Text = null;
            textBoxproductNameP.Text = null;
            txtProductName.Text = null;
            txtMainRemaining.Text = null;
            txtMainUnit.Text = null;
            txtSecRemaing.Text = null;
            txtSecUnit.Text = null;
            txtRelationUnit.Text = null;
            txtCostMain.Text = null;
            txtPriceMain.Text = null;
            txtCostSec.Text = null;
            txtpriceSec.Text = null;
            txtMoney.Text = null;
            textBoxdetail.Text = null;
            textBoxQuantity.Text = null;
            textBoxNewQueantity.Text = null;
        }
        private void txtMainRemaining_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMainRemaining.Text, out decimal mainRemaining) &&
                decimal.TryParse(txtRelationUnit.Text, out decimal relationUnit))
            {
                decimal secRemaining = relationUnit * mainRemaining;
                txtSecRemaing.Text = secRemaining.ToString();
            }

        }

        private async void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(textBoxQuantity.Text) && !string.IsNullOrEmpty(textBoxIdprocess.Text))
            {
                // Try to parse the quantity text to a decimal
                if (decimal.TryParse(textBoxQuantity.Text, out decimal quantityChange))
                {
                    if (cbIncraseDecrease.Text == Increase)
                    {
                        var typeOfUnit = _productUnitType[comboBoxUnit.Text];
                        var result = await _productService.GetAmountStockProduct(_productId, typeOfUnit);
                        decimal newQuantity = result + quantityChange;
                        textBoxNewQueantity.Text = newQuantity.ToString();
                    }
                    else if (cbIncraseDecrease.Text == Decrease)
                    {

                        var typeOfUnit = _productUnitType[comboBoxUnit.Text];
                        var result = await _productService.GetAmountStockProduct(_productId, typeOfUnit);
                        if (result != 0)
                        {
                            decimal newQuantity = result - quantityChange;
                            textBoxNewQueantity.Text = newQuantity.ToString();
                        }

                    }

                }
                else
                {
                    var typeOfUnit = _productUnitType[comboBoxUnit.Text];
                    var result = await _productService.GetAmountStockProduct(_productId, typeOfUnit);
                    textBoxNewQueantity.Text = result.ToString();
                }
            }
            else
            {
                // If either textBoxQuantity or textBoxIdprocess is empty, fetch the current stock amount without adding any quantity
                var typeOfUnit = _productUnitType[comboBoxUnit.Text];
                var result = await _productService.GetAmountStockProduct(_productId, typeOfUnit);
                textBoxNewQueantity.Text = result.ToString();
            }

        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxQuantity.Text) || string.IsNullOrEmpty(textBoxIdprocess.Text))
            {
                MessageBox.Show("Please ensure all fields are filled out.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask user for confirmation before proceeding
            var confirmationResult = MessageBox.Show("Are you sure you want to proceed with the stock change?", "Confirm Stock Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    string UnitType = _productUnitType[comboBoxUnit.Text];
                    string ChangeType = cbIncraseDecrease.Text;
                    decimal quantityChange = decimal.Parse(textBoxQuantity.Text);
                    string historyStock = await GenerateRecId.GenerateId();
                    string reason = $"{ChangeType}|{UnitType}|{textBoxdetail.Text}";
                    decimal newQuantity = decimal.Parse(textBoxNewQueantity.Text);

                    await ProcessStockChange(UnitType, quantityChange, newQuantity, reason, historyStock, ChangeType);
                    await LoadhistoricalRecordAsync();
                    await LoadProductsAsync();
                    clearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // User chose not to proceed
                MessageBox.Show("Stock change process was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task ProcessStockChange(string UnitType, decimal quantityChange, decimal newQuantity, string reason, string historyStock, string ChangeType)
        {
            try
            {
                // Log the start of the operation
                Logger.LogMethod.LogAction($"ProcessStockChange initiated. Product ID: {_productId}, Change Type: {ChangeType}, Unit Type: {UnitType}, Quantity Change: {quantityChange}, New Quantity: {newQuantity}, Reason: {reason}");

                if (ChangeType == Increase)
                {
                    await _productService.IncreaseStockAmountAsync(_productId, UnitType, quantityChange);
                    // Log successful increase
                    Logger.LogMethod.LogAction($"Stock increased for Product ID: {_productId}. Quantity Change: {quantityChange}");
                }
                else if (ChangeType == Decrease)
                {
                    await _productService.DecreaseStockAmountAsync(_productId, UnitType, quantityChange);
                    // Log successful decrease
                    Logger.LogMethod.LogAction($"Stock decreased for Product ID: {_productId}. Quantity Change: {quantityChange}");
                }
                else
                {
                    // Log unexpected ChangeType
                    Logger.LogMethod.LogAction($"Unexpected ChangeType encountered: {ChangeType}");
                    return;
                }

                await _stockHistoryService.InsertLogAsync(
                    historyStock,
                    _productId,
                    ChangeType,
                    quantityChange,
                    comboBoxUnit.Text, // Ensure this access is thread-safe if needed
                    newQuantity,
                    reason);

                // Log the completion of the stock change process
                Logger.LogMethod.LogAction($"ProcessStockChange completed for Product ID: {_productId}. Change Type: {ChangeType}, Final Quantity: {newQuantity}");
            }
            catch (Exception ex)
            {
                // Log any exceptions that occur during the process
                Logger.LogMethod.LogError(ex);
                // Depending on your error handling strategy, you might handle the exception here
            }
        }

        private async void txtSearchingProduct_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchingProduct.Text))
            {
                await LoadProductsAsync();
            }
            else
            {
                var result = await _productService.SearchProductByNameAsync(txtSearchingProduct.Text);
                if (result.Any())
                {
                    dvgProduction.DataSource = result;
                }
                else
                {
                    await LoadProductsAsync();
                }
            }
        }

        private async void txtSearchingRecord_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchingRecord.Text))
            {
                await LoadhistoricalRecordAsync();
            }
            else
            {
                var result = await _stockHistoryService.SearchStockHistoryRecordsAsync(txtSearchingRecord.Text, null, null);
                if (result.Any())
                {
                    dgvhistoricalrecord.DataSource = result;
                }
                else
                {
                    await LoadhistoricalRecordAsync();
                }
            }
        }

        private void btnDownloadStock_Click(object sender, EventArgs e)
        {
            try
            {
                using FolderBrowserDialog browserDialog = new FolderBrowserDialog();
                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = "Listproducts" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
                    string filePath = Path.Combine(browserDialog.SelectedPath, filename);
                    DataGridViewExtensions.SaveAsCsv(dvgProduction, filePath);
                    MessageBox.Show($"Data exported successfully to {filePath}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to export data. Error: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDownloadRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using FolderBrowserDialog browserDialog = new FolderBrowserDialog();
                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = "RecordList" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
                    string filePath = Path.Combine(browserDialog.SelectedPath, filename);
                    DataGridViewExtensions.SaveAsCsv(dgvhistoricalrecord, filePath);
                    MessageBox.Show($"Data exported successfully to {filePath}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to export data. Error: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
