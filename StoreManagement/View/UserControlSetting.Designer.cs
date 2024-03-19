namespace StoreManagement.View
{
    partial class UserControlSetting
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
            panelMaindisplay = new Panel();
            panel2 = new Panel();
            txtCarId = new TextBox();
            txtCarYear = new TextBox();
            dgvCarsDetail = new DataGridView();
            btnAdd = new Button();
            btnRemove = new Button();
            label2 = new Label();
            btnEdit = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCarModel = new TextBox();
            panelMaindisplay.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarsDetail).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 77, 77);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1580, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(20, 760);
            panel1.TabIndex = 11;
            // 
            // panelBotton
            // 
            panelBotton.BackColor = Color.FromArgb(77, 77, 77);
            panelBotton.Dock = DockStyle.Bottom;
            panelBotton.Location = new Point(20, 780);
            panelBotton.Name = "panelBotton";
            panelBotton.Size = new Size(1580, 20);
            panelBotton.TabIndex = 10;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(77, 77, 77);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 20);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(20, 780);
            panelLeft.TabIndex = 9;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(77, 77, 77);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1600, 20);
            panelTop.TabIndex = 8;
            // 
            // panelMaindisplay
            // 
            panelMaindisplay.Controls.Add(panel2);
            panelMaindisplay.Dock = DockStyle.Fill;
            panelMaindisplay.Location = new Point(20, 20);
            panelMaindisplay.Name = "panelMaindisplay";
            panelMaindisplay.Size = new Size(1560, 760);
            panelMaindisplay.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 47, 47);
            panel2.Controls.Add(txtCarId);
            panel2.Controls.Add(txtCarYear);
            panel2.Controls.Add(dgvCarsDetail);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnRemove);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtCarModel);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1548, 748);
            panel2.TabIndex = 0;
            // 
            // txtCarId
            // 
            txtCarId.Font = new Font("Segoe UI", 12F);
            txtCarId.ForeColor = Color.FromArgb(47, 47, 47);
            txtCarId.Location = new Point(100, 40);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(173, 29);
            txtCarId.TabIndex = 56;
            txtCarId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCarYear
            // 
            txtCarYear.Font = new Font("Segoe UI", 12F);
            txtCarYear.ForeColor = Color.FromArgb(47, 47, 47);
            txtCarYear.Location = new Point(99, 110);
            txtCarYear.Name = "txtCarYear";
            txtCarYear.Size = new Size(173, 29);
            txtCarYear.TabIndex = 55;
            txtCarYear.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvCarsDetail
            // 
            dgvCarsDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarsDetail.Location = new Point(308, 14);
            dgvCarsDetail.Name = "dgvCarsDetail";
            dgvCarsDetail.Size = new Size(1226, 716);
            dgvCarsDetail.TabIndex = 54;
            dgvCarsDetail.CellClick += dgvCarsDetail_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(15, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(257, 71);
            btnAdd.TabIndex = 51;
            btnAdd.Text = "ลงทะเบียนรถยนต์";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 192, 192);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(147, 166);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(126, 40);
            btnRemove.TabIndex = 53;
            btnRemove.Text = "ลบรายการ";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(219, 28);
            label2.TabIndex = 28;
            label2.Text = "ระบบลงทะเบียนรถส่งของ";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 255, 192);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(15, 166);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 40);
            btnEdit.TabIndex = 52;
            btnEdit.Text = "แก้ไข";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 48);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 29;
            label3.Text = "ทะเบียนรถ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(35, 83);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 30;
            label4.Text = "ยี่ห้อรถ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 118);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 31;
            label5.Text = "ปีรถยนต์ :";
            // 
            // txtCarModel
            // 
            txtCarModel.Font = new Font("Segoe UI", 12F);
            txtCarModel.ForeColor = Color.FromArgb(47, 47, 47);
            txtCarModel.Location = new Point(99, 75);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(173, 29);
            txtCarModel.TabIndex = 40;
            txtCarModel.TextAlign = HorizontalAlignment.Center;
            // 
            // UserControlSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panelMaindisplay);
            Controls.Add(panel1);
            Controls.Add(panelBotton);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "UserControlSetting";
            Size = new Size(1600, 800);
            Load += UserControlSetting_Load;
            panelMaindisplay.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarsDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelBotton;
        private Panel panelLeft;
        private Panel panelTop;
        private Panel panelMaindisplay;
        private Panel panel2;
        private Button btnClear;
        private Button btnAdd;
        private Button btnRemove;
        private Label label2;
        private Button btnEdit;
        private Label label3;
        private Label label4;
        private TextBox txtSecUnit;
        private Label label5;
        private Label label13;
        private Label label6;
        private TextBox txtMoney;
        private Label label7;
        private TextBox txtpriceSec;
        private Label label8;
        private TextBox txtCostSec;
        private Label label9;
        private TextBox txtPriceMain;
        private Label label10;
        private TextBox txtCostMain;
        private Label label11;
        private TextBox txtRelationUnit;
        private Label label12;
        private TextBox txtSecRemaing;
        private TextBox txtProductName;
        private TextBox txtMainUnit;
        private TextBox txtCarModel;
        private DataGridView dgvCarsDetail;
        private TextBox txtCarId;
        private TextBox txtCarYear;
    }
}
