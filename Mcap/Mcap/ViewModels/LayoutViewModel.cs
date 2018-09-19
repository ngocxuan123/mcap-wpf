using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Mcap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Mcap.ViewModels
{
    public class LayoutViewModel : BaseViewModel, IDisposable
    {
        private ContainerViewModel _currentViewModel;

        private RelayCommand<ContainerViewModel> _changeCurrentContentCommand;

        public RelayCommand<ContainerViewModel> ChangeCurrentContentCommand
        {
            get
            {
                if (_changeCurrentContentCommand == null)
                {
                    _changeCurrentContentCommand = new RelayCommand<ContainerViewModel>((viewmodel) => { _currentViewModel = viewmodel; });
                }
                return _changeCurrentContentCommand;
            }
        }
        public ContainerViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                RaisePropertyChanged("CurrentViewModel");
            }
        }

        public LayoutViewModel()
        {
            CurrentViewModel = new WorklistViewModel();
        }

        public void Dispose()
        {
            CurrentViewModel.Dispose();
        }
    }
}
