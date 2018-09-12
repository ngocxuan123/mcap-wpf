using Mcap.Commands;
using Mcap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mcap.ViewModels
{
    internal class LoginViewModel: BaseViewModel
    {
        public UserLoginModel UserLogin { get; set; }

        private DelegateCommand loginCommand;

        public ICommand LoginCommand
        {
            get
            {
                if (loginCommand == null)
                    loginCommand = new DelegateCommand(new Action(SaveExecuted),
                       new Func<bool>(SaveCanExecute));
                return loginCommand;
            }
        }

        public LoginViewModel ()
        {
            UserLogin = new UserLoginModel() { UserName = "admin", Password = "123456", Remember = false };
        }
        
        private bool SaveCanExecute()
        {
            return !string.IsNullOrEmpty(UserLogin.UserName) && !string.IsNullOrEmpty(UserLogin.Password);
        }

        private void SaveExecuted()
        {
            System.Windows.MessageBox.Show(string.Format("Saved: {0} {1})",
                UserLogin.UserName, UserLogin.Password));
        }
    }
}
