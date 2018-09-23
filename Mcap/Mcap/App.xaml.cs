using Mcap.Module;
using Mcap.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Mcap
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var widzard = new WidzardStartup();
            widzard.Closing += (o, evt) =>
            {
                if ((o as WidzardStartup).Successfull)
                {
                    //var window = new MainLayout() { DataContext = new LayoutViewModel() };
                    //window.Show();
                    var login = new Login();
                    login.Show();
                }
            };
            widzard.ShowDialog();
        }
    }
}
