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

namespace Mcap.Components
{
    /// <summary>
    /// Interaction logic for HtmlTextBox.xaml
    /// </summary>
    public partial class HtmlTextBox : UserControl
    {
        public HtmlTextBox()
        {
            InitializeComponent();
        }

        private void HtmlTextBox1_Loaded_1(object sender, RoutedEventArgs e)
        {
            visualBrowser.Navigate(@"E:\learn\c#\mca-wpf\mcap-wpf\Mcap\Mcap\ckeditor.html");
        }
    }
}
