﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FsConnect
{
    public class PauseStateChangedEventArgs : EventArgs
    {
        public bool Paused { get; set; }
    }
}
