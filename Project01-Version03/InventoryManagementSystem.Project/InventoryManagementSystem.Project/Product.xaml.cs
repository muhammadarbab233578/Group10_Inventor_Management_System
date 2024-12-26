using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        private readonly string connectionString = "Data Source=AUMC-LAB1-27\\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;";

        public Product()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Products", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    productDataGrid.Items.Clear();
                    while (reader.Read())
                    {
                        productDataGrid.Items.Add(new
                        {
                            ProductID = reader["ProductID"],
                            Prodectsname = reader["Prodectsname"],
                            SKU = reader["SKU"],
                            Category = reader["Category"],
                            Quantity = reader["Quantity"],
                            UnitPrice = reader["UnitPrice"],
                            Barcode = reader["Barcode"]
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string sku = txtSKU.Text;
            string category = txtCategory.Text;
            int quantity = int.Parse(txtQuantity.Text);
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
            string barcode = txtBarcode.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Products (Prodectsname, SKU, Category, Quantity, UnitPrice, Barcode) VALUES (@Name, @SKU, @Category, @Quantity, @UnitPrice, @Barcode)", connection);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@SKU", sku);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully.");
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (productDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            dynamic selectedProduct = productDataGrid.SelectedItem;
            int productId = selectedProduct.ProductID;
            string name = txtName.Text;
            string sku = txtSKU.Text;
            string category = txtCategory.Text;
            int quantity = int.Parse(txtQuantity.Text);
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
            string barcode = txtBarcode.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Products SET Prodectsname = @Name, SKU = @SKU, Category = @Category, Quantity = @Quantity, UnitPrice = @UnitPrice, Barcode = @Barcode WHERE ProductID = @ProductID", connection);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@SKU", sku);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated successfully.");
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DeleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (productDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            dynamic selectedProduct = productDataGrid.SelectedItem;
            int productId = selectedProduct.ProductID;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Delete related records from PurchaseOrderDetails
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM PurchaseOrderDetails WHERE ProductID = @ProductID", connection);
                    cmd1.Parameters.AddWithValue("@ProductID", productId);
                    cmd1.ExecuteNonQuery();

                    // Delete related records from SalesOrderDetails
                    SqlCommand cmd2 = new SqlCommand("DELETE FROM SalesOrderDetails WHERE ProductID = @ProductID", connection);
                    cmd2.Parameters.AddWithValue("@ProductID", productId);
                    cmd2.ExecuteNonQuery();

                    // Delete related records from StockMovements
                    SqlCommand cmd3 = new SqlCommand("DELETE FROM StockMovements WHERE ProductID = @ProductID", connection);
                    cmd3.Parameters.AddWithValue("@ProductID", productId);
                    cmd3.ExecuteNonQuery();

                    // Delete the product
                    SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @ProductID", connection);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product deleted successfully.");
                    LoadProducts();
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
