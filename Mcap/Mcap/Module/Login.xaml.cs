using Mcap.ViewModels;
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

namespace Mcap.Module
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private MainLayout _main;
        private bool _logined = false;
        public Login()
        {
            InitializeComponent();
            Closed += (o, e) =>
            {
                if (_logined)
                {
                    _main = new MainLayout() { DataContext = new LayoutViewModel() };
                    _main.Show();
                }
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _logined = true;
            this.Close();
        }
    }
}
