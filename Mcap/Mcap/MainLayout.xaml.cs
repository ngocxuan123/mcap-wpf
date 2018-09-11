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
using System.Windows.Shapes;

namespace Mcap
{
    /// <summary>
    /// Interaction logic for MainLayout.xaml
    /// </summary>
    public partial class MainLayout : Window
    {
        public MainLayout()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Fullscreen_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string buttonContent = button.Content.ToString();
            if (buttonContent.Equals("O"))
            {
                WindowState = WindowState.Maximized;
                button.Content = "o";
            }
            else
            {
                WindowState = WindowState.Normal;
                button.Content = "O";
            }
        }

        private void MinimiseScreen_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
