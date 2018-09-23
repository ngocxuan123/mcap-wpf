using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Mcap.MessageInfrastructure;
using Mcap.Model.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mcap.ViewModels.Shared
{
    public class ToolbarMenuViewModel: BaseViewModel
    {
        #region Private Field
        private ObservableCollection<MenuItemModel> _menuItems;
        private RelayCommand<string> _changeMenuActive;
        #endregion
        #region Constructor
        public ToolbarMenuViewModel()
        {
            MenuItems = new ObservableCollection<MenuItemModel>();
            ChangeMenuActive = new RelayCommand<string>(SendMenuActive);
        }
        #endregion

        #region Public Property
        public ObservableCollection<MenuItemModel> MenuItems
        {
            get => _menuItems;
            set => Set(ref _menuItems, value);
        }
        #endregion

        public RelayCommand<string> ChangeMenuActive
        {
            get => _changeMenuActive;
            private set => Set(ref _changeMenuActive, value);
        }

        public void SendMenuActive(string menu)
        {
            if (menu != null)
            {
                Messenger.Default.Send<MenuMessageComunicator>(new MenuMessageComunicator() { Item = menu });
            }
        }
    }
}
