using StoreManagement.Controller;
using System.ComponentModel;

namespace StoreManagement.View
{
    public partial class UserControlCheckStock : UserControl
    {

        #region Instance Variable 
        ICarEnrollService _carEnrollService;
        ICarProductTransactionService _carProductTransactionService;
        CarProductTransaction _carProductTransaction;
        public static event EventHandler UpdateProduct;
        string _selectedCarId;
        string Id;

        #endregion
        public UserControlCheckStock()
        {

            InitializeComponent();
            _carEnrollService = new CarEnrollService(new SqlDataAccessInternal(new XmlAccess()));
            _carProductTransactionService = new CarProductTransactionService(new SqlDataAccessInternal(new XmlAccess()));
            UserControlSetting.CarAdded += OtherUserControl_CarAdded;
        }
        protected virtual void OnUpdateProduct()
        {
            UpdateProduct?.Invoke(this, EventArgs.Empty);
        }
        private void UserControlCheckStock_Unload(object sender, EventArgs e)
        {
            UserControlSetting.CarAdded -= OtherUserControl_CarAdded;
        }

        private async void OtherUserControl_CarAdded(object sender, EventArgs e)
        {
            await LoadCarsDetailsAsync();
        }

        private async void UserControlCheckStock_Load(object sender, EventArgs e)
        {

            await LoadCarsDetailsAsync();
            ConfigureDataGridView(dgvCars);
            var result = await _carProductTransactionService.GetTransactionSummariesAsync();
            dgvSaleRecord.DataSource = result;
            ConfigureDataGridViewSummary(dgvSaleRecord);
            LoadGridViewRecordAsync();
            txtActualMoney.Text = "0";
            txtCarMoney.Text = "0";
            txtDiffMoney.Text = "0";


        }

        #region Initial Set up  

        private void LoadGridViewRecordAsync()
        {


            var bindingList = new BindingList<GenerateCarProductTransactionForm>();
            var source = new BindingSource(bindingList, null);
            dgvdailyRecord.DataSource = source;
            dgvdailyRecord.Refresh();
            ConfigureDataGridViewDaily(dgvdailyRecord);
            //MessageBox.Show("No record available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
        #endregion

        #region Configuration
        private async Task LoadCarsDetailsAsync()
        {
            try
            {
                var products = await _carEnrollService.GetCarDetailsAsync();
                if (products.Any())
                {
                    dgvCars.DataSource = products;
                    dgvCars.Refresh();
                }
                else
                {
                    var bindingList = new BindingList<CarDetail>();
                    var source = new BindingSource(bindingList, null);
                    dgvCars.DataSource = source;
                    dgvCars.Refresh();

                }
            }
            catch (Exception ex)
            {
                Logger.LogMethod.LogError(ex);
                MessageBox.Show("Failed to load Cars Detail. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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



            dgv.Columns[0].HeaderText = "ทะเบียนรถยนต์";
            dgv.Columns[1].HeaderText = "ยี่ห้อรถยนต์";
            dgv.Columns[2].HeaderText = "ปี";
            dgv.Columns[3].HeaderText = "วันลงทะเบียน";
            dgv.Columns[4].HeaderText = "วันทำการ";

            dgv.Columns[2].Visible = false;


            // Row Headers Visibility
            dgv.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ConfigureDataGridViewSummary(DataGridView dgv)
        {
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = true;

            // Styling for a lighter, more vibrant look
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray; // Lighter grid lines
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Column Header Default Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue; // Lighter, vibrant background for headers
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray; // Dark text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Modern font for headers
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Default cell style
            dgv.DefaultCellStyle.BackColor = Color.Azure; // A lighter background for cells
            dgv.DefaultCellStyle.ForeColor = Color.DarkSlateGray; // Dark text for readability
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue; // A vibrant color when a cell is selected
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Setting column headers text
            dgv.Columns[0].HeaderText = "ทรานแซคชั่น";
            dgv.Columns[1].HeaderText = "ยี่ห้อ";
            dgv.Columns[2].HeaderText = "วันที่";
            dgv.Columns[3].HeaderText = "สินค้าทั้งหมด";
            dgv.Columns[4].HeaderText = "เงินราคาต้นทุน";
            dgv.Columns[5].HeaderText = "เงินราคาขาย";
            dgv.Columns[6].HeaderText = "เงินสด";
            dgv.Columns[7].HeaderText = "ขาด-เกิน"; // It can be a nagetive decimal and positive decimal
            dgv.Columns[3].Visible = false;
            // Row Headers Visibility
            dgv.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.CellFormatting += Dgv_CellFormatting;
        }

        private void ConfigureDataGridViewDaily(DataGridView dgv)
        {
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.ReadOnly = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = true;

            // Styling for a lighter, more vibrant look
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray; // Lighter grid lines
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Column Header Default Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue; // Lighter, vibrant background for headers
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray; // Dark text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Modern font for headers
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Default cell style
            dgv.DefaultCellStyle.BackColor = Color.Azure; // A lighter background for cells
            dgv.DefaultCellStyle.ForeColor = Color.DarkSlateGray; // Dark text for readability
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue; // A vibrant color when a cell is selected
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Setting column headers text
            dgv.Columns[0].HeaderText = "ทรานแซคชั่น";
            dgv.Columns[1].HeaderText = "ชื่อสินค้า";
            dgv.Columns[2].HeaderText = "หน่วย(หลัก)";
            dgv.Columns[3].HeaderText = "หน่วย(รอง)";
            dgv.Columns[4].HeaderText = "เอาไป(หลัก)";
            dgv.Columns[5].HeaderText = "เหลือ(หลัก)";
            dgv.Columns[6].HeaderText = "เอาไป(รอง)";
            dgv.Columns[7].HeaderText = "เหลือ(รอง)"; // It can be a nagetive decimal and positive decimal
            dgv.Columns[8].HeaderText = "ขาย(หลัก)";
            dgv.Columns[9].HeaderText = "ขาย(รอง)";
            dgv.Columns[10].HeaderText = "ราคาต้นทุนหลัก";
            dgv.Columns[11].HeaderText = "ราคาขายหลัก";
            dgv.Columns[12].HeaderText = "ราคาต้นทุนรอง"; // It can be a nagetive decimal and positive decimal
            dgv.Columns[13].HeaderText = "ราคาขายรอง"; // It can be a nagetive decimal and positive decimal
            // Row Headers Visibility
            dgv.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void Dgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0) // Targeting the "ขาด-เกิน" column
            {
                var dgv = sender as DataGridView;
                if (dgv is null) return;

                if (decimal.TryParse(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out decimal value))
                {
                    if (value < 0)
                    {
                        // Soft Peach for negative values
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 218, 185); // Peach color
                        dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkSlateGray; // Ensures text is readable
                    }
                    else
                    {
                        // Soft Blue for positive values
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(173, 216, 230); // LightBlue color
                        dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkSlateGray; // Ensures text is readable
                    }
                }
            }
        }




        #endregion

        private async void btnProcess_Click(object sender, EventArgs e)
        {

            try
            {
                // Validate selection
                if (string.IsNullOrEmpty(_selectedCarId))
                {
                    MessageBox.Show("Please select a car from the table!");
                    return;
                }

                // Generate transactions for the selected car and update UI
                await UpdateDailyRecordDataSourceAsync();
                // Process any necessary operations post data generation
                await ProcessAfterDataGenerationAsync();
                // Fetch and display updated transaction summaries
                await UpdateSaleRecordDataSourceAsync();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task UpdateDailyRecordDataSourceAsync()
        {
            var transactions = await _carProductTransactionService.GenerateCarProductTransactionsAsync(_selectedCarId);
            dgvdailyRecord.DataSource = transactions;
        }

        private async Task ProcessAfterDataGenerationAsync()
        {
            await ProcessSaveDataGridViewRows(); // Assuming this processes rows in some way
            await _carProductTransactionService.GenerateSummaryTrasaction();
        }

        private async Task UpdateSaleRecordDataSourceAsync()
        {
            var summaries = await _carProductTransactionService.GetTransactionSummariesAsync();
            dgvSaleRecord.DataSource = summaries;
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];


                if (row.Cells["CarID"].Value != null)
                {
                    _selectedCarId = row.Cells["CarID"].Value.ToString();

                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtCarMoney.Text, out decimal carMoney))
                {
                    MessageBox.Show("Invalid money input. Please enter a valid number.");
                    return;
                }

                await ProcessUpdateDataGridViewRows();
                await UpdateDataSummaryAsync(carMoney);
                dgvSaleRecord.DataSource = await FetchUpdatedTransactionSummariesAsync();
                OnUpdateProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task UpdateDataSummaryAsync(decimal carMoney)
        {
            await _carProductTransactionService.EditdataSummaryAsync(Id, carMoney);
            await _carProductTransactionService.GenerateSummaryTrasaction();
            await _carProductTransactionService.UpdatedataSummaryAsync();
        }

        private async Task<IEnumerable<CarProductTransactionSummary>> FetchUpdatedTransactionSummariesAsync()
        {
            return await _carProductTransactionService.GetTransactionSummariesAsync();
        }

        public async Task ProcessSaveDataGridViewRows()
        {
            if (dgvdailyRecord != null)
            {
                foreach (DataGridViewRow row in dgvdailyRecord.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        _carProductTransaction = CreateCarProductTransactionFromRow(row);


                    }
                    await _carProductTransactionService.SaveCarProductTransactionsAsync(_carProductTransaction);
                }
                OnUpdateProduct();
            }
        }
        private CarProductTransaction CreateCarProductTransactionFromRow(DataGridViewRow row)
        {
            return new CarProductTransaction
            {
                CarId = _selectedCarId,
                TransactionId = row.Cells["TransactionId"].Value?.ToString() ?? string.Empty,
                TakeQuantityPrimaryUnit = GetNullableDecimal(row.Cells["TakeQuantityPrimaryUnit"].Value),
                ReturnQuantityPrimaryUnit = GetNullableDecimal(row.Cells["ReturnQuantityPrimaryUnit"].Value),
                TakeQuantitySecondaryUnit = GetNullableDecimal(row.Cells["TakeQuantitySecondaryUnit"].Value),
                ReturnQuantitySecondaryUnit = GetNullableDecimal(row.Cells["ReturnQuantitySecondaryUnit"].Value),
                SalePrimaryUnit = GetNullableDecimal(row.Cells["SalePrimaryUnit"].Value),
                SaleSecondaryUnit = GetNullableDecimal(row.Cells["SaleSecondaryUnit"].Value),
                TransactionDate = DateTime.Today,
                CostPricePrimaryUnit = GetNullableDecimal(row.Cells["CostPricePrimaryUnit"].Value),
                PricePrimaryUnit = GetNullableDecimal(row.Cells["PricePrimaryUnit"].Value),
                CostPriceSecondaryUnit = GetNullableDecimal(row.Cells["CostPriceSecondaryUnit"].Value),
                PriceSecondaryUnit = GetNullableDecimal(row.Cells["PriceSecondaryUnit"].Value),
            };
        }
        public async Task ProcessUpdateDataGridViewRows()
        {
            if (dgvdailyRecord != null)
            {
                foreach (DataGridViewRow row in dgvdailyRecord.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        _carProductTransaction = CreateCarProductTransactionFromRow(row);

                    }
                    await _carProductTransactionService.UpdatedataCarProductTransactionsEdit(_carProductTransaction);
                }
            }
        }

        private decimal? GetNullableDecimal(object value)
        {
            return value != DBNull.Value ? Convert.ToDecimal(value) : (decimal?)null;
        }

        private async void dgvSaleRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSaleRecord.Rows[e.RowIndex];


                if (row.Cells["Id"].Value != null)
                {
                    Id = row.Cells["Id"].Value.ToString();

                    var result = await _carProductTransactionService.GenerateCarProductTransactionsByID(Id);
                    dgvdailyRecord.DataSource = result;

                    if (Id.Length > 8)
                    {
                        _selectedCarId = Id.Substring(0, Id.Length - 8);

                    }
                    txtCarId.Text = _selectedCarId;
                    txtCarMoney.Text = row.Cells["MoneyFromCar"].Value.ToString();

                    txtActualMoney.Text = LogicBusiness.CalculateActualMoney(dgvdailyRecord)[0].ToString("0.##");
                    txtCostMoney.Text = LogicBusiness.CalculateActualMoney(dgvdailyRecord)[1].ToString("0.##");
                    txtDiffMoney.Text = row.Cells["DifferenceMoney"].Value.ToString();


                }
            }
        }

        private void dgvdailyRecord_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                decimal actualMoney = LogicBusiness.CalculateActualMoney(dgvdailyRecord)[0];
                decimal CostMoney = LogicBusiness.CalculateActualMoney(dgvdailyRecord)[1];
                txtCostMoney.Text = CostMoney.ToString("0.##");
                txtActualMoney.Text = actualMoney.ToString("0.##");


                LogicBusiness.UpdateRows(e.RowIndex, dgvdailyRecord);


                if (decimal.TryParse(txtCarMoney.Text, out decimal carMoney) &&
                    decimal.TryParse(txtActualMoney.Text, out decimal actualMoneyValue))
                {
                    decimal diffMoney = LogicBusiness.DiffMoney(carMoney, actualMoneyValue);
                    txtDiffMoney.Text = diffMoney.ToString("0.##");
                }
                else
                {

                    txtDiffMoney.Text = "Invalid input";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dgvdailyRecord_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            LogicBusiness.UpdateRows(e.RowIndex, dgvdailyRecord);
        }

        private void txtCarMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {

                decimal actualMoney = LogicBusiness.CalculateActualMoney(dgvdailyRecord)[0];
                txtActualMoney.Text = actualMoney.ToString("0.##");

                if (decimal.TryParse(txtCarMoney.Text, out decimal carMoney) &&
                    decimal.TryParse(txtActualMoney.Text, out decimal actualMoneyValue))
                {
                    decimal diffMoney = LogicBusiness.DiffMoney(carMoney, actualMoneyValue);
                    txtDiffMoney.Text = diffMoney.ToString("0.##");
                }
                else
                {

                    txtDiffMoney.Text = "Invalid input";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure you want to update the main store?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                await _carProductTransactionService.UpdateMainStoreAsync();
                OnUpdateProduct();
                MessageBox.Show("Main store updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Update operation cancelled.", "Update Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDownloadSaleRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using FolderBrowserDialog browserDialog = new FolderBrowserDialog();
                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = "SaleRecord" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
                    string filePath = Path.Combine(browserDialog.SelectedPath, filename);
                    DataGridViewExtensions.SaveAsCsv(dgvSaleRecord, filePath);
                    MessageBox.Show($"Data exported successfully to {filePath}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to export data. Error: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndownload_Click(object sender, EventArgs e)
        {
            try
            {
                using FolderBrowserDialog browserDialog = new FolderBrowserDialog();
                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = "SaleDailyRecord" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
                    string filePath = Path.Combine(browserDialog.SelectedPath, filename);
                    DataGridViewExtensions.SaveAsCsv(dgvdailyRecord, filePath);
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
