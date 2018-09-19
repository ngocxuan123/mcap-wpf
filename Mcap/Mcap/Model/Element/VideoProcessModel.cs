using Accord.Video.FFMPEG;
using AForge.Video;
using AForge.Video.DirectShow;
using GalaSoft.MvvmLight.Command;
using Mcap.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Mcap.Model.Element
{
    public class VideoProcessModel : BaseModel
    {
        #region Private

        private bool _isRecording;
        private FilterInfo _currentDevice;
        private BitmapImage _image;
        private ObservableCollection<ImageItem> _images;
        private IVideoSource _videoSource;
        private ObservableCollection<VideoItem> _videos;
        private VideoFileWriter _videoWriter;
        private DateTime? _firstFrameTime;

        #endregion

        #region Command
        public ICommand ConnectVideoCommand { get; private set; }
        public ICommand CaptureCommand { get; set; }
        public ICommand StartRecordVideo { get; private set; }
        public ICommand StopRecordVideo { get; private set; }
        public ICommand DisconnectVideoCommand { get; set; }
        #endregion

        public VideoProcessModel()
        {
            DeviceVideos = new ObservableCollection<FilterInfo>();
            GetVideoDivices();
            ConnectVideoCommand = new RelayCommand(ConnectVideoDevice);
            CaptureCommand = new RelayCommand(CaptureImage);
            DisconnectVideoCommand = new RelayCommand(DisconnectVideo);
        }

        private void DisconnectVideo()
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.SignalToStop();
                _videoSource.NewFrame -= video_NewFrame;
            }
            Image = null;
        }

        public ObservableCollection<FilterInfo> DeviceVideos { get; set; }
        public bool IsRecording
        {
            get => _isRecording;
            set { Set(ref _isRecording, value); }
        }

        public FilterInfo CurrentDevice
        {
            get => _currentDevice;
            set { Set(ref _currentDevice, value); }
        }
        public BitmapImage Image
        {
            get => _image;
            set { Set(ref _image, value); }
        }

        #region Private Method
        private void GetVideoDivices()
        {
            var devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in devices)
            {
                DeviceVideos.Add(item);
            }
            if (DeviceVideos.Any())
            {
                CurrentDevice = DeviceVideos[0];
            }
        }

        /// <summary>
        /// Connect to Video Deivce
        /// </summary>
        private void ConnectVideoDevice()
        {
            if (CurrentDevice != null)
            {
                _videoSource = new VideoCaptureDevice(CurrentDevice.MonikerString);
                _videoSource.NewFrame += video_NewFrame;
                _videoSource.Start();
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (_isRecording)
                {
                    using (var bitmap = (Bitmap)eventArgs.Frame.Clone())
                    {
                        if (_firstFrameTime != null)
                        {
                            _videoWriter.WriteVideoFrame(bitmap, DateTime.Now - _firstFrameTime.Value);
                        }
                        else
                        {
                            _videoWriter.WriteVideoFrame(bitmap);
                            _firstFrameTime = DateTime.Now;
                        }
                    }
                }
                using (var bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    var bi = bitmap.ToBitmapImage();
                    bi.Freeze();
                    Dispatcher.CurrentDispatcher.Invoke(() => Image = bi);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error on _videoSource_NewFrame:\n" + exc.Message, "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                DisconnectVideo();
            }
        }

        /// <summary>
        /// Capture Image and save to list
        /// </summary>
        private void CaptureImage()
        {
            throw new NotImplementedException();
        }
        #endregion
    }

    public class ItemObject<T>
        where T : class
    {
        public T Item { get; set; }
        public string Label { get; set; }
        public Int16 Order { get; set; }
    }
    public class ImageItem : ItemObject<BitmapImage>
    {
    }

    public class VideoItem : ItemObject<IVideoSource>
    {
    }
}
