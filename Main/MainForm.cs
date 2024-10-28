using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_Car_Traders; // Make sure to include this namespace

namespace ABC_Car_Traders.Main
{
    public partial class MainForm : Form
    {
        private User _currentUser;
        private const int FormWidth = 800;
        private const int FormHeight = 600;
        private System.Windows.Forms.Timer timer;
        private DatabaseHelper dbHelper;

        public MainForm(string userType, User currentUser)
        {
            InitializeComponent();
            if (currentUser == null)
            {
                MessageBox.Show("Invalid user data. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _currentUser = currentUser;
            dbHelper = new DatabaseHelper();
            ShowMainPanel(userType, currentUser);
            InitializeGreetingAndDateTime();
            InitializeWidgets();
        }

        // Initializes main form with appropriate menu items based on user type
        public void ShowMainPanel(string UserType, User currentUser)
        {
            _currentUser = currentUser;
            splitContainer1.Visible = true;
            ClearMenuItems();
            AddMenuItems(UserType);
        }

        // Adds menu items based on user role (Admin/Customer)
        private void AddMenuItems(string UserType)
        {
            if (UserType == "Admin")
            {
                AddAdminMenuItems();
            }
            else
            {
                AddCustomerMenuItems();
            }

            // Center menu items vertically
            int totalHeight = menuItemsPanel.Controls.Cast<Control>().Sum(c => c.Height + c.Margin.Vertical);
            int startY = (menuItemsPanel.Height - totalHeight) / 2;
            foreach (Control control in menuItemsPanel.Controls)
            {
                control.Top = startY;
                startY += control.Height + control.Margin.Vertical;
            }
        }

        private void AddAdminMenuItems()
        {
            AddMenuItem("Manage Car Details", btnManageCarDetails_Click);
            AddMenuItem("Manage Car Parts", btnManageCarParts_Click);
            AddMenuItem("Manage Customer Details", btnManageCustomerDetails_Click);
            AddMenuItem("Manage Orders", btnManageOrders_Click);
            AddMenuItem("Generate Reports", btnGenerateReports_Click);
        }

        private void AddCustomerMenuItems()
        {
            AddMenuItem("Search Car Details", btnSearchCarDetails_Click);
            AddMenuItem("Search Car Parts", btnSearchCarParts_Click);
            AddMenuItem("Order Car", btnOrderCar_Click);
            AddMenuItem("Order Car Parts", btnOrderCarParts_Click);
            AddMenuItem("View Order Status", btnViewOrderStatus_Click);
        }

        // Creates and configures menu buttons with consistent styling
        private void AddMenuItem(string text, EventHandler clickHandler)
        {
            Button button = new Button
            {
                Text = text,
                Dock = DockStyle.Top,
                Height = 40,
                Font = new Font("Arial", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Margin = new Padding(10, 5, 10, 5),
                BackColor = Color.FromArgb(64, 64, 64), // Dark gray background
                ForeColor = Color.White, // White text
                TextAlign = ContentAlignment.MiddleCenter
            };
            button.Click += clickHandler;
            menuItemsPanel.Controls.Add(button);
            menuItemsPanel.Controls.SetChildIndex(button, 0); // Place new buttons at the top

            // Add a spacer panel after each button
            Panel spacer = new Panel
            {
                Height = 10,
                Dock = DockStyle.Top
            };
            menuItemsPanel.Controls.Add(spacer);
            menuItemsPanel.Controls.SetChildIndex(spacer, 0);
        }

        private void btnManageCarDetails_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManageCarDetails());
        }

        private void btnManageCarParts_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManageCarParts());
        }

        private void btnManageCustomerDetails_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManageCustomerDetails());
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManageOrders());
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new GenerateReports());
        }

        private void btnSearchCarDetails_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new SearchCarDetails());
        }

        private void btnSearchCarParts_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new SearchCarParts());
        }

        private void btnOrderCar_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new OrderCar(_currentUser));
        }

        private void btnOrderCarParts_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new OrderCarParts(_currentUser));
        }

        private void btnViewOrderStatus_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ViewOrderStatus(_currentUser));
        }

        // Loads child forms into the main container panel
        private void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Size = splitContainer1.Panel2.Size;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _currentUser.Logout();
                _currentUser = null;
                
                // Create and show a new login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                
                // Close the current main form
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearMenuItems()
        {
            menuItemsPanel.Controls.Clear();
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeGreetingAndDateTime()
        {
            lblGreeting.Text = $"Welcome, {_currentUser.Name}!";
            
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Update every second
            timer.Tick += Timer_Tick;
            timer.Start();
            
            UpdateDateTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss");
        }

        // Initializes dashboard widgets based on user role
        private void InitializeWidgets()
        {
            panelWidgets.Controls.Clear();
            if (_currentUser.UserType == "Admin")
            {
                InitializeAdminWidgets();
            }
            else
            {
                InitializeCustomerWidgets();
            }
        }

        private void InitializeAdminWidgets()
        {
            try
            {
                string totalCarsQuery = "SELECT COUNT(*) FROM Cars";
                string totalCustomersQuery = "SELECT COUNT(*) FROM Users WHERE UserType = 'Customer'";
                string completedOrdersQuery = "SELECT COUNT(*) FROM Orders WHERE OrderStatus = 'Shipped'";
                string dueOrdersQuery = "SELECT COUNT(*) FROM Orders WHERE OrderStatus = 'Pending'";

                int totalCars = GetScalarValue(totalCarsQuery);
                int totalCustomers = GetScalarValue(totalCustomersQuery);
                int completedOrders = GetScalarValue(completedOrdersQuery);
                int dueOrders = GetScalarValue(dueOrdersQuery);

                AddWidget("Total Cars", totalCars.ToString());
                AddWidget("Total Customers", totalCustomers.ToString());
                AddWidget("Completed Orders", completedOrders.ToString());
                AddWidget("Due Orders", dueOrders.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the dashboard. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeCustomerWidgets()
        {
            try
            {
                string totalCarsQuery = "SELECT COUNT(*) FROM Cars";
                string totalPartsQuery = "SELECT COUNT(*) FROM CarParts";
                string customerOrdersQuery = $"SELECT COUNT(*) FROM Orders WHERE CustomerID = {_currentUser.UserID}";
                string pendingOrdersQuery = $"SELECT COUNT(*) FROM Orders WHERE CustomerID = {_currentUser.UserID} AND OrderStatus = 'Pending'";

                int totalCars = GetScalarValue(totalCarsQuery);
                int totalParts = GetScalarValue(totalPartsQuery);
                int customerOrders = GetScalarValue(customerOrdersQuery);
                int pendingOrders = GetScalarValue(pendingOrdersQuery);

                AddWidget("Available Cars", totalCars.ToString());
                AddWidget("Available Parts", totalParts.ToString());
                AddWidget("Your Orders", customerOrders.ToString());
                AddWidget("Pending Orders", pendingOrders.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the dashboard. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetScalarValue(string query)
        {
            try
            {
                DataTable dt = dbHelper.ExecuteQuery(query);
                if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0][0]);
                }
                Console.WriteLine($"Query returned no results: {query}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {query}. Error: {ex.Message}");
                return 0;
            }
        }

        private void AddWidget(string title, string value)
        {
            Panel widgetPanel = new Panel
            {
                Width = 250,
                Height = 100,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            Label titleLabel = new Label
            {
                Text = title,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label valueLabel = new Label
            {
                Text = value,
                Font = new Font("Arial", 20, FontStyle.Bold),
                Location = new Point(10, 40),
                AutoSize = true
            };

            widgetPanel.Controls.Add(titleLabel);
            widgetPanel.Controls.Add(valueLabel);
            panelWidgets.Controls.Add(widgetPanel);
        }
    }
}
