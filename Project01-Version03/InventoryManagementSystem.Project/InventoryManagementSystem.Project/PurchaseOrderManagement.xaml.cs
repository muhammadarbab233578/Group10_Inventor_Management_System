using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for PurchaseOrderManagement.xaml
    /// </summary>
    public partial class PurchaseOrderManagement : Page
    {
        private readonly string connectionString = "Data Source=AUMC-LAB1-27\\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;";

        public PurchaseOrderManagement()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("SELECT SupplierID, SupplierName FROM Suppliers", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbSupplier.Items.Add(new ComboBoxItem
                    {
                        Content = reader["SupplierName"],
                        Tag = reader["SupplierID"]
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput()) return;

            var selectedSupplier = (ComboBoxItem)cmbSupplier.SelectedItem;
            var supplierId = selectedSupplier != null ? (int)selectedSupplier.Tag : 0;
            var orderDate = dpOrderDate.SelectedDate ?? DateTime.Now;
            var status = ((ComboBoxItem)cmbStatus.SelectedItem)?.Content as string;
            if (!decimal.TryParse(txtTotalAmount.Text, out var totalAmount))
            {
                MessageBox.Show("Invalid total amount.");
                return;
            }

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("INSERT INTO PurchaseOrders (SupplierID, OrderDate, OrderStatus, TotalAmount) VALUES (@SupplierID, @OrderDate, @OrderStatus, @TotalAmount)", connection);
                cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@OrderStatus", status);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Purchase Order submitted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (cmbSupplier.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier.");
                return false;
            }
            if (dpOrderDate.SelectedDate == null)
            {
                MessageBox.Show("Please select an order date.");
                return false;
            }
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return false;
            }
            if (string.IsNullOrEmpty(txtTotalAmount.Text) || !decimal.TryParse(txtTotalAmount.Text, out _))
            {
                MessageBox.Show("Please enter a valid total amount.");
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
