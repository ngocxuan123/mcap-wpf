using GalaSoft.MvvmLight;
using Mcap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mcap.ViewModels
{
    public class LayoutViewModel: BaseViewModel
    {
        private BaseViewModel _currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel;  }
            set
            {
                _currentViewModel = value;
                RaisePropertyChanged("CurrentViewModel");
            }
        }

        public LayoutViewModel ()
        {
            CurrentViewModel = new WorkingViewModel();
        }
    }
}
