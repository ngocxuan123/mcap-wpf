using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.ViewModels
{
    public class ConceptViewModel : PageViewModel
    {
        public ObservableCollection<Concept> _concepts;
        public ObservableCollection<Concept> Concepts
        {
            get => _concepts;
            set => Set(ref _concepts, value);
        }
        public ConceptViewModel ()
        {
            Concepts = new ObservableCollection<Concept>()
            {
                new Concept() {Code = "18.0506.0052", Name = "Chụp động mạch phổi số hóa xóa nền (DSA)", Type = "His", Group ="Siêu âm", Status = "Cho phép"},
                new Concept() {Code = "18.0505.0052", Name = "Chụp động mạch chi (trên, dưới) số hóa xóa nền (DSA)", Type = "His", Group ="Siêu âm", Status = "Cho phép"},
                new Concept() {Code = "18.0504.0052", Name = "Chụp động mạch chậu số hóa xóa nền (DSA)", Type = "His", Group ="Siêu âm", Status = "Cho phép"},
                new Concept() {Code = "18.0503.0052", Name = "Chụp động mạch chủ số hóa xóa nền (DSA)", Type = "His", Group ="Siêu âm", Status = "Cho phép"},
                new Concept() {Code = "18.0502.0052", Name = "Chụp mạch vùng đầu mặt cổ số hóa xóa nền (DSA)", Type = "His", Group ="Siêu âm", Status = "Cho phép"},
                new Concept() {Code = "18.0501.0052", Name = "Chụp động mạch não số hóa xóa nền (DSA)", Type = "His", Group ="Siêu âm", Status = "Cho phép"},
                new Concept() {Code = "18.0500.0052", Name = "Chụp, nong động mạch và đặt stent [dưới DSA] (Chưa gồm vật tư chuyên dụng để can thiệp: bóng, stent, vòng xoắn kim loại,...)", Type = "His", Group ="Siêu âm", Status = "Cho phép"},
                new Concept() {Code = "18.0499.0052", Name = "Nong van động mạch phổi [dưới DSA] (Chưa gồm vật tư chuyên dụng để can thiệp: bóng, stent, vòng xoắn kim loại,...)", Type = "His", Group ="Siêu âm", Status = "Cho phép"}
            };
        }
        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    public class Concept
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Group { get; set; }
        public string Status { get; set; }
    }
}
