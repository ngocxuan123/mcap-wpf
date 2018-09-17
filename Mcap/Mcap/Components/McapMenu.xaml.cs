using GalaSoft.MvvmLight;
using Mcap.Core.EventArgs;
using Mcap.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Linq;
using Mcap.ViewModels;
using GalaSoft.MvvmLight.Command;

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
            MenuLayoutRoutedEventArgs newEventArgs = new MenuLayoutRoutedEventArgs(TapEvent, Name);
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
                new MenuItemViewModel { Header = "Thực hiện", MenuIcon = "AddressCard", Command = new RelayCommand( () => {
                       RaiseTapEvent("Mcap.ViewModels.WorkingViewModel");
                       ChangeActive("Thực hiện");
                    }), IsActive = true },
                new MenuItemViewModel { Header = "Tiếp nhận", MenuIcon = "Ambulance", Command = new RelayCommand( () => {
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
                new MenuItemViewModel { Header = "Worklist", MenuIcon = "Ambulance",  Command = new RelayCommand( () => {
                       RaiseTapEvent("Mcap.ViewModels.LoginViewModel");
                       ChangeActive("Worklist");
                    }), IsActive = false  }
            };
            DataContext = this;
        }
    }
    
}
