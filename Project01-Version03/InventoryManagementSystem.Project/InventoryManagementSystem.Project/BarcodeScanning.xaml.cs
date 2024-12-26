using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for BarcodeScanning.xaml
    /// </summary>
    public partial class BarcodeScanning : Page
    {
        private readonly string connectionString = "Data Source=AUMC-LAB1-27\\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;";

        public BarcodeScanning()
        {
            InitializeComponent();
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

        private void BarcodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DisplayProductDetails(txtBarcode.Text);
            }
        }

        private void DisplayProductDetails(string barcode)
        {
            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("SELECT Prodectsname, SKU, Category, Quantity, UnitPrice, Barcode FROM Products WHERE Barcode = @Barcode", connection);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtProductName.Text = reader["Prodectsname"].ToString();
                    txtSKU.Text = reader["SKU"].ToString();
                    txtCategory.Text = reader["Category"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();
                    txtUnitPrice.Text = reader["UnitPrice"].ToString();
                    txtBarcodeDisplay.Text = reader["Barcode"].ToString();
                }
                else
                {
                    MessageBox.Show("Product not found.");
                    ClearProductDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearProductDetails()
        {
            txtProductName.Text = string.Empty;
            txtSKU.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtBarcodeDisplay.Text = string.Empty;
        }
    }
}
