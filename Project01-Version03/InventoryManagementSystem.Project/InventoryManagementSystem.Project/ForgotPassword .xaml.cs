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
    /// Interaction logic for forgotPassword.xaml
    /// </summary>
    public partial class forgotPassword : Page
    {
        public forgotPassword()
        {
            InitializeComponent();
        }

        private void ResetPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Password Reset Successfully...");
        }

        private void BackToLoginButton_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new Window
            {
                Title = "Login Page",
                Content = new LoginPage(),
                Height = 450,
                Width = 800,
                Background = this.Background,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            loginWindow.Show();
            Window.GetWindow(this)?.Close();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new Window
            {
                Title = "Login Page",
                Content = new LoginPage(),
                Height = 450,
                Width = 800,
                Background = this.Background,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            loginWindow.Show();
            Window.GetWindow(this)?.Close();
        }
    }
}
