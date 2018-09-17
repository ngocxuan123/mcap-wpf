using GalaSoft.MvvmLight;
using Mcap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.ViewModels
{
    public class FooterViewModel: ViewModelBase
    {
        public BaseModel Footer { get; set; }

        public FooterViewModel ()
        {
            Footer = new FooterModel();
        }
    }
}
