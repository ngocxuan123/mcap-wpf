using GalaSoft.MvvmLight.Command;
using Mcap.Model;
using Mcap.Views;
using Mcap.Views.Element.CompleteWorklist;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Mcap.ViewModels
{
    public class CompleteViewModel : PageViewModel
    {
        private ObservableCollection<Order> _worklist;
        public ObservableCollection<Order> Worklist
        {
            get => _worklist;
            set => Set(ref _worklist, value);
        }
        private ICommand _viewCommand;
        public ICommand ViewCommand
        {
            get => _viewCommand;
            private set => Set(ref _viewCommand, value);
        }
        public CompleteViewModel()
        {
            Worklist = new ObservableCollection<Order>()
            {
                new Order(){Name = "Order 1", RequestCode = "CODE 1", IsBoarding = false},
                new Order(){Name = "Order 2", RequestCode = "CODE 2", IsBoarding = true},
                new Order(){Name = "Order 3", RequestCode = "CODE 3", IsBoarding = true}
            };
            ViewCommand = new RelayCommand(() =>
           {
               WindowDetail detail = new WindowDetail();
               detail.ShowDialog();
           });
        }
        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
