using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Mcap.Model.Element
{
    public class VideoProcessModel: BaseModel
    {
        private ObservableCollection<ImageItem> _images;
        private ObservableCollection<VideoItem> _videos;

        public VideoProcessModel()
        {
            Images = new ObservableCollection<ImageItem>();
            Videos = new ObservableCollection<VideoItem>();
        }
        public ObservableCollection<ImageItem> Images
        {
            get => _images;
            set => Set(ref _images, value);
        }

        public ObservableCollection<VideoItem> Videos
        {
            get => _videos;
            set => Set(ref _videos, value);
        }

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

    public class VideoItem : ItemObject<string>
    {
    }
}
