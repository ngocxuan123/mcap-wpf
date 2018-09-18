using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mcap.Helper
{
    public class CommonHelper
    {
        public static Uri GetCkeditorUri ()
        {
            string curDir = Directory.GetCurrentDirectory();
            return new Uri(String.Format("file:///{0}/ckeditor.html", curDir));
        }
    }
}
