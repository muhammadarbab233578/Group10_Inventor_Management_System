using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.Project
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        private readonly string connectionString = "Data Source=AUMC-LAB1-27\\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True;";

        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password != txtConfirmPassword.Password)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Password;
            string? role = (cmbRole.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            string hashedPassword = HashPassword(password);

            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var cmd = new SqlCommand("INSERT INTO Users (Username, PasswordHash, Roles) VALUES (@Username, @PasswordHash, @Roles)", connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                cmd.Parameters.AddWithValue("@Roles", role);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User registered successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new Window
            {
                Title = "Login Page",
                Content = new LoginPage(),
                Height = 450,
                Width = 800,
                Background = Background,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            loginWindow.Show();
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
