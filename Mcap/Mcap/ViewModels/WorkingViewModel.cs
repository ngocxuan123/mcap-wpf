using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mcap.ViewModels
{
    public class WorkingViewModel : BaseViewModel
    {
        private Visibility _loading;
        public Visibility Loading
        {
            get => _loading;
            set
            {
                _loading = value;
                RaisePropertyChanged("Loading");
            }
        }

        public WorkingViewModel ()
        {
            Loading = Visibility.Visible;
        }
    }
}
