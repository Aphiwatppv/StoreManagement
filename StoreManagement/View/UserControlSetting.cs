using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.View
{
    public partial class UserControlSetting : UserControl
    {
        ICarEnrollService _carEnrollService;
        DetailCarsEnroll _detailCarsEnroll;
        public static event EventHandler CarAdded;
        string? CarId;
        public UserControlSetting()
        {
            InitializeComponent();
            _carEnrollService = new CarEnrollService(new SqlDataAccessInternal(new XmlAccess()));
        }

        #region Configuration 

        protected virtual void OnCarAdded()
        {
            CarAdded?.Invoke(this, EventArgs.Empty);
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




            // Row Headers Visibility
            dgv.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

  




        private void PopulateTextboxesFromRow(int rowIndex)
        {
            var row = dgvCarsDetail.Rows[rowIndex];
            txtCarId.Text = row.Cells["CarID"].Value.ToString();
            txtCarModel.Text = row.Cells["Model"].Value.ToString();
            txtCarYear.Text = row.Cells["Year"].Value.ToString();


        }

        private void clearForm()
        {
            txtCarId.Text = null;
            txtCarModel.Text = null;
            txtCarYear.Text = null;

        }
        #endregion

        #region Initial Set up
        private async Task LoadCarsDetailsAsync()
        {
            try
            {
                var products = await _carEnrollService.GetCarDetailsAsync();
                if (products.Any())
                {
                    dgvCarsDetail.DataSource = products;
                    dgvCarsDetail.Refresh();
                }
                else
                {
                    var bindingList = new BindingList<CarDetail>();
                    var source = new BindingSource(bindingList, null);
                    dgvCarsDetail.DataSource = source;
                    dgvCarsDetail.Refresh();
                    // MessageBox.Show("No Cars available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.LogMethod.LogError(ex);
                MessageBox.Show("Failed to load Cars Detail. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeCarDetail()
        {

            if (!int.TryParse(txtCarYear.Text, out int carYear))
            {
                MessageBox.Show("Please enter a valid year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCarYear.Focus();
                return;
            }

            _detailCarsEnroll = new DetailCarsEnroll
            {
                CarID = txtCarId.Text,
                Model = txtCarModel.Text,
                Year = carYear,
            };
        }
        #endregion

        private async void UserControlSetting_Load(object sender, EventArgs e)
        {
            await LoadCarsDetailsAsync();
            ConfigureDataGridView(dgvCarsDetail);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarId.Text) || string.IsNullOrEmpty(txtCarModel.Text) || string.IsNullOrEmpty(txtCarYear.Text))
            {
                MessageBox.Show("Please fill in all fields before enrolling the car.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var result = MessageBox.Show("Are you sure you want to enroll this car?", "Confirm Enrollment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                InitializeCarDetail();


                await _carEnrollService.AddCarAsync(_detailCarsEnroll);
                await LoadCarsDetailsAsync();
                clearForm();
                OnCarAdded();
                MessageBox.Show("Car has been successfully enrolled.", "Enrollment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                await LoadCarsDetailsAsync();
            }

        }

        private void dgvCarsDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCarsDetail.Rows[e.RowIndex];
                if (row.Cells["CarID"].Value == null)
                {
                    MessageBox.Show("Car ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CarId = row.Cells["CarID"].Value.ToString();
                try
                {
                    PopulateTextboxesFromRow(e.RowIndex);
                }
                catch (Exception ex)
                {
                    Logger.LogMethod.LogError(ex);
                    MessageBox.Show($"Failed to select cars detail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                clearForm();
            }
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Are you sure you want to remove this car?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                await _carEnrollService.RemoveCarAsync(CarId);
                await LoadCarsDetailsAsync();
                clearForm();
                OnCarAdded();
            }

        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(CarId) || string.IsNullOrEmpty(txtCarModel.Text) || !int.TryParse(txtCarYear.Text, out int carYear))
            {
                MessageBox.Show("Please ensure all fields are correctly filled and the year is valid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            var confirmationResult = MessageBox.Show("Are you sure you want to edit this car?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    await _carEnrollService.EditCarAsync(CarId, txtCarModel.Text, carYear);
                    await LoadCarsDetailsAsync();
                    clearForm();
                    OnCarAdded();
                    MessageBox.Show("Car details successfully updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating car details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
