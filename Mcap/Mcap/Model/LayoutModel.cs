using GalaSoft.MvvmLight;
using Mcap.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.Model
{
    internal class LayoutModel : BaseModel
    {
        private BaseModel _currentViewModel;
        public BaseModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                RaisePropertyChanged("CurrentViewModel");
            }
        }
    }
}
