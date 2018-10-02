using Mcap.Module;
using System.Data.OleDb;
using Mcap.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Mcap.Core.Exception;

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
            //try
            //{
            //    using (Data.McapDbContext context = new Data.McapDbContext())
            //    {
            //        context.Patients.Add(new Data.Patient() { Name = "Vuong oc" });
            //        context.SaveChanges();
            //        //throw new ExceptionDemo();
            //    }
            //    widzard.ShowDialog();
            //}
            //catch (ExceptionDemo exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

        }
    }
}
