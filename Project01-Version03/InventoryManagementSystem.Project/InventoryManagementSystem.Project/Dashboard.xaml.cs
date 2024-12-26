using System;
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void NotificationButton_Click(object sender, RoutedEventArgs e)
        {
            var notificationsCenterWindow = new Window
            {
                Title = "Notification Center",
                Content = new NotificationsCenter(),
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            notificationsCenterWindow.Show();

            Window.GetWindow(this)?.Close();
        }

        private void ProductsButton_Click(object sender, RoutedEventArgs e)
        {
            var ProductManagements = new Window
            {
                Title = "Product Managements",
                Content = new Product()
            };

            ProductManagements.Show();

            Window.GetWindow(this)?.Close();
        }

        private void PurchaseOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            var PurchaseOrderManagement = new Window
            {
                Title = "Purchase Order Management",
                Content = new PurchaseOrderManagement()
            };

            PurchaseOrderManagement.Show();

            Window.GetWindow(this)?.Close();

        }

        private void SalesOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            var SalesOrderManagement = new Window
            {
                Title = "Sales Order Management",
                Content = new SalesOrderManagement()
            };

            SalesOrderManagement.Show();

            Window.GetWindow(this)?.Close();
        }

        private void SuppliersButton_Click(object sender, RoutedEventArgs e)
        {
            var SupplierManagement = new Window
            {
                Title = "Supplier Management",
                Content = new SupplierManagement()
            };

            SupplierManagement.Show();

            Window.GetWindow(this)?.Close();
        }

        private void CustomersButton_Click(object sender, RoutedEventArgs e)
        {
            var CustomerManagement = new Window
            {
                Title = "CustomerManagement",
                Content = new CustomerManagement()
            };

            CustomerManagement.Show();

            Window.GetWindow(this)?.Close(); ;
        }

        private void StockMovementButton_Click(object sender, RoutedEventArgs e)
        {
            var StockMovement = new Window
            {
                Title = "Stock Movement",
                Content = new StockMovement()
            };

            StockMovement.Show();

            Window.GetWindow(this)?.Close();

        }

        private void BarcodeScanningButton_Click(object sender, RoutedEventArgs e)
        {
            var BarcodeScanning = new Window
            {
                Title = "Barcode Scanning",
                Content = new BarcodeScanning()
            };

            BarcodeScanning.Show();

            Window.GetWindow(this)?.Close();
        }


        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You Enter Setting Button");
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            var LoginPage = new Window
            {
                Title = "LoginPage Center",
                Content = new LoginPage()
            };

            LoginPage.Show();

            Window.GetWindow(this)?.Close();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            var LoginPageWindow = new Window
            {
                Title = "Notification Center",
                Content = new LoginPage()
            };

            LoginPageWindow.Show();

            Window.GetWindow(this)?.Close();
        }
    }
}
