using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FsConnect
{
    public class SimStateChangedEventArgs : EventArgs
    {
        public bool Running { get; set; }
    }
}
