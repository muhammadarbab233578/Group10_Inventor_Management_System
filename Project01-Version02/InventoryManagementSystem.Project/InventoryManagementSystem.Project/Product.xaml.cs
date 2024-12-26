using System;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        public Product()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Product Add successfully...");
        }

        private void UpdateProductButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Product Update successfully...");
        }

        private void DeleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Product Delete successfully...");
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
