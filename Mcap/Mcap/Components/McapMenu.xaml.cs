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

        public McapMenu()
        {
            InitializeComponent();
            MenuItems = new ObservableCollection<MenuItemViewModel>
            {
                new MenuItemViewModel { Header = "Thực hiện", MenuIcon = "/Resources/icons/white/w-patient-add.png", Command = new DelegateCommand( () => {
                       RaiseTapEvent("Mcap.ViewModels.WorkingViewModel");
                    }) },
                new MenuItemViewModel { Header = "Tiếp nhận", MenuIcon = "/Resources/icons/white/w-chart.png", Command = new DelegateCommand( () => {
                       RaiseTapEvent("Tiếp nhận");
                    }),
                    MenuItems = new ObservableCollection<MenuItemViewModel>
                        {
                            new MenuItemViewModel { Header = "Beta1", MenuIcon = "/Resources/icons/black/b-workstation.png" },
                            new MenuItemViewModel { Header = "Beta2", MenuIcon = "/Resources/icons/black/b-workstation.png",
                                MenuItems = new ObservableCollection<MenuItemViewModel>
                                {
                                    new MenuItemViewModel { Header = "Beta1a", MenuIcon = "/Resources/icons/black/b-workstation.png" },
                                    new MenuItemViewModel { Header = "Beta1b", MenuIcon = "/Resources/icons/black/b-workstation.png" },
                                    new MenuItemViewModel { Header = "Beta1c", MenuIcon = "/Resources/icons/black/b-workstation.png" }
                                }
                            },
                            new MenuItemViewModel { Header = "Beta3", MenuIcon = "/Resources/icons/black/b-workstation.png" }
                        }
                },
                new MenuItemViewModel { Header = "Worklist", MenuIcon = "/Resources/icons/white/w-workstation.png",  Command = new DelegateCommand( () => {
                       RaiseTapEvent("Mcap.ViewModels.LoginViewModel");
                    })  }
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
