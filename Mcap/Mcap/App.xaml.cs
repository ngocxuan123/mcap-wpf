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
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //StartupUri = new Uri("Views/Login.xaml", UriKind.Relative);
            StartupUri = new Uri("MainLayout.xaml", UriKind.Relative);
        }
    }
}
