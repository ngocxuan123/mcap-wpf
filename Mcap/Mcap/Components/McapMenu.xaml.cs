using GalaSoft.MvvmLight;
using Mcap.Commands;
using Mcap.Core.EventArgs;
using Mcap.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Linq;

namespace Mcap.Components
{
    /// <summary>
    /// Interaction logic for McapMenu.xaml
    /// </summary>
    public partial class McapMenu : UserControl
    {
        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }

        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
        "Tap", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(McapMenu));

        // Provide CLR accessors for the event
        public event RoutedEventHandler Tap
        {
            add { AddHandler(TapEvent, value); }
            remove { RemoveHandler(TapEvent, value); }
        }

        // This method raises the Tap event
        void RaiseTapEvent(string Name)
        {
            MenuLayoutRoutedEventArgs newEventArgs = new MenuLayoutRoutedEventArgs(McapMenu.TapEvent, Name);
            RaiseEvent(newEventArgs);
        }

        public void ChangeActive (string Header)
        {
            for (int i = 0; i < MenuItems.Count; i++)
            {
                if (MenuItems[i].Header == Header)
                {
                    MenuItems[i].IsActive = true;
                } else
                {
                    MenuItems[i].IsActive = false;
                }
                
            }
        }
        public McapMenu()
        {
            InitializeComponent();
            MenuItems = new ObservableCollection<MenuItemViewModel>
            {
                new MenuItemViewModel { Header = "Thực hiện", MenuIcon = "AddressCard", Command = new DelegateCommand( () => {
                       RaiseTapEvent("Mcap.ViewModels.WorkingViewModel");
                       ChangeActive("Thực hiện");
                    }), IsActive = true },
                new MenuItemViewModel { Header = "Tiếp nhận", MenuIcon = "Ambulance", Command = new DelegateCommand( () => {
                       RaiseTapEvent("Tiếp nhận");
                       ChangeActive("Tiếp nhận");
                    }),
                    MenuItems = new ObservableCollection<MenuItemViewModel>
                        {
                            new MenuItemViewModel { Header = "Beta1", MenuIcon = "Ambulance" },
                            new MenuItemViewModel { Header = "Beta2", MenuIcon = "Ambulance",
                                MenuItems = new ObservableCollection<MenuItemViewModel>
                                {
                                    new MenuItemViewModel { Header = "Beta1a", MenuIcon = "Ambulance" },
                                    new MenuItemViewModel { Header = "Beta1b", MenuIcon = "Ambulance" },
                                    new MenuItemViewModel { Header = "Beta1c", MenuIcon = "Ambulance" }
                                }
                            },
                            new MenuItemViewModel { Header = "Beta3", MenuIcon = "Ambulance" }
                        }
                },
                new MenuItemViewModel { Header = "Worklist", MenuIcon = "Ambulance",  Command = new DelegateCommand( () => {
                       RaiseTapEvent("Mcap.ViewModels.LoginViewModel");
                       ChangeActive("Worklist");
                    }), IsActive = false  }
            };
            DataContext = this;
        }
    }
    public class MenuItemViewModel : ObservableObject
    {
        public MenuItemViewModel()
        {
            IsEnabled = true;
        }

        private string _header;
        public string Header
        {
            get { return _header; }
            set
            {
                if (_header == value)
                    return;

                _header = value;
                base.RaisePropertyChanged("Header");
            }
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (_isEnabled == value)
                    return;

                _isEnabled = value;
                base.RaisePropertyChanged("IsEnabled");
            }
        }
        private ICommand _command;
        public ICommand Command
        {
            get { return _command; }
            set
            {
                if (_command == value)
                    return;

                _command = value;
                base.RaisePropertyChanged("Command");
            }
        }

        private string _menuIcon;
        public string MenuIcon
        {
            get { return _menuIcon; }
            set
            {
                if (_menuIcon == value)
                    return;

                _menuIcon = value;
                base.RaisePropertyChanged("MenuIcon");
            }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                if (_isActive == value)
                    return;

                _isActive = value;
                base.RaisePropertyChanged("IsActive");
                base.RaisePropertyChanged("BackgroundColor");
                base.RaisePropertyChanged("ForeGround");
            }
        }

        public string BackgroundColor
        {
            get
            {
                return IsActive ? "White" : "#0095FF";
            }
        }

        public string Foreground
        {
            get
            {
                return IsActive ? "Black" : "White";
            }
        }

        private ObservableCollection<MenuItemViewModel> _menuItems;
        public ObservableCollection<MenuItemViewModel> MenuItems
        {
            get { return _menuItems; }
            set
            {
                _menuItems = value;
                base.RaisePropertyChanged("MenuItems");
            }
        }
    }
}
