using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Mcap.MessageInfrastructure;
using Mcap.Model;
using Mcap.Model.Shared;
using Mcap.Module;
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
        private Dictionary<string, Window> _windowViews;
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
                new MenuItemModel { Header = "Worklist", MenuIcon = "Ambulance", Name = "Worklist", IsActive = true },
                new MenuItemModel { Header = "Ca chụp đã thực hiện", MenuIcon = "Ambulance", Name = "Complete", IsActive = false },
                new MenuItemModel { Header = "Danh mục", MenuIcon = "Ambulance", Name ="",
                    MenuItems = new ObservableCollection<MenuItemModel>
                        {
                            new MenuItemModel { Header = "Quản lý mẫu mô tả", MenuIcon = "Ambulance", Name = "Template"},
                            new MenuItemModel { Header = "Quản lý thiết bị", MenuIcon = "Ambulance", Name = "Modility" },
                            new MenuItemModel { Header = "Quản lý mẫu báo cáo", MenuIcon = "Ambulance", Name = "Report" },
                            new MenuItemModel { Header = "Quản lý dịch vụ", MenuIcon = "Ambulance", Name = "Concept" }
                        }
                },
                new MenuItemModel { Header = "Cài đặt", MenuIcon = "Ambulance", Name = "Setting", IsActive = false, IsPopup = true }
            };
            PageViews.Add("Work", new WorkingViewModel());
            PageViews.Add("Worklist", new WorklistViewModel());
            PageViews.Add("Complete", new CompleteViewModel());
            PageViews.Add("Template", new DescriptionTemplateViewModel());
            PageViews.Add("Modility", new ModalityViewModel());
            PageViews.Add("Report", new ReportTemplateViewModel());
            PageViews.Add("Concept", new ConceptViewModel());
            PopupViews.Add("Setting", new Setting());
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
        public Dictionary<string, Window> PopupViews
        {
            get
            {
                if (_windowViews == null)
                {
                    _windowViews = new Dictionary<string, Window>();
                }
                return _windowViews;
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
                if (info.Item == "Setting")
                {
                    (new Setting()).ShowDialog();
                } else
                {
                    ChangeActive(info.Item);
                }
            });
        }
        public void ChangeActive(string name)
        {
            if (string.IsNullOrEmpty(name)) return;
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
