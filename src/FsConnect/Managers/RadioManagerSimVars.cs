using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;

namespace FsConnect.Managers
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    internal struct RadioManagerSimVars
    {
        [SimVar(NameId = FsSimVar.ComActiveFrequency, UnitId = FsUnit.FrequencyBcd32, Instance = 1)]
        public uint Com1ActiveFrequency;

        [SimVar(NameId = FsSimVar.ComStandbyFrequency, UnitId = FsUnit.FrequencyBcd32, Instance = 1)]
        public uint Com1StandbyFrequency;

        [SimVar(NameId = FsSimVar.ComActiveFrequency, UnitId = FsUnit.FrequencyBcd32, Instance = 2)]
        public uint Com2ActiveFrequency;

        [SimVar(NameId = FsSimVar.ComStandbyFrequency, UnitId = FsUnit.FrequencyBcd32, Instance = 2)]
        public uint Com2StandbyFrequency;

        [SimVar(NameId = FsSimVar.NavActiveFrequency, UnitId = FsUnit.FrequencyBcd32, Instance = 1)]
        public uint Nav1ActiveFrequency;

        [SimVar(NameId = FsSimVar.NavStandbyFrequency, UnitId = FsUnit.FrequencyBcd32, Instance = 1)]
        public uint Nav1StandbyFrequency;

        [SimVar(NameId = FsSimVar.NavActiveFrequency, UnitId = FsUnit.FrequencyBcd32, Instance = 2)]
        public uint Nav2ActiveFrequency;

        [SimVar(NameId = FsSimVar.NavStandbyFrequency, UnitId = FsUnit.FrequencyBcd32, Instance = 2)]
        public uint Nav2StandbyFrequency;

        [SimVar(NameId = FsSimVar.TransponderCode, UnitId = FsUnit.Enum, Instance = 1, DataType = SIMCONNECT_DATATYPE.INT64)]
        public uint TransponderCode;

        [SimVar(NameId = FsSimVar.ComStatus, UnitId = FsUnit.Bool, Instance = 1)]
        public int Com1Status;

        [SimVar(NameId = FsSimVar.ComAvailable, UnitId = FsUnit.Enum, Instance = 1)]
        public int Com1Available;
    }
}