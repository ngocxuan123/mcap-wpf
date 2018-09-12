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
    internal class LayoutViewModel: BaseModel
    {
        public LayoutModel PageModel;

        private DelegateCommand _loginPageLoad;
        private DelegateCommand _worklistPageLoad;
        private DelegateCommand _workingPageLoad;

        private BaseViewModel _currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel;  }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }
        public ICommand LoginPageCommand
        {
            get
            {
                if (_loginPageLoad == null)
                {
                    _loginPageLoad = new DelegateCommand(new Action(LoadLoginPage));
                }
                return _loginPageLoad;
            }
        }

        public ICommand WorkListPageCommand
        {
            get
            {
                if (_worklistPageLoad == null)
                {
                    _worklistPageLoad = new DelegateCommand(new Action(WorklistPage));
                }
                return _worklistPageLoad;
            }
        }
        public ICommand WorkingPageCommand
        {
            get
            {
                if (_workingPageLoad == null)
                {
                    _workingPageLoad = new DelegateCommand(new Action(WorkingPage));
                }
                return _workingPageLoad;
            }
        }
        public LayoutViewModel ()
        {
            PageModel = new LayoutModel();
            WorkingPage();
        }

        private void LoadLoginPage ()
        {
            CurrentViewModel = new LoginViewModel();
        }

        private void WorklistPage ()
        {
            CurrentViewModel = new WorklistViewModel();
        }
        private void WorkingPage()
        {
            CurrentViewModel = new WorkingViewModel();
        }
    }
}
