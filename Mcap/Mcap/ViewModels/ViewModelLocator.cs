using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator ()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<LayoutViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<WorkingViewModel>();
            SimpleIoc.Default.Register<WorklistViewModel>();
        }

        public LayoutViewModel MainLayout
        {
            get => ServiceLocator.Current.GetInstance<LayoutViewModel>();
        }

        public LoginViewModel Login
        {
            get => ServiceLocator.Current.GetInstance<LoginViewModel>();
        }

        public WorkingViewModel Working
        {
            get => ServiceLocator.Current.GetInstance<WorkingViewModel>();
        }
        public static void CleanUp ()
        {

        }
    }
}
