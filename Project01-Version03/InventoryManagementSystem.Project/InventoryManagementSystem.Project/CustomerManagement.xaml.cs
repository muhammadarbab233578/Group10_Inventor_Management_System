using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Page
    {
        private readonly string connectionString = "Data Source=AUMC-LAB1-27\\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;";

        public CustomerManagement()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("SELECT * FROM Customers", connection);
                var reader = cmd.ExecuteReader();
                customerDataGrid.Items.Clear();
                while (reader.Read())
                {
                    customerDataGrid.Items.Add(new
                    {
                        CustomerID = reader["CustomerID"],
                        CustomerName = reader["CustomerName"],
                        ContactName = reader["ContactName"],
                        Phone = reader["Phone"],
                        Email = reader["Email"],
                        Address = reader["Address"]
                    });
                }
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
            if (string.IsNullOrEmpty(txtContactName.Text))
            {
                MessageBox.Show("Contact Name is required.");
                return false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email is required.");
                return false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is required.");
                return false;
            }
            return true;
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput()) return;

            string customerName = txtCustomerName.Text;
            string contactName = txtContactName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("INSERT INTO Customers (CustomerName, ContactName, Phone, Email, Address) VALUES (@CustomerName, @ContactName, @Phone, @Email, @Address)", connection);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@ContactName", contactName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully.");
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            if (customerDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            if (!ValidateInput()) return;

            dynamic selectedCustomer = customerDataGrid.SelectedItem;
            int customerId = selectedCustomer.CustomerID;
            string customerName = txtCustomerName.Text;
            string contactName = txtContactName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("UPDATE Customers SET CustomerName = @CustomerName, ContactName = @ContactName, Phone = @Phone, Email = @Email, Address = @Address WHERE CustomerID = @CustomerID", connection);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@ContactName", contactName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully.");
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            if (customerDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            dynamic selectedCustomer = customerDataGrid.SelectedItem;
            int customerId = selectedCustomer.CustomerID;

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", connection);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer deleted successfully.");
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
