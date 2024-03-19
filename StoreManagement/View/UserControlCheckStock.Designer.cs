namespace StoreManagement.View
{
    partial class UserControlCheckStock
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelBotton = new Panel();
            panelLeft = new Panel();
            panelTop = new Panel();
            panelMainDisplay = new Panel();
            btnDownloadSaleRecord = new Button();
            panel2 = new Panel();
            btndownload = new Button();
            btnUpdate = new Button();
            label5 = new Label();
            txtCostMoney = new TextBox();
            label2 = new Label();
            txtDiffMoney = new TextBox();
            txtCarMoney = new TextBox();
            txtActualMoney = new TextBox();
            txtCarId = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvdailyRecord = new DataGridView();
            btnSave = new Button();
            label1 = new Label();
            btnProcess = new Button();
            dgvSaleRecord = new DataGridView();
            label17 = new Label();
            dgvCars = new DataGridView();
            panelMainDisplay.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdailyRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 77, 77);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1580, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(20, 760);
            panel1.TabIndex = 7;
            // 
            // panelBotton
            // 
            panelBotton.BackColor = Color.FromArgb(77, 77, 77);
            panelBotton.Dock = DockStyle.Bottom;
            panelBotton.Location = new Point(20, 780);
            panelBotton.Name = "panelBotton";
            panelBotton.Size = new Size(1580, 20);
            panelBotton.TabIndex = 6;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(77, 77, 77);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 20);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(20, 780);
            panelLeft.TabIndex = 5;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(77, 77, 77);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1600, 20);
            panelTop.TabIndex = 4;
            // 
            // panelMainDisplay
            // 
            panelMainDisplay.BackColor = Color.White;
            panelMainDisplay.Controls.Add(btnDownloadSaleRecord);
            panelMainDisplay.Controls.Add(panel2);
            panelMainDisplay.Controls.Add(label1);
            panelMainDisplay.Controls.Add(btnProcess);
            panelMainDisplay.Controls.Add(dgvSaleRecord);
            panelMainDisplay.Controls.Add(label17);
            panelMainDisplay.Controls.Add(dgvCars);
            panelMainDisplay.Dock = DockStyle.Fill;
            panelMainDisplay.Location = new Point(20, 20);
            panelMainDisplay.Name = "panelMainDisplay";
            panelMainDisplay.Size = new Size(1560, 760);
            panelMainDisplay.TabIndex = 8;
            // 
            // btnDownloadSaleRecord
            // 
            btnDownloadSaleRecord.BackColor = Color.FromArgb(192, 192, 255);
            btnDownloadSaleRecord.FlatStyle = FlatStyle.Flat;
            btnDownloadSaleRecord.Font = new Font("Segoe UI", 13F);
            btnDownloadSaleRecord.ForeColor = Color.Black;
            btnDownloadSaleRecord.Location = new Point(1342, 3);
            btnDownloadSaleRecord.Name = "btnDownloadSaleRecord";
            btnDownloadSaleRecord.Size = new Size(212, 33);
            btnDownloadSaleRecord.TabIndex = 34;
            btnDownloadSaleRecord.Text = "ดาวน์โหลดบันทึกการขาย";
            btnDownloadSaleRecord.UseVisualStyleBackColor = false;
            btnDownloadSaleRecord.Click += btnDownloadSaleRecord_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 47, 47);
            panel2.Controls.Add(btndownload);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtCostMoney);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtDiffMoney);
            panel2.Controls.Add(txtCarMoney);
            panel2.Controls.Add(txtActualMoney);
            panel2.Controls.Add(txtCarId);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dgvdailyRecord);
            panel2.Controls.Add(btnSave);
            panel2.Location = new Point(19, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(1533, 549);
            panel2.TabIndex = 33;
            // 
            // btndownload
            // 
            btndownload.BackColor = Color.FromArgb(255, 192, 192);
            btndownload.FlatStyle = FlatStyle.Flat;
            btndownload.Font = new Font("Segoe UI", 13F);
            btndownload.ForeColor = Color.Black;
            btndownload.Location = new Point(141, 491);
            btndownload.Name = "btndownload";
            btndownload.Size = new Size(247, 40);
            btndownload.TabIndex = 45;
            btndownload.Text = "ดาวน์โหลดบันทึกการขายรายวัน";
            btndownload.UseVisualStyleBackColor = false;
            btndownload.Click += btndownload_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(1206, 491);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(315, 40);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "อัพเดตคลังสินค้า";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(294, 11);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 43;
            label5.Text = "ต้นทุน";
            // 
            // txtCostMoney
            // 
            txtCostMoney.Font = new Font("Segoe UI", 12F);
            txtCostMoney.ForeColor = Color.FromArgb(47, 47, 47);
            txtCostMoney.Location = new Point(348, 3);
            txtCostMoney.Name = "txtCostMoney";
            txtCostMoney.Size = new Size(104, 29);
            txtCostMoney.TabIndex = 42;
            txtCostMoney.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(469, 11);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 41;
            label2.Text = "ยอดเงิน";
            // 
            // txtDiffMoney
            // 
            txtDiffMoney.Font = new Font("Segoe UI", 12F);
            txtDiffMoney.ForeColor = Color.FromArgb(47, 47, 47);
            txtDiffMoney.Location = new Point(934, 3);
            txtDiffMoney.Name = "txtDiffMoney";
            txtDiffMoney.Size = new Size(173, 29);
            txtDiffMoney.TabIndex = 40;
            txtDiffMoney.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCarMoney
            // 
            txtCarMoney.Font = new Font("Segoe UI", 12F);
            txtCarMoney.ForeColor = Color.FromArgb(47, 47, 47);
            txtCarMoney.Location = new Point(731, 3);
            txtCarMoney.Name = "txtCarMoney";
            txtCarMoney.Size = new Size(111, 29);
            txtCarMoney.TabIndex = 39;
            txtCarMoney.TextAlign = HorizontalAlignment.Center;
            txtCarMoney.TextChanged += txtCarMoney_TextChanged;
            // 
            // txtActualMoney
            // 
            txtActualMoney.Font = new Font("Segoe UI", 12F);
            txtActualMoney.ForeColor = Color.FromArgb(47, 47, 47);
            txtActualMoney.Location = new Point(530, 3);
            txtActualMoney.Name = "txtActualMoney";
            txtActualMoney.Size = new Size(104, 29);
            txtActualMoney.TabIndex = 38;
            txtActualMoney.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCarId
            // 
            txtCarId.Font = new Font("Segoe UI", 12F);
            txtCarId.ForeColor = Color.FromArgb(47, 47, 47);
            txtCarId.Location = new Point(115, 3);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(173, 29);
            txtCarId.TabIndex = 37;
            txtCarId.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(863, 11);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 36;
            label6.Text = "ขาด-เกิน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(652, 11);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 34;
            label4.Text = "ยอดเงินสด";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(11, 11);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 33;
            label3.Text = "ทะเบียนรถยนต์";
            // 
            // dgvdailyRecord
            // 
            dgvdailyRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdailyRecord.Location = new Point(11, 38);
            dgvdailyRecord.Name = "dgvdailyRecord";
            dgvdailyRecord.Size = new Size(1510, 447);
            dgvdailyRecord.TabIndex = 32;
            dgvdailyRecord.CellFormatting += dgvdailyRecord_CellFormatting;
            dgvdailyRecord.CellValueChanged += dgvdailyRecord_CellValueChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(11, 491);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 40);
            btnSave.TabIndex = 27;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(413, 12);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 31;
            label1.Text = "บันทึกการขายรายวัน";
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.FromArgb(192, 255, 255);
            btnProcess.FlatStyle = FlatStyle.Flat;
            btnProcess.Font = new Font("Segoe UI", 13F);
            btnProcess.ForeColor = Color.Black;
            btnProcess.Location = new Point(1150, 3);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(186, 33);
            btnProcess.TabIndex = 30;
            btnProcess.Text = "สร้างแบบบันทึกการขาย";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // dgvSaleRecord
            // 
            dgvSaleRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleRecord.Location = new Point(413, 43);
            dgvSaleRecord.Name = "dgvSaleRecord";
            dgvSaleRecord.Size = new Size(1141, 156);
            dgvSaleRecord.TabIndex = 29;
            dgvSaleRecord.CellClick += dgvSaleRecord_CellClick;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label17.Location = new Point(21, 3);
            label17.Name = "label17";
            label17.Size = new Size(115, 28);
            label17.TabIndex = 9;
            label17.Text = "เลือกรถยนต์";
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(19, 43);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(388, 156);
            dgvCars.TabIndex = 0;
            dgvCars.CellClick += dgvCars_CellClick;
            // 
            // UserControlCheckStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMainDisplay);
            Controls.Add(panel1);
            Controls.Add(panelBotton);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "UserControlCheckStock";
            Size = new Size(1600, 800);
            Load += UserControlCheckStock_Load;
            panelMainDisplay.ResumeLayout(false);
            panelMainDisplay.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdailyRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelBotton;
        private Panel panelLeft;
        private Panel panelTop;
        private Panel panelMainDisplay;
        private DataGridView dgvCars;
        private Label label17;
        private DataGridView dgvSaleRecord;
        private Button btnSave;
        private Label label1;
        private Button btnProcess;
        private DataGridView dgvdailyRecord;
        private Panel panel2;
        private Label label2;
        private TextBox txtDiffMoney;
        private TextBox txtCarMoney;
        private TextBox txtActualMoney;
        private TextBox txtCarId;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtCostMoney;
        private Button btnUpdate;
        private Button btnDownloadSaleRecord;
        private Button btndownload;
    }
}
