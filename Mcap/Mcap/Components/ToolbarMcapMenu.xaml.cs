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
using GalaSoft.MvvmLight.Messaging;
using Mcap.Helper.Const;
using Mcap.Module;

namespace Mcap.Components
{
    /// <summary>
    /// Interaction logic for McapMenu.xaml
    /// </summary>
    public partial class ToolbarMcapMenu : UserControl
    {
        //public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }

        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
        "Tap", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ToolbarMcapMenu));

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
        public ToolbarMcapMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void LogoutCommand_Click(object sender, RoutedEventArgs e)
        {
            Login signIn = new Login();
            Application.Current.Windows[0].Close();
            signIn.ShowDialog();
        }
        //public void ChangeActive(string Header)
        //{
        //    for (int i = 0; i < MenuItems.Count; i++)
        //    {
        //        if (MenuItems[i].Header == Header)
        //        {
        //            MenuItems[i].IsActive = true;
        //        }
        //        else
        //        {
        //            MenuItems[i].IsActive = false;
        //        }
        //    }
        //}
        //public McapMenu()
        //{
        //    InitializeComponent();
        //    MenuItems = new ObservableCollection<MenuItemViewModel>
        //    {
        //        new MenuItemViewModel { Header = "Thực hiện", MenuIcon = "AddressCard", Command = new RelayCommand( () => {
        //               RaiseTapEvent("Mcap.ViewModels.WorkingViewModel");
        //               ChangeActive("Thực hiện");
        //            }), IsActive = false },
        //        new MenuItemViewModel { Header = "Tiếp nhận", MenuIcon = "Ambulance", Command = new RelayCommand( () => {
        //               RaiseTapEvent("Tiếp nhận");
        //               ChangeActive("Tiếp nhận");
        //            }),
        //            MenuItems = new ObservableCollection<MenuItemViewModel>
        //                {
        //                    new MenuItemViewModel { Header = "Beta1", MenuIcon = "Ambulance" },
        //                    new MenuItemViewModel { Header = "Beta3", MenuIcon = "Ambulance" }
        //                }
        //        },
        //        new MenuItemViewModel { Header = "Worklist", MenuIcon = "Ambulance",  Command = new RelayCommand( () => {
        //               RaiseTapEvent("Mcap.ViewModels.WorklistViewModel");
        //               ChangeActive("Worklist");
        //            }), IsActive = true  }
        //    };
        //    DataContext = this;
        //}
    }
    
}
