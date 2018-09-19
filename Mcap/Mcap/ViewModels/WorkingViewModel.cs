using GalaSoft.MvvmLight;
using Mcap.Model.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mcap.ViewModels
{
    public class WorkingViewModel : BaseViewModel
    {
        #region Private Field
        private VideoProcessModel _videoContext;
        private Visibility _loading;
        #endregion
        public VideoProcessModel VideoContext
        {
            get => _videoContext;
            set => Set(ref _videoContext, value); 
        }
        public Visibility Loading
        {
            get => _loading;
            set
            {
                _loading = value;
                RaisePropertyChanged("Loading");
            }
        }

        public WorkingViewModel()
        {
            Loading = Visibility.Visible;
            VideoContext = new VideoProcessModel();
        }
    }
}
