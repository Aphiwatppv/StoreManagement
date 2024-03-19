

using StoreManagement.View;

namespace StoreManagement
{
    public partial class MainApplication : Form
    {
        UserControlMainStore _userControlMainStore;
        UserControlCheckStock _userControlCheckstock;
        UserControlSetting _userControlSetting;
        // Drag panel
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public MainApplication()
        {
            InitializeComponent();
            _userControlMainStore = new UserControlMainStore();
            panelMainDisplay.Controls.Clear();
            _userControlMainStore.Dock = DockStyle.Fill;
            panelMainDisplay.Controls.Add(_userControlMainStore);

            this.MenuPanel.MouseDown += new MouseEventHandler(Panel_MouseDown);
            this.MenuPanel.MouseMove += new MouseEventHandler(Panel_MouseMove);
            this.MenuPanel.MouseUp += new MouseEventHandler(Panel_MouseUp);

            this.panelMenuBar.MouseDown += new MouseEventHandler(Panel_MouseDown);
            this.panelMenuBar.MouseMove += new MouseEventHandler(Panel_MouseMove);
            this.panelMenuBar.MouseUp += new MouseEventHandler(Panel_MouseUp);
        }

        private void Panel_MouseUp(object? sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Panel_MouseMove(object? sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Panel_MouseDown(object? sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ToggleUserControl(UserControl userControl)
        {
            // Check if the control to toggle is already displayed
            if (!panelMainDisplay.Controls.Contains(userControl))
            {
                // The control is not displayed, so display it.
                panelMainDisplay.Controls.Clear();
                userControl.Dock = DockStyle.Fill;
                panelMainDisplay.Controls.Add(userControl);
            }
            else
            {

                userControl.Visible = !userControl.Visible;
            }
        }
        private void btnExits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMainStore_Click(object sender, EventArgs e)
        {
            if (_userControlMainStore == null || _userControlMainStore.IsDisposed)
            {
                _userControlMainStore = new UserControlMainStore();
            }
            ToggleUserControl(_userControlMainStore);
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            if (_userControlCheckstock == null || _userControlCheckstock.IsDisposed)
            {
                _userControlCheckstock = new UserControlCheckStock();
            }
            ToggleUserControl(_userControlCheckstock);
        }

        private void btnRegistering_Click(object sender, EventArgs e)
        {
            if (_userControlSetting == null || _userControlSetting.IsDisposed)
            {
                _userControlSetting = new UserControlSetting();
            }
            ToggleUserControl(_userControlSetting);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }
    }
}
