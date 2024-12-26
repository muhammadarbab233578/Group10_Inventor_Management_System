using System;
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

        public StockMovement()
        {
            InitializeComponent();
        }

        private void AddMovementButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Add Movement successfully..");
        }

        private void UpdateMovementButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Update Movement successfully..");
        }

        private void DeleteMovementButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete Movement successfully..");
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
