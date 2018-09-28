using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mcap.Model.Shared
{
    public class MenuItemModel: BaseModel
    {
        #region Fields
        private ObservableCollection<MenuItemModel> _menuItems;
        private bool _isEnabled;
        private bool _isActive;
        #endregion

        #region Constructor
        public MenuItemModel()
        {
            IsEnabled = true;
        }
        #endregion

        #region Property
        public string Header { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public bool IsPopup { get; set; }
        public string MenuIcon { get; set; }
        public Image ImageIcon { get; set; }
        public bool IsEnabled
        {
            get => _isEnabled;
            set => Set(ref _isEnabled, value);
        }
        public bool IsActive
        {
            get => _isActive;
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
            get => IsActive ? "White" : "#0173C7";
        }
        public string Foreground
        {
            get => IsActive ? "Black" : "White";
        }
        public ObservableCollection<MenuItemModel> MenuItems
        {
            get => _menuItems;
            set => Set(ref _menuItems, value);
        }
        #endregion
    }
}
