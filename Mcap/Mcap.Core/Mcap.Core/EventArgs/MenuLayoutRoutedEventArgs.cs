using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Mcap.Core.EventArgs
{
    public class MenuLayoutRoutedEventArgs : RoutedEventArgs
    {
        public readonly string _name;

        public string Name
        {
            get { return _name; }
        }

        public MenuLayoutRoutedEventArgs(RoutedEvent routedEvent, string Name)
            : base(routedEvent)
        {
            _name = Name;
        }
    }
}
