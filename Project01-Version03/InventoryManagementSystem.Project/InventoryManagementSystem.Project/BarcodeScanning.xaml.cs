using System;
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
            // Logic for handling the KeyDown event
            if (e.Key == Key.Enter)
            {
                // Handle Enter key press (e.g., process the barcode)
                MessageBox.Show("Barcode Entered: " + txtBarcode.Text);
            }
        }
    }
}
