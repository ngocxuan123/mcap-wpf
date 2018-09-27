using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.ViewModels
{
    public class ModalityViewModel : PageViewModel
    {
        private ObservableCollection<Modility> _modilities;
        public ObservableCollection<Modility> Modilities
        {
            get => _modilities;
            set => Set(ref _modilities, value);
        }
        public ModalityViewModel ()
        {
            Modilities = new ObservableCollection<Modility>()
            {
                new Modility() {Name = "PHILIPS", AET = "US2", Code = "SA.3.79023.000007", Type = "US" , Status = "CHO PHÉP"},
                new Modility() {Name = "US3", AET = "US3", Code = "2222222", Type = "US" , Status = "CHO PHÉP"},
                new Modility() {Name = "OLYMPUS", AET = "ES1", Code = "NS.3.79023.000005", Type = "ES" , Status = "Tạm dừng"}
            };
        }
        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    public class Modility
    {
        public string Name { get; set; }
        public string AET { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
