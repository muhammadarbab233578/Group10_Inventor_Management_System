using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for SalesOrderManagement.xaml
    /// </summary>
    public partial class SalesOrderManagement : Page
    {
        private readonly string connectionString = "Data Source=AUMC-LAB1-27\\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;";

        public SalesOrderManagement()
        {
            InitializeComponent();
            LoadSalesOrders();
        }

        private void LoadSalesOrders()
        {
            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("SELECT * FROM SalesOrders", connection);
                var reader = cmd.ExecuteReader();
                salesOrderDataGrid.Items.Clear();
                while (reader.Read())
                {
                    salesOrderDataGrid.Items.Add(new
                    {
                        SalesOrderID = reader["SalesOrderID"],
                        CustomerName = reader["CustomerName"],
                        OrderDate = reader["OrderDate"],
                        OrderStatus = reader["OrderStatus"],
                        TotalAmount = reader["TotalAmount"]
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput()) return;

            string customerName = txtCustomerName.Text;
            DateTime orderDate = dpOrderDate.SelectedDate ?? DateTime.Now;
            string status = (cmbOrderStatus.SelectedItem as ComboBoxItem)?.Content as string ?? "Pending";
            decimal totalAmount = 0m; // Set this value based on your calculations

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("INSERT INTO SalesOrders (CustomerName, OrderDate, OrderStatus, TotalAmount) VALUES (@CustomerName, @OrderDate, @OrderStatus, @TotalAmount)", connection);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@OrderStatus", status);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order added successfully.");
                LoadSalesOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (salesOrderDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select an order to update.");
                return;
            }

            if (!ValidateInput()) return;

            dynamic selectedOrder = salesOrderDataGrid.SelectedItem;
            int salesOrderId = selectedOrder.SalesOrderID;
            string customerName = txtCustomerName.Text;
            DateTime orderDate = dpOrderDate.SelectedDate ?? DateTime.Now;
            string status = (cmbOrderStatus.SelectedItem as ComboBoxItem)?.Content as string ?? "Pending";
            decimal totalAmount = 0m; // Set this value based on your calculations

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("UPDATE SalesOrders SET CustomerName = @CustomerName, OrderDate = @OrderDate, OrderStatus = @OrderStatus, TotalAmount = @TotalAmount WHERE SalesOrderID = @SalesOrderID", connection);
                cmd.Parameters.AddWithValue("@SalesOrderID", salesOrderId);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@OrderStatus", status);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order updated successfully.");
                LoadSalesOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (salesOrderDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select an order to delete.");
                return;
            }

            dynamic selectedOrder = salesOrderDataGrid.SelectedItem;
            int salesOrderId = selectedOrder.SalesOrderID;

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("DELETE FROM SalesOrders WHERE SalesOrderID = @SalesOrderID", connection);
                cmd.Parameters.AddWithValue("@SalesOrderID", salesOrderId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order deleted successfully.");
                LoadSalesOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Customer Name is required.");
                return false;
            }
            if (dpOrderDate.SelectedDate == null)
            {
                MessageBox.Show("Please select an order date.");
                return false;
            }
            if (cmbOrderStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select an order status.");
                return false;
            }
            return true;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            var dashboardWindow = new Window
            {
                Title = "Dashboard Page",
                Content = new Dashboard(),
                Height = 450,
                Width = 800,
                Background = this.Background,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            dashboardWindow.Show();
            Window.GetWindow(this)?.Close();
        }
    }
}
