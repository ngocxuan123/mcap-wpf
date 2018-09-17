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
            _companyName = "℗ Tập đoàn VNPT";
            _hospitalName = "Đa Khoa Bưu điện";
            _userLogin = "BS. Nguyễn Hoa Vương";
            _currentDate = DateTime.Now.ToShortDateString();
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
    }
}
