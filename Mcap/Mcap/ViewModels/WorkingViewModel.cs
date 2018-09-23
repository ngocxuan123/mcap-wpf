using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Mcap.Helper.Const;
using Mcap.MessageInfrastructure;
using Mcap.Model;
using Mcap.ViewModels.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mcap.ViewModels
{
    public class WorkingViewModel : PageViewModel
    {
        #region Private Field
        private VideoProcessViewModel _videoContext;
        private Visibility _loading;
        private Order _currentOrder;
        #endregion
        public VideoProcessViewModel VideoContext
        {
            get => _videoContext;
            set => Set(ref _videoContext, value); 
        }
        public Order CurrentOrder
        {
            get => _currentOrder;
            set => Set(ref _currentOrder, value);
        }
        public Visibility Loading
        {
            get => _loading;
            set => Set(ref _loading, value);
        }
        [PreferredConstructorAttribute]
        public WorkingViewModel()
        {
            Loading = Visibility.Visible;
            VideoContext = new VideoProcessViewModel();
            ReceiveOrder();
        }

        private void ReceiveOrder()
        {
            Messenger.Default.Register<OrderMessageComunicator>(this, MessageToken.SEND_ORDER_TO_MAIN, info =>
            {
                CurrentOrder = info.Item;
            });
        }

        public override void Dispose()
        {
            VideoContext.Dispose();
        }
    }
}
