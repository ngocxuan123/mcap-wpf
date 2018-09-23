using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcap.MessageInfrastructure
{
    public class MessageComunicator<T>
        where T: class
    {
        public T Item { get; set; }
    }
}
