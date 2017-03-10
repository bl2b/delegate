using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasActionFunct
{
    public class CustomerChangedEventArgs: EventArgs
    {
        public Customer Customer { get; set; }
    }
}
