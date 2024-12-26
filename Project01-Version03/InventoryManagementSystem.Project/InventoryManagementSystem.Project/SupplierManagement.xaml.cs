using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for SupplierManagement.xaml
    /// </summary>
    public partial class SupplierManagement : Page
    {
        private readonly string connectionString = "Data Source=AUMC-LAB1-27\\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;";

        public SupplierManagement()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Suppliers", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    supplierDataGrid.Items.Clear();
                    while (reader.Read())
                    {
                        supplierDataGrid.Items.Add(new
                        {
                            SupplierID = reader["SupplierID"],
                            SupplierName = reader["SupplierName"],
                            ContactName = reader["ContactName"],
                            Phone = reader["Phone"],
                            Email = reader["Email"],
                            Address = reader["SupplierAddress"]
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                MessageBox.Show("Supplier Name is required.");
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

        private void AddSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput()) return;

            string supplierName = txtSupplierName.Text;
            string contactName = txtContactName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Suppliers (SupplierName, ContactName, Phone, Email, SupplierAddress) VALUES (@SupplierName, @ContactName, @Phone, @Email, @Address)", connection);
                    cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                    cmd.Parameters.AddWithValue("@ContactName", contactName);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier added successfully.");
                    LoadSuppliers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            if (supplierDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier to update.");
                return;
            }

            if (!ValidateInput()) return;

            dynamic selectedSupplier = supplierDataGrid.SelectedItem;
            int supplierId = selectedSupplier.SupplierID;
            string supplierName = txtSupplierName.Text;
            string contactName = txtContactName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Suppliers SET SupplierName = @SupplierName, ContactName = @ContactName, Phone = @Phone, Email = @Email, SupplierAddress = @Address WHERE SupplierID = @SupplierID", connection);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                    cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                    cmd.Parameters.AddWithValue("@ContactName", contactName);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier updated successfully.");
                    LoadSuppliers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DeleteSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            if (supplierDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            dynamic selectedSupplier = supplierDataGrid.SelectedItem;
            int supplierId = selectedSupplier.SupplierID;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Delete related records from PurchaseOrders
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM PurchaseOrders WHERE SupplierID = @SupplierID", connection);
                    cmd1.Parameters.AddWithValue("@SupplierID", supplierId);
                    cmd1.ExecuteNonQuery();

                    // Delete the supplier
                    SqlCommand cmd = new SqlCommand("DELETE FROM Suppliers WHERE SupplierID = @SupplierID", connection);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier deleted successfully.");
                    LoadSuppliers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
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
