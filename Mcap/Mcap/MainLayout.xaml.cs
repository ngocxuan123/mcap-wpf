using FirstFloor.ModernUI.Windows.Controls;
using GalaSoft.MvvmLight;
using Mcap.Core.EventArgs;
using Mcap.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            this.Closing += (s, e) => (this.DataContext as IDisposable).Dispose();
        }

        private void McapMenu_Tap(object sender, RoutedEventArgs e)
        {
            MenuLayoutRoutedEventArgs args = (MenuLayoutRoutedEventArgs)e;
            LayoutViewModel viewModel = (LayoutViewModel) DataContext;
            Type t = Type.GetType(args.Name);
            viewModel.CurrentViewModel = (ContainerViewModel) Activator.CreateInstance(t);
        }
    }
}
