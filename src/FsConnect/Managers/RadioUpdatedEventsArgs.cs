using System;

namespace FsConnect.Managers
{
    public class RadioUpdatedEventsArgs : EventArgs
    {
        public double Com1StandbyFrequency { get; init; }

        public double Com1ActiveFrequency { get; init; }

        public double Com2StandbyFrequency { get; init; }

        public double Com2ActiveFrequency { get; init; }

        public int Com1Status { get; init; }
        
        public int Com1Available { get; init; }
    }
}
