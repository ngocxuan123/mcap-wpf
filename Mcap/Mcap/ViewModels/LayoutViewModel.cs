using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Mcap.MessageInfrastructure;
using Mcap.Model;
using Mcap.Model.Shared;
using Mcap.ViewModels;
using Mcap.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Mcap.ViewModels
{
    public class LayoutViewModel : BaseViewModel, IDisposable
    {
        #region Private Field
        private PageViewModel _currentViewModel;
        private Dictionary<string, PageViewModel> _pageViews;
        private ToolbarMenuViewModel _toolbar;
        #endregion

        #region Command
        private RelayCommand<PageViewModel> _changeCurrentContentCommand;
        public RelayCommand<PageViewModel> ChangeCurrentContentCommand
        {
            get
            {
                if (_changeCurrentContentCommand == null)
                {
                    _changeCurrentContentCommand = new RelayCommand<PageViewModel>(
                        viewmodel => { _currentViewModel = viewmodel; },
                        vm => vm is PageViewModel);
                }
                return _changeCurrentContentCommand;
            }
        }
        #endregion

        #region Constructor
        public LayoutViewModel()
        {
            ReceiveMenuActive();
            Toolbar = new ToolbarMenuViewModel();
            Toolbar.MenuItems = new ObservableCollection<MenuItemModel>
            {
                new MenuItemModel { Header = "Thực hiện", MenuIcon = "AddressCard", Name ="Work", IsActive = false  },
                new MenuItemModel { Header = "Tiếp nhận", MenuIcon = "Ambulance", Name ="Action",
                    MenuItems = new ObservableCollection<MenuItemModel>
                        {
                            new MenuItemModel { Header = "Beta1", MenuIcon = "Ambulance" },
                            new MenuItemModel { Header = "Beta3", MenuIcon = "Ambulance" }
                        }
                },
                new MenuItemModel { Header = "Worklist", MenuIcon = "Ambulance", Name = "Worklist", IsActive = true }
            };
            PageViews.Add("Work", new WorkingViewModel());
            PageViews.Add("Worklist", new WorklistViewModel());
            CurrentViewModel = PageViews["Worklist"];
        }

        private void OnLogout()
        {
            Messenger.Default.Register<NotificationMessage>(this, message =>
            {
            });
        }
        #endregion

        #region Public Property
        public PageViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set => Set(ref _currentViewModel, value);
        }
        public Dictionary<string, PageViewModel> PageViews
        {
            get
            {
                if (_pageViews == null)
                {
                    _pageViews = new Dictionary<string, PageViewModel>();
                }
                return _pageViews;
            }
        }
        public ToolbarMenuViewModel Toolbar
        {
            get
            {
                if (_toolbar == null)
                {
                    _toolbar = new ToolbarMenuViewModel();
                }
                return _toolbar;
            }
            set => Set(ref _toolbar, value);
        }
        #endregion
        #region Public Method
        public void Dispose()
        {
            CurrentViewModel.Dispose();
        }
        #endregion
        #region Private Method
        private void ReceiveMenuActive()
        {
            Messenger.Default.Register<MenuMessageComunicator>(this, info =>
            {
                ChangeActive(info.Item);
            });
        }
        public void ChangeActive(string name = null)
        {
            for (int i = 0; i < Toolbar.MenuItems.Count; i++)
            {
                if (Toolbar.MenuItems[i].Name == name)
                {
                    Toolbar.MenuItems[i].IsActive = true;
                }
                else
                {
                    Toolbar.MenuItems[i].IsActive = false;
                }
            }
            CurrentViewModel = PageViews[name];
        }
        #endregion
    }
}
