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

            SimpleIoc.Default.Register<FooterViewModel>();
        }
        #region Layout Component
        public FooterViewModel Footer
        {
            get => ServiceLocator.Current.GetInstance<FooterViewModel>();
        }
        #endregion

        #region View Container
        public LayoutViewModel MainLayout
        {
            get => ServiceLocator.Current.GetInstance<LayoutViewModel>();
        }

        public WorklistViewModel Worlist
        {
            get => ServiceLocator.Current.GetInstance<WorklistViewModel>();
        }

        public WorkingViewModel Working
        {
            get => ServiceLocator.Current.GetInstance<WorkingViewModel>();
        }
        #endregion
        public static void CleanUp ()
        {

        }
    }
}
