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
    /// Interaction logic for WidzardStartup.xaml
    /// </summary>
    public partial class WidzardStartup : Window
    {
        public bool Successfull { get; private set; }
        public WidzardStartup()
        {
            InitializeComponent();
            Successfull = false;
        }
        private void Wizard_Finish(object sender, Xceed.Wpf.Toolkit.Core.CancelRoutedEventArgs e)
        {
            Successfull = true;
        }
    }
}
