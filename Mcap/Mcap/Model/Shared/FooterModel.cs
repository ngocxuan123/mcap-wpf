using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.Model
{
    public class FooterModel : BaseModel
    {
        public FooterModel()
        {
            _companyUri = "https://wwww.itvnpt.vn";
            _companyName = "Bản quyền thuộc ℗ Tập đoàn VNPT";
            _hospitalName = "Bệnh viện Đa Khoa Bưu điện";
            _userLogin = "BS. Nguyễn Hoa Vương";
            DateTime now = DateTime.Now;
            _currentDate = now.ToString("dd/MM/yyyy");
            _clock = now.ToString("HH:mm:ss");
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += (sender, args) => {
                DateTime clockNow = DateTime.Now;
                Clock = DateTime.Now.ToString("HH:mm:ss");
            };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        public FooterModel(string companyUri, string companyName, string hostpitalName, string userLogin)
        {
            _companyUri = companyUri;
            _companyName = companyName;
            _userLogin = userLogin;
            _hospitalName = hostpitalName;

        }
        private string _hospitalName;
        public string HospitalName
        {
            get => _hospitalName;
            set
            {
                _hospitalName = value;
                RaisePropertyChanged("HospitalName");
            }
        }
        private string _companyUri;
        public string CompanyUri
        {
            get => _companyUri;
            set
            {
                _companyUri = value;
                RaisePropertyChanged("CompanyUri");
            }
        }
        private string _companyName;
        public string CompanyName
        {
            get => _companyName;
            set
            {
                _companyName = value;
                RaisePropertyChanged("CompanyName");
            }
        }
        private string _userLogin;
        public string UserLogin
        {
            get => _userLogin;
            set
            {
                _userLogin = value;
                RaisePropertyChanged("UserLogin");
            }
        }
        private string _currentDate;
        public string CurrentDate
        {
            get => _currentDate;
            set
            {
                _currentDate = value;
                RaisePropertyChanged("CurrentDate");
            }
        }

        public string _clock;
        public string Clock
        {
            get => _clock;
            set
            {
                _clock = value;
                RaisePropertyChanged("Clock");
            }
        }
    }
}
