using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.ViewModels
{
    public class ReportTemplateViewModel : PageViewModel
    {
        private ObservableCollection<Template> _templates;
        public ObservableCollection<Template> Templates
        {
            get => _templates;
            private set => Set(ref _templates, value);
        }
        public ReportTemplateViewModel()
        {
            Templates = new ObservableCollection<Template>()
            {
                new Template () {Code = "T001", Name = "Mẫu mô tả siêu âm ổ bụng", Status = "Cho phép"},
                new Template () {Code = "T002", Name = "Mẫu mô tả siêu âm bàng quang", Status = "Cho phép"},
                new Template () {Code = "T003", Name = "Mẫu mô tả nội soi dạ dày", Status = "Cho phép"},
                new Template () {Code = "T004", Name = "Mẫu mô tả nội soi", Status = "Tạm dừng"},
            };
        }
        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class Template
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
