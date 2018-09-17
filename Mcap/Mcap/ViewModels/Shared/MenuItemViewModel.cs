using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Mcap.ViewModels
{
    public class MenuItemViewModel : BaseViewModel
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
