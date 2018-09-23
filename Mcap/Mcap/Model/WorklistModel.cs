using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.Model
{
    public class WorklistModel : BaseModel
    {
        private ObservableCollection<Order> _worklist;
        public ObservableCollection<Order> Worklist
        {
            get => _worklist; set
            {
                _worklist = value;
                RaisePropertyChanged("Worklist");
            }
        }
        private Order _currentOrder;
        public Order CurrentOrder
        {
            get => _currentOrder; set
            {
                _currentOrder = value;
                RaisePropertyChanged("CurrentOrder");
            }
        }
    }

    public class Order : BaseModel
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private string _requestCode;
        public string RequestCode
        {
            get => _requestCode;
            set => Set(ref _requestCode, value);
        }
        public bool IsBoarding { get; set; }
    }

    public class Patient : BaseModel
    {
        public string _name;
        public string Name
        {
            get => _name; set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }
        public int _age;
        public int Age
        {
            get => _age; set
            {
                _age = value;
                RaisePropertyChanged("Age");
            }
        }
    }
}
