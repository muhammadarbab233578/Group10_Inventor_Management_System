using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for ReportsAndAnalytics.xaml
    /// </summary>
    public partial class ReportsAndAnalytics : Page
    {
        public ReportsAndAnalytics()
        {
            InitializeComponent();
        }

        private void InventoryValuationButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inventory Valuation is successfully...");
        }

        private void StockMovementReportsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Stock Movement Reports is successfully...");
        }

        private void SalesReportsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sales Reportsis successfully...");
        }

        private void PurchaseReportsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Purchase Reports is successfully...");
        }

        private void DemandForecastingButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Demand Forecasting is successfully...");
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
