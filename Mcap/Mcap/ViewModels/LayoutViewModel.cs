using GalaSoft.MvvmLight;
using Mcap.Commands;
using Mcap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mcap.ViewModels
{
    public class LayoutViewModel: ViewModelBase
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
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
