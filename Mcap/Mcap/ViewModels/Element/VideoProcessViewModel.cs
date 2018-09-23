using Accord.Video.FFMPEG;
using AForge.Video;
using AForge.Video.DirectShow;
using GalaSoft.MvvmLight.Command;
using Mcap.Helper;
using Mcap.Model.Element;
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

namespace Mcap.ViewModels.Element
{
    public class VideoProcessViewModel : BaseViewModel, IDisposable
    {
        #region Private

        private bool _isRecording;
        private FilterInfo _currentDevice;
        private BitmapImage _image;
        private VideoProcessModel _videoProcess;
        private IVideoSource _videoSource;
        private VideoFileWriter _videoWriter;
        private DateTime? _firstFrameTime;
        private string _currentFile;
        private bool _isRunning;

        #endregion

        #region Command Property
        public ICommand ConnectVideoCommand { get; private set; }
        public ICommand CaptureCommand { get; private set; }
        public ICommand StartRecordVideoCommand { get; private set; }
        public ICommand StopRecordVideoCommand { get; private set; }
        public ICommand DisconnectVideoCommand { get; private set; }
        #endregion

        #region Constructor
        public VideoProcessViewModel()
        {
            DeviceVideos = new ObservableCollection<FilterInfo>();
            VideoProcessModel = new VideoProcessModel();
            GetVideoDivices();
            ConnectVideoCommand = new RelayCommand(ConnectVideoDevice);
            CaptureCommand = new RelayCommand(CaptureImage);
            DisconnectVideoCommand = new RelayCommand(DisconnectVideo);
            StartRecordVideoCommand = new RelayCommand(StartRecordVideo);
            StopRecordVideoCommand = new RelayCommand(StopRecordVideo);
        }
        #endregion

        #region Public Property
        public ObservableCollection<FilterInfo> DeviceVideos { get; set; }

        public bool IsRunning
        {
            get => _isRunning;
            set => Set(ref _isRunning, value);
        }

        public bool IsRecording
        {
            get => _isRecording;
            set => Set(ref _isRecording, value);
        }
        public FilterInfo CurrentDevice
        {
            get => _currentDevice;
            set => Set(ref _currentDevice, value);
        }
        public BitmapImage Image
        {
            get => _image;
            set => Set(ref _image, value);
        }
        public VideoProcessModel VideoProcessModel
        {
            get => _videoProcess;
            set => Set(ref _videoProcess, value);
        }
        #endregion

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
                if (!IsRunning)
                {
                    _videoSource = new VideoCaptureDevice(CurrentDevice.MonikerString);
                    _videoSource.NewFrame += video_NewFrame;
                    _videoSource.Start();
                    IsRunning = true;
                } else
                {
                   DisconnectVideo();
                }
            }
        }

        private void DisconnectVideo()
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.SignalToStop();
                _videoSource.NewFrame -= video_NewFrame;
            }
            Image = null;
            IsRunning = false;
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (IsRecording)
                {
                    using (var bitmap = (Bitmap)eventArgs.Frame.Clone())
                    {
                        if (_firstFrameTime != null)
                        {
                            _videoWriter.WriteVideoFrame(bitmap, DateTime.Now - _firstFrameTime.Value);
                        }
                        else
                        {
                            _videoWriter?.WriteVideoFrame(bitmap);
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
            if (Image != null)
            {
                VideoProcessModel.Images.Add(new ImageItem() { Item = Image, Label = "Hình ảnh", Order = 0 });
            }
        }


        private void StopRecordVideo()
        {
            IsRecording = false;
            _videoWriter.Close();
            _videoWriter.Dispose();
        }

        private void StartRecordVideo()
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                if (!IsRecording)
                {
                    //var frameRate = 25; // E.g. 25 FPS
                    //var bitRate = 1000000; // E.g. 1000000 is 1 Mbps
                    _firstFrameTime = null;
                    _currentFile = DateTime.Now.ToFileTime() + ".mp4";
                    _videoWriter = new VideoFileWriter();
                    _videoWriter.Open($"D:/{_currentFile}", (int)Math.Round(Image.Width, 0), (int)Math.Round(Image.Height, 0));
                    IsRecording = true;
                    VideoProcessModel.Videos.Add(new VideoItem() { Item = _currentFile, Label = "Video", Order = 1 });
                } else
                {
                    StopRecordVideo();
                }
                
            }
        }

        
        #endregion

        #region Public Method
        public void Dispose()
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.SignalToStop();
            }
            _videoWriter?.Dispose();
        }
        #endregion
    }
}
