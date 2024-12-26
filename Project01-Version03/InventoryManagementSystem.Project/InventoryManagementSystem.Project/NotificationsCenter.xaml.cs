using System;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for NotificationsCenter.xaml
    /// </summary>
    public partial class NotificationsCenter : Page
    {
        public NotificationsCenter()
        {
            InitializeComponent();
        }

        private void ClearNotificationsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("All Notification clear successfully");
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
