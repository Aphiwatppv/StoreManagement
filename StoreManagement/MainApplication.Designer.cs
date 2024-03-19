namespace StoreManagement
{
    partial class MainApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplication));
            MenuPanel = new Panel();
            btnMinimize = new Button();
            pictureBoxLogo = new PictureBox();
            btnExits = new Button();
            panel1 = new Panel();
            panelMenuBar = new Panel();
            btnRegistering = new Button();
            btnCheckStock = new Button();
            btnMainStore = new Button();
            panelStatusBar = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelMainDisplay = new Panel();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMenuBar.SuspendLayout();
            panelStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(47, 47, 47);
            MenuPanel.Controls.Add(btnMinimize);
            MenuPanel.Controls.Add(pictureBoxLogo);
            MenuPanel.Controls.Add(btnExits);
            MenuPanel.Controls.Add(panel1);
            MenuPanel.Dock = DockStyle.Top;
            MenuPanel.Font = new Font("Segoe UI", 12F);
            MenuPanel.Location = new Point(200, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(1600, 60);
            MenuPanel.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 15F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1450, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(75, 60);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Left;
            pictureBoxLogo.Image = Properties.Resources.Asset_21;
            pictureBoxLogo.Location = new Point(26, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(501, 60);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // btnExits
            // 
            btnExits.Dock = DockStyle.Right;
            btnExits.FlatAppearance.BorderSize = 0;
            btnExits.FlatStyle = FlatStyle.Flat;
            btnExits.Font = new Font("Segoe UI", 15F);
            btnExits.ForeColor = Color.White;
            btnExits.Location = new Point(1525, 0);
            btnExits.Name = "btnExits";
            btnExits.Size = new Size(75, 60);
            btnExits.TabIndex = 0;
            btnExits.Text = "X";
            btnExits.UseVisualStyleBackColor = true;
            btnExits.Click += btnExits_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(26, 60);
            panel1.TabIndex = 2;
            // 
            // panelMenuBar
            // 
            panelMenuBar.BackColor = Color.FromArgb(47, 47, 47);
            panelMenuBar.Controls.Add(btnRegistering);
            panelMenuBar.Controls.Add(btnCheckStock);
            panelMenuBar.Controls.Add(btnMainStore);
            panelMenuBar.Dock = DockStyle.Left;
            panelMenuBar.Font = new Font("Segoe UI", 12F);
            panelMenuBar.ForeColor = Color.Transparent;
            panelMenuBar.Location = new Point(0, 0);
            panelMenuBar.Name = "panelMenuBar";
            panelMenuBar.Size = new Size(200, 900);
            panelMenuBar.TabIndex = 1;
            // 
            // btnRegistering
            // 
            btnRegistering.BackgroundImageLayout = ImageLayout.None;
            btnRegistering.Dock = DockStyle.Bottom;
            btnRegistering.FlatAppearance.BorderSize = 0;
            btnRegistering.FlatStyle = FlatStyle.Flat;
            btnRegistering.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistering.ForeColor = Color.White;
            btnRegistering.Image = (Image)resources.GetObject("btnRegistering.Image");
            btnRegistering.Location = new Point(0, 841);
            btnRegistering.Name = "btnRegistering";
            btnRegistering.Size = new Size(200, 59);
            btnRegistering.TabIndex = 4;
            btnRegistering.Text = "Setting";
            btnRegistering.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistering.UseVisualStyleBackColor = true;
            btnRegistering.Click += btnRegistering_Click;
            // 
            // btnCheckStock
            // 
            btnCheckStock.Dock = DockStyle.Top;
            btnCheckStock.FlatAppearance.BorderSize = 0;
            btnCheckStock.FlatStyle = FlatStyle.Flat;
            btnCheckStock.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckStock.ForeColor = Color.White;
            btnCheckStock.Image = Properties.Resources.Store2;
            btnCheckStock.ImageAlign = ContentAlignment.TopLeft;
            btnCheckStock.Location = new Point(0, 60);
            btnCheckStock.Name = "btnCheckStock";
            btnCheckStock.Size = new Size(200, 60);
            btnCheckStock.TabIndex = 3;
            btnCheckStock.Text = "Check Stock";
            btnCheckStock.TextAlign = ContentAlignment.MiddleRight;
            btnCheckStock.UseVisualStyleBackColor = true;
            btnCheckStock.Click += btnCheckStock_Click;
            // 
            // btnMainStore
            // 
            btnMainStore.Dock = DockStyle.Top;
            btnMainStore.FlatAppearance.BorderSize = 0;
            btnMainStore.FlatStyle = FlatStyle.Flat;
            btnMainStore.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainStore.ForeColor = Color.White;
            btnMainStore.Image = (Image)resources.GetObject("btnMainStore.Image");
            btnMainStore.ImageAlign = ContentAlignment.TopLeft;
            btnMainStore.Location = new Point(0, 0);
            btnMainStore.Name = "btnMainStore";
            btnMainStore.Size = new Size(200, 60);
            btnMainStore.TabIndex = 1;
            btnMainStore.Text = "Main Store";
            btnMainStore.TextAlign = ContentAlignment.MiddleRight;
            btnMainStore.UseVisualStyleBackColor = true;
            btnMainStore.Click += btnMainStore_Click;
            // 
            // panelStatusBar
            // 
            panelStatusBar.BackColor = Color.FromArgb(47, 47, 47);
            panelStatusBar.Controls.Add(label1);
            panelStatusBar.Controls.Add(pictureBox1);
            panelStatusBar.Controls.Add(panel2);
            panelStatusBar.Dock = DockStyle.Bottom;
            panelStatusBar.Location = new Point(200, 860);
            panelStatusBar.Name = "panelStatusBar";
            panelStatusBar.Size = new Size(1600, 40);
            panelStatusBar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1174, 3);
            label1.Name = "label1";
            label1.Size = new Size(336, 29);
            label1.TabIndex = 5;
            label1.Text = "Developed by Aphiwat Company";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1516, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1587, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(13, 40);
            panel2.TabIndex = 4;
            // 
            // panelMainDisplay
            // 
            panelMainDisplay.BackColor = Color.White;
            panelMainDisplay.Dock = DockStyle.Fill;
            panelMainDisplay.Location = new Point(200, 60);
            panelMainDisplay.Name = "panelMainDisplay";
            panelMainDisplay.Size = new Size(1600, 800);
            panelMainDisplay.TabIndex = 3;
            // 
            // MainApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1800, 900);
            Controls.Add(panelMainDisplay);
            Controls.Add(panelStatusBar);
            Controls.Add(MenuPanel);
            Controls.Add(panelMenuBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMenuBar.ResumeLayout(false);
            panelStatusBar.ResumeLayout(false);
            panelStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel panelMenuBar;
        private Button btnExits;
        private Button btnMainStore;
        private Panel panelStatusBar;
        private Panel panelMainDisplay;
        private Button btnCheckStock;
        private PictureBox pictureBoxLogo;
        private Panel panel1;
        private Button btnRegistering;
        private Button btnMinimize;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
    }
}
