namespace StoreManagement.View
{
    partial class UserControlMainStore
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
            panelTop = new Panel();
            panelLeft = new Panel();
            panelBotton = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label19 = new Label();
            txtSearchingProduct = new TextBox();
            dvgProduction = new DataGridView();
            btnDownloadStock = new Button();
            label1 = new Label();
            labelCostprice = new Label();
            labelTotalPrice = new Label();
            labelTotalproduct = new Label();
            panel3 = new Panel();
            btnClear = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtSecUnit = new TextBox();
            label13 = new Label();
            txtMoney = new TextBox();
            txtpriceSec = new TextBox();
            txtCostSec = new TextBox();
            txtPriceMain = new TextBox();
            txtCostMain = new TextBox();
            txtRelationUnit = new TextBox();
            txtSecRemaing = new TextBox();
            txtMainUnit = new TextBox();
            txtMainRemaining = new TextBox();
            txtProductName = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            textBoxNewQueantity = new TextBox();
            label18 = new Label();
            cbIncraseDecrease = new ComboBox();
            label16 = new Label();
            comboBoxUnit = new ComboBox();
            textBoxIdprocess = new TextBox();
            label15 = new Label();
            textBoxdetail = new TextBox();
            label14 = new Label();
            btnProcess = new Button();
            textBoxQuantity = new TextBox();
            textBoxproductNameP = new TextBox();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            dgvhistoricalrecord = new DataGridView();
            label17 = new Label();
            txtSearchingRecord = new TextBox();
            label20 = new Label();
            panel5 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            btnDownloadRecord = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProduction).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhistoricalrecord).BeginInit();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(77, 77, 77);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1600, 20);
            panelTop.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(77, 77, 77);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 20);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(20, 780);
            panelLeft.TabIndex = 1;
            // 
            // panelBotton
            // 
            panelBotton.BackColor = Color.FromArgb(77, 77, 77);
            panelBotton.Dock = DockStyle.Bottom;
            panelBotton.Location = new Point(20, 780);
            panelBotton.Name = "panelBotton";
            panelBotton.Size = new Size(1580, 20);
            panelBotton.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 77, 77);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1580, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(20, 760);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label19);
            panel2.Controls.Add(txtSearchingProduct);
            panel2.Controls.Add(dvgProduction);
            panel2.Controls.Add(btnDownloadStock);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(26, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(1548, 302);
            panel2.TabIndex = 4;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label19.Location = new Point(1212, 5);
            label19.Name = "label19";
            label19.Size = new Size(173, 25);
            label19.TabIndex = 3;
            label19.Text = "ค้นหารายการสินค้า :";
            // 
            // txtSearchingProduct
            // 
            txtSearchingProduct.Location = new Point(1391, 5);
            txtSearchingProduct.Name = "txtSearchingProduct";
            txtSearchingProduct.Size = new Size(154, 23);
            txtSearchingProduct.TabIndex = 2;
            txtSearchingProduct.TextChanged += txtSearchingProduct_TextChanged;
            // 
            // dvgProduction
            // 
            dvgProduction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProduction.Location = new Point(12, 31);
            dvgProduction.Name = "dvgProduction";
            dvgProduction.Size = new Size(1533, 261);
            dvgProduction.TabIndex = 1;
            dvgProduction.CellClick += dvgProduction_CellClick;
            // 
            // btnDownloadStock
            // 
            btnDownloadStock.BackColor = Color.Thistle;
            btnDownloadStock.FlatStyle = FlatStyle.Flat;
            btnDownloadStock.Font = new Font("Segoe UI", 11F);
            btnDownloadStock.ForeColor = Color.Black;
            btnDownloadStock.Location = new Point(1014, 3);
            btnDownloadStock.Name = "btnDownloadStock";
            btnDownloadStock.Size = new Size(192, 27);
            btnDownloadStock.TabIndex = 33;
            btnDownloadStock.Text = "ดาวน์โหลดรายการสินค้า";
            btnDownloadStock.UseVisualStyleBackColor = false;
            btnDownloadStock.Click += btnDownloadStock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 0;
            label1.Text = "รายการสินค้าทั้งหมด";
            // 
            // labelCostprice
            // 
            labelCostprice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelCostprice.AutoSize = true;
            labelCostprice.Font = new Font("Segoe UI", 13F);
            labelCostprice.ForeColor = Color.Black;
            labelCostprice.Location = new Point(139, 20);
            labelCostprice.Name = "labelCostprice";
            labelCostprice.Size = new Size(99, 25);
            labelCostprice.TabIndex = 6;
            labelCostprice.Text = "มูลค้าทั้งหมด";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 13F);
            labelTotalPrice.ForeColor = Color.Black;
            labelTotalPrice.Location = new Point(139, 21);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(113, 25);
            labelTotalPrice.TabIndex = 5;
            labelTotalPrice.Text = "ต้นทุนทั้งหมด :";
            // 
            // labelTotalproduct
            // 
            labelTotalproduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelTotalproduct.AutoSize = true;
            labelTotalproduct.Font = new Font("Segoe UI", 13F);
            labelTotalproduct.ForeColor = Color.Black;
            labelTotalproduct.Location = new Point(165, 20);
            labelTotalproduct.Name = "labelTotalproduct";
            labelTotalproduct.Size = new Size(109, 25);
            labelTotalproduct.TabIndex = 4;
            labelTotalproduct.Text = "สินค้าทั้งหมด :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(47, 47, 47);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnRemove);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(txtSecUnit);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtMoney);
            panel3.Controls.Add(txtpriceSec);
            panel3.Controls.Add(txtCostSec);
            panel3.Controls.Add(txtPriceMain);
            panel3.Controls.Add(txtCostMain);
            panel3.Controls.Add(txtRelationUnit);
            panel3.Controls.Add(txtSecRemaing);
            panel3.Controls.Add(txtMainUnit);
            panel3.Controls.Add(txtMainRemaining);
            panel3.Controls.Add(txtProductName);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(26, 334);
            panel3.Name = "panel3";
            panel3.Size = new Size(474, 440);
            panel3.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(332, 52);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 40);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 192, 192);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(332, 157);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(126, 40);
            btnRemove.TabIndex = 26;
            btnRemove.Text = "ลบรายการ";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 255, 192);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(332, 103);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 40);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "แก้ไข";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(332, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 186);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "เพิ่มรายการสินค้า";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSecUnit
            // 
            txtSecUnit.Font = new Font("Segoe UI", 12F);
            txtSecUnit.ForeColor = Color.FromArgb(47, 47, 47);
            txtSecUnit.Location = new Point(139, 179);
            txtSecUnit.Name = "txtSecUnit";
            txtSecUnit.Size = new Size(173, 29);
            txtSecUnit.TabIndex = 23;
            txtSecUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(54, 187);
            label13.Name = "label13";
            label13.Size = new Size(79, 21);
            label13.TabIndex = 22;
            label13.Text = "หน่วย (รอง)";
            // 
            // txtMoney
            // 
            txtMoney.Font = new Font("Segoe UI", 12F);
            txtMoney.ForeColor = Color.FromArgb(47, 47, 47);
            txtMoney.Location = new Point(139, 391);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(173, 29);
            txtMoney.TabIndex = 21;
            txtMoney.TextAlign = HorizontalAlignment.Center;
            // 
            // txtpriceSec
            // 
            txtpriceSec.Font = new Font("Segoe UI", 12F);
            txtpriceSec.ForeColor = Color.FromArgb(47, 47, 47);
            txtpriceSec.Location = new Point(139, 355);
            txtpriceSec.Name = "txtpriceSec";
            txtpriceSec.Size = new Size(173, 29);
            txtpriceSec.TabIndex = 20;
            txtpriceSec.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCostSec
            // 
            txtCostSec.Font = new Font("Segoe UI", 12F);
            txtCostSec.ForeColor = Color.FromArgb(47, 47, 47);
            txtCostSec.Location = new Point(139, 320);
            txtCostSec.Name = "txtCostSec";
            txtCostSec.Size = new Size(173, 29);
            txtCostSec.TabIndex = 19;
            txtCostSec.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPriceMain
            // 
            txtPriceMain.Font = new Font("Segoe UI", 12F);
            txtPriceMain.ForeColor = Color.FromArgb(47, 47, 47);
            txtPriceMain.Location = new Point(139, 285);
            txtPriceMain.Name = "txtPriceMain";
            txtPriceMain.Size = new Size(173, 29);
            txtPriceMain.TabIndex = 18;
            txtPriceMain.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCostMain
            // 
            txtCostMain.Font = new Font("Segoe UI", 12F);
            txtCostMain.ForeColor = Color.FromArgb(47, 47, 47);
            txtCostMain.Location = new Point(139, 250);
            txtCostMain.Name = "txtCostMain";
            txtCostMain.Size = new Size(173, 29);
            txtCostMain.TabIndex = 17;
            txtCostMain.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRelationUnit
            // 
            txtRelationUnit.Font = new Font("Segoe UI", 12F);
            txtRelationUnit.ForeColor = Color.FromArgb(47, 47, 47);
            txtRelationUnit.Location = new Point(139, 215);
            txtRelationUnit.Name = "txtRelationUnit";
            txtRelationUnit.Size = new Size(173, 29);
            txtRelationUnit.TabIndex = 16;
            txtRelationUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSecRemaing
            // 
            txtSecRemaing.Font = new Font("Segoe UI", 12F);
            txtSecRemaing.ForeColor = Color.FromArgb(47, 47, 47);
            txtSecRemaing.Location = new Point(139, 142);
            txtSecRemaing.Name = "txtSecRemaing";
            txtSecRemaing.Size = new Size(173, 29);
            txtSecRemaing.TabIndex = 15;
            txtSecRemaing.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMainUnit
            // 
            txtMainUnit.Font = new Font("Segoe UI", 12F);
            txtMainUnit.ForeColor = Color.FromArgb(47, 47, 47);
            txtMainUnit.Location = new Point(139, 107);
            txtMainUnit.Name = "txtMainUnit";
            txtMainUnit.Size = new Size(173, 29);
            txtMainUnit.TabIndex = 14;
            txtMainUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMainRemaining
            // 
            txtMainRemaining.Font = new Font("Segoe UI", 12F);
            txtMainRemaining.ForeColor = Color.FromArgb(47, 47, 47);
            txtMainRemaining.Location = new Point(139, 72);
            txtMainRemaining.Name = "txtMainRemaining";
            txtMainRemaining.Size = new Size(173, 29);
            txtMainRemaining.TabIndex = 13;
            txtMainRemaining.TextAlign = HorizontalAlignment.Center;
            txtMainRemaining.TextChanged += txtMainRemaining_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F);
            txtProductName.ForeColor = Color.FromArgb(47, 47, 47);
            txtProductName.Location = new Point(139, 37);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(173, 29);
            txtProductName.TabIndex = 12;
            txtProductName.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(32, 328);
            label12.Name = "label12";
            label12.Size = new Size(103, 21);
            label12.TabIndex = 11;
            label12.Text = "ต้นทุนหน่วยรอง";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(32, 293);
            label11.Name = "label11";
            label11.Size = new Size(101, 21);
            label11.TabIndex = 10;
            label11.Text = "ราคาหน่วยหลัก";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(70, 399);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 9;
            label10.Text = "สกุลเงิน";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(38, 363);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 8;
            label9.Text = "ราคาหน่วยรอง";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(24, 258);
            label8.Name = "label8";
            label8.Size = new Size(109, 21);
            label8.TabIndex = 7;
            label8.Text = "ต้นทุนหน่วยหลัก";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(36, 223);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 6;
            label7.Text = "หน่วยสัมพันธ์";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 150);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 5;
            label6.Text = "ยอดคงเหลือ (รอง)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 117);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 4;
            label5.Text = "หน่วย (หลัก)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 80);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 3;
            label4.Text = "ยอดคงเหลือ (หลัก)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(70, 45);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 2;
            label3.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(259, 28);
            label2.TabIndex = 1;
            label2.Text = "เพิ่ม/ลด/แก้ไข รายการสินค้า";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(34, 34, 34);
            panel4.Controls.Add(textBoxNewQueantity);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(cbIncraseDecrease);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(comboBoxUnit);
            panel4.Controls.Add(textBoxIdprocess);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(textBoxdetail);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(btnProcess);
            panel4.Controls.Add(textBoxQuantity);
            panel4.Controls.Add(textBoxproductNameP);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(label24);
            panel4.Controls.Add(label25);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(506, 549);
            panel4.Name = "panel4";
            panel4.Size = new Size(549, 225);
            panel4.TabIndex = 6;
            // 
            // textBoxNewQueantity
            // 
            textBoxNewQueantity.Font = new Font("Segoe UI", 12F);
            textBoxNewQueantity.ForeColor = Color.FromArgb(47, 47, 47);
            textBoxNewQueantity.Location = new Point(399, 37);
            textBoxNewQueantity.Name = "textBoxNewQueantity";
            textBoxNewQueantity.Size = new Size(97, 29);
            textBoxNewQueantity.TabIndex = 37;
            textBoxNewQueantity.TextAlign = HorizontalAlignment.Center;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.ForeColor = Color.White;
            label18.Location = new Point(291, 45);
            label18.Name = "label18";
            label18.Size = new Size(102, 21);
            label18.TabIndex = 36;
            label18.Text = "ยอดคงเหลือใหม่";
            // 
            // cbIncraseDecrease
            // 
            cbIncraseDecrease.Font = new Font("Segoe UI", 12F);
            cbIncraseDecrease.FormattingEnabled = true;
            cbIncraseDecrease.Location = new Point(98, 112);
            cbIncraseDecrease.Name = "cbIncraseDecrease";
            cbIncraseDecrease.Size = new Size(85, 29);
            cbIncraseDecrease.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(28, 120);
            label16.Name = "label16";
            label16.Size = new Size(58, 21);
            label16.TabIndex = 33;
            label16.Text = "เพิ่ม/ลด";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.Font = new Font("Segoe UI", 12F);
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new Point(98, 152);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(85, 29);
            comboBoxUnit.TabIndex = 32;
            // 
            // textBoxIdprocess
            // 
            textBoxIdprocess.Font = new Font("Segoe UI", 12F);
            textBoxIdprocess.ForeColor = Color.FromArgb(47, 47, 47);
            textBoxIdprocess.Location = new Point(98, 42);
            textBoxIdprocess.Name = "textBoxIdprocess";
            textBoxIdprocess.Size = new Size(121, 29);
            textBoxIdprocess.TabIndex = 31;
            textBoxIdprocess.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(16, 50);
            label15.Name = "label15";
            label15.Size = new Size(70, 21);
            label15.TabIndex = 30;
            label15.Text = "รหัสสินค้า";
            // 
            // textBoxdetail
            // 
            textBoxdetail.Font = new Font("Segoe UI", 12F);
            textBoxdetail.ForeColor = Color.FromArgb(47, 47, 47);
            textBoxdetail.Location = new Point(399, 77);
            textBoxdetail.Name = "textBoxdetail";
            textBoxdetail.Size = new Size(97, 29);
            textBoxdetail.TabIndex = 29;
            textBoxdetail.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(291, 85);
            label14.Name = "label14";
            label14.Size = new Size(92, 21);
            label14.TabIndex = 28;
            label14.Text = "ข้อมูลเพิ่มเติม";
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.FromArgb(192, 255, 255);
            btnProcess.FlatStyle = FlatStyle.Flat;
            btnProcess.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcess.ForeColor = Color.Black;
            btnProcess.Location = new Point(291, 112);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(234, 105);
            btnProcess.TabIndex = 27;
            btnProcess.Text = "ดำเนินการ";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Font = new Font("Segoe UI", 12F);
            textBoxQuantity.ForeColor = Color.FromArgb(47, 47, 47);
            textBoxQuantity.Location = new Point(98, 188);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(176, 29);
            textBoxQuantity.TabIndex = 13;
            textBoxQuantity.TextAlign = HorizontalAlignment.Center;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            // 
            // textBoxproductNameP
            // 
            textBoxproductNameP.Font = new Font("Segoe UI", 12F);
            textBoxproductNameP.ForeColor = Color.FromArgb(47, 47, 47);
            textBoxproductNameP.Location = new Point(98, 77);
            textBoxproductNameP.Name = "textBoxproductNameP";
            textBoxproductNameP.Size = new Size(176, 29);
            textBoxproductNameP.TabIndex = 12;
            textBoxproductNameP.TextAlign = HorizontalAlignment.Center;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.ForeColor = Color.White;
            label22.Location = new Point(42, 160);
            label22.Name = "label22";
            label22.Size = new Size(44, 21);
            label22.TabIndex = 4;
            label22.Text = "หน่วย";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.ForeColor = Color.White;
            label23.Location = new Point(34, 196);
            label23.Name = "label23";
            label23.Size = new Size(52, 21);
            label23.TabIndex = 3;
            label23.Text = "จำนวน";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F);
            label24.ForeColor = Color.White;
            label24.Location = new Point(23, 85);
            label24.Name = "label24";
            label24.Size = new Size(63, 21);
            label24.TabIndex = 2;
            label24.Text = "ชื่อสินค้า";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label25.ForeColor = Color.White;
            label25.Location = new Point(3, 0);
            label25.Name = "label25";
            label25.Size = new Size(139, 28);
            label25.TabIndex = 1;
            label25.Text = "เพิ่ม/ลด/สินค้า";
            // 
            // dgvhistoricalrecord
            // 
            dgvhistoricalrecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhistoricalrecord.Location = new Point(506, 361);
            dgvhistoricalrecord.Name = "dgvhistoricalrecord";
            dgvhistoricalrecord.Size = new Size(1068, 182);
            dgvhistoricalrecord.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label17.Location = new Point(506, 331);
            label17.Name = "label17";
            label17.Size = new Size(208, 28);
            label17.TabIndex = 8;
            label17.Text = "ประวัติการเพิ่มลดสินค้า";
            // 
            // txtSearchingRecord
            // 
            txtSearchingRecord.Location = new Point(1360, 334);
            txtSearchingRecord.Name = "txtSearchingRecord";
            txtSearchingRecord.Size = new Size(211, 23);
            txtSearchingRecord.TabIndex = 9;
            txtSearchingRecord.TextChanged += txtSearchingRecord_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            label20.Location = new Point(1253, 337);
            label20.Name = "label20";
            label20.Size = new Size(101, 21);
            label20.TabIndex = 10;
            label20.Text = "ค้นหาประวัติ :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(34, 34, 34);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(1061, 549);
            panel5.Name = "panel5";
            panel5.Size = new Size(510, 225);
            panel5.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 224, 192);
            panel8.Controls.Add(pictureBox3);
            panel8.Controls.Add(labelTotalPrice);
            panel8.Location = new Point(12, 155);
            panel8.Name = "panel8";
            panel8.Size = new Size(479, 56);
            panel8.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 255, 192);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(labelCostprice);
            panel7.Location = new Point(12, 85);
            panel7.Name = "panel7";
            panel7.Size = new Size(479, 56);
            panel7.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 255, 255);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(labelTotalproduct);
            panel6.Location = new Point(12, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(479, 56);
            panel6.TabIndex = 7;
            // 
            // btnDownloadRecord
            // 
            btnDownloadRecord.BackColor = Color.FromArgb(255, 192, 128);
            btnDownloadRecord.FlatStyle = FlatStyle.Flat;
            btnDownloadRecord.Font = new Font("Segoe UI", 11F);
            btnDownloadRecord.ForeColor = Color.Black;
            btnDownloadRecord.Location = new Point(1046, 331);
            btnDownloadRecord.Name = "btnDownloadRecord";
            btnDownloadRecord.Size = new Size(186, 28);
            btnDownloadRecord.TabIndex = 32;
            btnDownloadRecord.Text = "ดาวน์โหลดรายการประวัติ";
            btnDownloadRecord.UseVisualStyleBackColor = false;
            btnDownloadRecord.Click += btnDownloadRecord_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.money2;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.money1;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // UserControlMainStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(label17);
            Controls.Add(txtSearchingRecord);
            Controls.Add(btnDownloadRecord);
            Controls.Add(dgvhistoricalrecord);
            Controls.Add(label20);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelBotton);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "UserControlMainStore";
            Size = new Size(1600, 800);
            Load += UserControlMainStore_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProduction).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhistoricalrecord).EndInit();
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Panel panelBotton;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dvgProduction;
        private Label label1;
        private Panel panel3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label12;
        private Label label11;
        private TextBox txtSecUnit;
        private Label label13;
        private TextBox txtMoney;
        private TextBox txtpriceSec;
        private TextBox txtCostSec;
        private TextBox txtPriceMain;
        private TextBox txtCostMain;
        private TextBox txtRelationUnit;
        private TextBox txtSecRemaing;
        private TextBox txtMainUnit;
        private TextBox txtMainRemaining;
        private TextBox txtProductName;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnClear;
        private Panel panel4;
        private Button btnProcess;
        private TextBox textBoxQuantity;
        private TextBox textBoxproductNameP;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private TextBox textBoxIdprocess;
        private Label label15;
        private TextBox textBoxdetail;
        private Label label14;
        private TextBox textBoxNewQueantity;
        private Label label18;
        private ComboBox cbIncraseDecrease;
        private Label label16;
        private ComboBox comboBoxUnit;
        private DataGridView dgvhistoricalrecord;
        private Label label17;
        private TextBox txtSearchingProduct;
        private Label label19;
        private TextBox txtSearchingRecord;
        private Label label20;
        private DateTimePicker dateTimePickerStartDate;
        private Panel panel5;
        private Label label27;
        private Label label26;
        private DateTimePicker dateTimePickerEndDate;
        private Button btnSearchingRecord;
        private Button btnDownloadRecord;
        private Button btnDownloadStock;
        private Label labelCostprice;
        private Label labelTotalPrice;
        private Label labelTotalproduct;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
