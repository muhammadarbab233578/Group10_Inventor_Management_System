using System;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for SupplierManagement.xaml
    /// </summary>
    public partial class SupplierManagement : Page
    {
        public SupplierManagement()
        {
            InitializeComponent();
        }

        private void AddSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ADD Supplier Successfully...");
        }

        private void UpdateSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Update Supplier Successfully...");
        }

        private void DeleteSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete Supplier Successfully...");
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
