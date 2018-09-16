using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.Model
{
    public class UserLoginModel : BaseModel
    {
        
        private string username;
        public string UserName
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("UserName");
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private bool remember;
        public bool Remember
        {
            get { return remember; }
            set
            {
                remember = value;
                OnPropertyChanged("Remember");
            }
        }
    }
}
