using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Mcap.Model;
using System.Windows.Input;

namespace Mcap.ViewModels
{
    public class LoginViewModel: BaseViewModel
    {
        public UserLoginModel UserLogin { get; set; }

        private RelayCommand loginCommand;

        public ICommand LoginCommand
        {
            get
            {
                if (loginCommand == null)
                    loginCommand = new RelayCommand(LoginExecuted,LoginCanExecute , false);
                return loginCommand;
            }
        }

        public LoginViewModel ()
        {
            UserLogin = new UserLoginModel() { UserName = "admin", Password = "123456", Remember = false };
        }
        
        private bool LoginCanExecute()
        {
            return !string.IsNullOrEmpty(UserLogin.UserName) && !string.IsNullOrEmpty(UserLogin.Password);
        }

        private void LoginExecuted()
        {
            System.Windows.MessageBox.Show(string.Format("Saved: {0} {1})",
                UserLogin.UserName, UserLogin.Password));
        }
    }
}
