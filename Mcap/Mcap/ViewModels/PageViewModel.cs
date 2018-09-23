using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.ViewModels
{
    public abstract class PageViewModel : BaseViewModel, IDisposable
    {
        public abstract void Dispose();
    }
}
