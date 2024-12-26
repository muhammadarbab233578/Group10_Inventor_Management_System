using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new Window
            {
                Title = "Login Page",
                Content = new LoginPage(), // Ensure this is a valid UserControl or Page
                Height = 450,
                Width = 800,
                Background = this.Background,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            loginWindow.Show();
            this.Close();
        }
    }
}
