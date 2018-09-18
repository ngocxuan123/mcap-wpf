using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Mcap.MessageInfrastructure;
using Mcap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.ViewModels
{
    public class WorklistViewModel : BaseViewModel
    {
        private WorklistModel _worklist;
        public WorklistModel Worklist
        {
            get => _worklist; set
            {
                _worklist = value;
                RaisePropertyChanged("Worklist");
            }
        }
        private RelayCommand<Order> _sendOrderCommand;
        public RelayCommand<Order> SendOrderCommand
        {
            get
            {
                if (_sendOrderCommand == null)
                {
                    _sendOrderCommand = new RelayCommand<Order>(SendOrder);
                }
                return _sendOrderCommand;
            }
        }
        private RelayCommand _addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(AddOrder);
                }
                return _addCommand;
            }
        }
        private RelayCommand<Order> _receiveOrderCommand;
        public RelayCommand<Order> ReceiveOrderCommnd { get
            {
                return _receiveOrderCommand;
            }
        }
        public WorklistViewModel()
        {
            _worklist = new WorklistModel();
            _worklist.Worklist = new System.Collections.ObjectModel.ObservableCollection<Order>()
            {
                new Order(){Name = "Order 1", RequestCode = "CODE 1"},
                new Order(){Name = "Order 2", RequestCode = "CODE 2"},
                new Order(){Name = "Order 3", RequestCode = "CODE 3"}
            };
        }
        private void AddOrder() => _worklist.Worklist.Add(new Order() { Name = "Order " + (new Random().Next()), RequestCode = "COde 3" });
        private void SendOrder(Order order)
        {
            if (order!=null)
            {
                Messenger.Default.Send(new OrderMessageComunicator() { Order = order });
            }
        }
        private void ReceiveOrder(Order order)
        {

        }
    }
}
