using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private readonly string connectionString = "Data Source=AUMC-LAB1-27\\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;";

        public LoginPage()
        {
            InitializeComponent();

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string hashedPassword = HashPassword(password);

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("SELECT COUNT(1) FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash", connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
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
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var registerWindow = new Window
            {
                Title = "Register Page",
                Content = new Register(),
                Height = 450,
                Width = 800,
                Background = this.Background,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            registerWindow.Show();
            Window.GetWindow(this)?.Close();
        }

        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
