﻿using System;
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
    /// Interaction logic for SalesOrderManagement.xaml
    /// </summary>
    public partial class SalesOrderManagement : Page
    {
        public SalesOrderManagement()
        {
            InitializeComponent();
        }

        private void AddOrderButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Add Order successfully...");
        }

        private void UpdateOrderButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Update Order successfully...");
        }

        private void DeleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete Order successfully...");
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