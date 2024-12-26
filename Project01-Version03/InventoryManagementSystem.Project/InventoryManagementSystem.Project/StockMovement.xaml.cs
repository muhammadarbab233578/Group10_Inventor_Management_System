using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for StockMovement.xaml
    /// </summary>
    public partial class StockMovement : Page
    {
        private static readonly Regex NumericRegex = new Regex("^[0-9]*$");
        private readonly string connectionString = "Data Source=AUMC-LAB1-27\\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;";

        public StockMovement()
        {
            InitializeComponent();
            LoadProducts();
            LoadStockMovements();
        }

        private void LoadProducts()
        {
            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("SELECT ProductID, Prodectsname FROM Products", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbProduct.Items.Add(new ComboBoxItem
                    {
                        Content = reader["Prodectsname"].ToString(),
                        Tag = reader["ProductID"]
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadStockMovements()
        {
            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("SELECT SM.MovementID, SM.ProductID, P.Prodectsname AS ProductName, SM.MovementType, SM.Quantity, SM.MovementDate, SM.Descriptions FROM StockMovements SM JOIN Products P ON SM.ProductID = P.ProductID", connection);
                var reader = cmd.ExecuteReader();
                stockMovementDataGrid.Items.Clear();
                while (reader.Read())
                {
                    stockMovementDataGrid.Items.Add(new
                    {
                        MovementID = reader["MovementID"],
                        ProductID = reader["ProductID"],
                        ProductName = reader["ProductName"],
                        MovementType = reader["MovementType"],
                        Quantity = reader["Quantity"],
                        MovementDate = reader["MovementDate"],
                        Descriptions = reader["Descriptions"]
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
            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return false;
            }
            if (cmbMovementType.SelectedItem == null)
            {
                MessageBox.Show("Please select a movement type.");
                return false;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return false;
            }
            if (dpMovementDate.SelectedDate == null)
            {
                MessageBox.Show("Please select a movement date.");
                return false;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return false;
            }
            return true;
        }

        private void AddMovementButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput()) return;

            var selectedProduct = (ComboBoxItem)cmbProduct.SelectedItem;
            int productId = selectedProduct != null ? (int)selectedProduct.Tag : 0;
            string movementType = (cmbMovementType.SelectedItem as ComboBoxItem)?.Content as string ?? "IN";
            int quantity = int.Parse(txtQuantity.Text);
            DateTime movementDate = dpMovementDate.SelectedDate ?? DateTime.Now;
            string description = txtDescription.Text;

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("INSERT INTO StockMovements (ProductID, MovementType, Quantity, MovementDate, Descriptions) VALUES (@ProductID, @MovementType, @Quantity, @MovementDate, @Descriptions)", connection);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@MovementType", movementType);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@MovementDate", movementDate);
                cmd.Parameters.AddWithValue("@Descriptions", description);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Movement added successfully.");
                LoadStockMovements();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateMovementButton_Click(object sender, RoutedEventArgs e)
        {
            if (stockMovementDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a movement to update.");
                return;
            }

            if (!ValidateInput()) return;

            dynamic selectedMovement = stockMovementDataGrid.SelectedItem;
            int movementId = selectedMovement.MovementID;
            var selectedProduct = (ComboBoxItem)cmbProduct.SelectedItem;
            int productId = selectedProduct != null ? (int)selectedProduct.Tag : 0;
            string movementType = (cmbMovementType.SelectedItem as ComboBoxItem)?.Content as string ?? "IN";
            int quantity = int.Parse(txtQuantity.Text);
            DateTime movementDate = dpMovementDate.SelectedDate ?? DateTime.Now;
            string description = txtDescription.Text;

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("UPDATE StockMovements SET ProductID = @ProductID, MovementType = @MovementType, Quantity = @Quantity, MovementDate = @MovementDate, Descriptions = @Descriptions WHERE MovementID = @MovementID", connection);
                cmd.Parameters.AddWithValue("@MovementID", movementId);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@MovementType", movementType);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@MovementDate", movementDate);
                cmd.Parameters.AddWithValue("@Descriptions", description);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Movement updated successfully.");
                LoadStockMovements();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteMovementButton_Click(object sender, RoutedEventArgs e)
        {
            if (stockMovementDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a movement to delete.");
                return;
            }

            dynamic selectedMovement = stockMovementDataGrid.SelectedItem;
            int movementId = selectedMovement.MovementID;

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("DELETE FROM StockMovements WHERE MovementID = @MovementID", connection);
                cmd.Parameters.AddWithValue("@MovementID", movementId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Movement deleted successfully.");
                LoadStockMovements();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TxtQuantity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Use the regex for numeric input validation
            e.Handled = !NumericRegex.IsMatch(e.Text);
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
