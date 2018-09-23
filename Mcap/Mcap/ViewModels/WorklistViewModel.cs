using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Mcap.Helper.Const;
using Mcap.MessageInfrastructure;
using Mcap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.ViewModels
{
    public class WorklistViewModel : PageViewModel
    {
        #region Fields
        private WorklistModel _worklist;
        #endregion

        #region Command
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

        private RelayCommand<Order> _sendOrderToWorkCommand;
        public RelayCommand<Order> SendOrderToWorkCommand
        {
            get
            {
                if (_sendOrderToWorkCommand == null)
                {
                    _sendOrderToWorkCommand = new RelayCommand<Order>(SendOrderToWork);
                }
                return _sendOrderToWorkCommand;
            }
        }

  
        #endregion
        public WorklistModel Worklist
        {
            get => _worklist;
            set => Set(ref _worklist, value);
        }
        #region Property
        #endregion

        #region Constructor
        [PreferredConstructorAttribute]
        public WorklistViewModel()
        {
            Init();
            // Subcrice and Init Event listening
            InitEvent();
        }
        #endregion

        #region Init
        private void InitEvent ()
        {
            ReceiveOrder();
        }
        private void Init ()
        {
            _worklist = new WorklistModel();
            _worklist.Worklist = new System.Collections.ObjectModel.ObservableCollection<Order>()
            {
                new Order(){Name = "Order 1", RequestCode = "CODE 1", IsBoarding = false},
                new Order(){Name = "Order 2", RequestCode = "CODE 2", IsBoarding = true},
                new Order(){Name = "Order 3", RequestCode = "CODE 3", IsBoarding = true}
            };
        }
        #endregion
        #region Public Method
        public override void Dispose()
        {
        }
        #endregion

        #region Private Method
        private void AddOrder() => _worklist.Worklist.Add(new Order() { Name = "Order " + (new Random().Next()), RequestCode = "COde 3" });
        private void SendOrder(Order order)
        {
            if (order != null)
            {
                Messenger.Default.Send(new OrderMessageComunicator() { Item = order }, MessageToken.SEND_ORDER_TO_DETAIL);
            }
        }
        private void SendOrderToWork(Order order)
        {
            if (order != null)
            {
                Messenger.Default.Send(new OrderMessageComunicator() { Item = order }, MessageToken.SEND_ORDER_TO_MAIN);
                SendMenuActive();
            }
        }
        private void SendMenuActive()
        {
            Messenger.Default.Send(new MenuMessageComunicator() { Item = "Work" });
        }

        private void ReceiveOrder()
        {
            Messenger.Default.Register<OrderMessageComunicator>(this, MessageToken.SEND_ORDER_TO_DETAIL, info =>
            {
                if (info != null)
                {
                    Worklist.CurrentOrder = info.Item;
                    //if (Layout!=null)
                    //{
                    //    Layout.CurrentViewModel = new WorkingViewModel();
                    //}
                }
            });
        }
        #endregion

    }
}
