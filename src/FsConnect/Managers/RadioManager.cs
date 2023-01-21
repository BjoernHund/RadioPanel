using Microsoft.FlightSimulator.SimConnect;
using System;
using System.Linq;
using System.Threading;

namespace FsConnect.Managers
{
    /// <inheritdoc />
    public class RadioManager : IRadioManager, IDisposable
    {
        private bool _disposed;

        private readonly IFsConnect _fsConnect;
        private AutoResetEvent _resetEvent = new AutoResetEvent(false);
        private int _groupId;

        private int _com1StbyRadioSetHzEventId;
        private int _com1ActiveRadioSetHzEventId;
        private int _com1StbySwapEventId;

        private int _com2StbyRadioSetHzEventId;
        private int _com2ActiveRadioSetHzEventId;
        private int _com2StbySwapEventId;

        private int _nav1StbyRadioSetHzEventId;
        private int _nav1ActiveRadioSetHzEventId;
        private int _nav1StbySwapEventId;

        private int _nav2StbyRadioSetHzEventId;
        private int _nav2ActiveRadioSetHzEventId;
        private int _nav2StbySwapEventId;

        private int _setTransponderCodeEventId;

        private RadioManagerSimVars _radioManagerSimVars = new RadioManagerSimVars();

        private int _radioManagerSimVarsReqId;
        private Enum _radioManagerSimVarsReqIdEnum;
        private int _radioManagerSimVarsDefId;
        private Enum _radioManagerSimVarsDefIdEnum;

        public event EventHandler<RadioUpdatedEventsArgs> RadioUpdated;

        #region COM

        /// <inheritdoc />
        public double Com1StandbyFrequency { get; private set; }

        /// <inheritdoc />
        public double Com1ActiveFrequency { get; private set; }

        /// <inheritdoc />
        public double Com2StandbyFrequency { get; private set; }

        /// <inheritdoc />
        public double Com2ActiveFrequency { get; private set; }

        /// <inheritdoc />
        public int Com1Status { get; private set; }

        /// <inheritdoc />
        public int Com1Available { get; private set; }

        #endregion

        #region NAV

        /// <inheritdoc />
        public double Nav1StandbyFrequency { get; private set; }

        /// <inheritdoc />
        public double Nav1ActiveFrequency { get; private set; }

        /// <inheritdoc />
        public double Nav2StandbyFrequency { get; private set; }

        /// <inheritdoc />
        public double Nav2ActiveFrequency { get; private set; }

        #endregion

        public uint TransponderCode { get; private set; }

        /// <summary>
        /// Creates a new <see cref="RadioManager"/> instance.
        /// </summary>
        /// <param name="fsConnect"></param>
        public RadioManager(IFsConnect fsConnect)
        {
            _fsConnect = fsConnect;

            RegisterEvents();
        }

        public void Start()
        {
            _fsConnect?.RequestDataOnSimObject(
                _radioManagerSimVarsReqIdEnum,
                _radioManagerSimVarsDefIdEnum,
                SimConnect.SIMCONNECT_OBJECT_ID_USER,
                FsConnectPeriod.Second,
                FsConnectDRequestFlag.Changed, 0, 0, 0);
        }

        public void Stop()
        {
            _fsConnect?.RequestDataOnSimObject(
                _radioManagerSimVarsReqIdEnum,
                _radioManagerSimVarsDefIdEnum,
                SimConnect.SIMCONNECT_OBJECT_ID_USER,
                FsConnectPeriod.Never,
                0, 0, 0, 0);
        }

        /// <inheritdoc />
        public void Update()
        {
            _fsConnect.RequestData(_radioManagerSimVarsReqId, _radioManagerSimVarsDefId);
            bool resetRes = _resetEvent.WaitOne(10000);

            if (!resetRes)
                throw new TimeoutException("Radio Manager data was not returned from MSFS within timeout");

            Com1StandbyFrequency = new FrequencyBcd(_radioManagerSimVars.Com1StandbyFrequency).Value;
            Com1ActiveFrequency = new FrequencyBcd(_radioManagerSimVars.Com1ActiveFrequency).Value;
            Com2ActiveFrequency = new FrequencyBcd(_radioManagerSimVars.Com2ActiveFrequency).Value;
            Com2StandbyFrequency = new FrequencyBcd(_radioManagerSimVars.Com2StandbyFrequency).Value;

            Com1Status = _radioManagerSimVars.Com1Status;
            Com1Available = _radioManagerSimVars.Com1Available;

            Nav1StandbyFrequency = new FrequencyBcd(_radioManagerSimVars.Nav1StandbyFrequency).Value;
            Nav1ActiveFrequency = new FrequencyBcd(_radioManagerSimVars.Nav1ActiveFrequency).Value;
            Nav2ActiveFrequency = new FrequencyBcd(_radioManagerSimVars.Nav2ActiveFrequency).Value;
            Nav2StandbyFrequency = new FrequencyBcd(_radioManagerSimVars.Nav2StandbyFrequency).Value;

            TransponderCode = _radioManagerSimVars.TransponderCode;
        }

        /// <inheritdoc />
        public void SetCom1StandbyFrequency(double frequency)
        {
            FrequencyBcd freqBcd = new FrequencyBcd(frequency);
            _fsConnect.TransmitClientEvent(_com1StbyRadioSetHzEventId, freqBcd.Bcd32Value, _groupId);
        }

        /// <inheritdoc />
        public void SetCom1ActiveFrequency(double frequency)
        {
            FrequencyBcd freqBcd = new FrequencyBcd(frequency);
            _fsConnect.TransmitClientEvent(_com1ActiveRadioSetHzEventId, freqBcd.Bcd32Value, _groupId);
        }

        /// <inheritdoc />
        public void SetCom2StandbyFrequency(double frequency)
        {
            FrequencyBcd freqBcd = new FrequencyBcd(frequency);
            _fsConnect.TransmitClientEvent(_com2StbyRadioSetHzEventId, freqBcd.Bcd32Value, _groupId);
        }

        /// <inheritdoc />
        public void SetCom2ActiveFrequency(double frequency)
        {
            FrequencyBcd freqBcd = new FrequencyBcd(frequency);
            _fsConnect.TransmitClientEvent(_com2ActiveRadioSetHzEventId, freqBcd.Bcd32Value, _groupId);
        }

        /// <inheritdoc />
        public void Com1Swap()
        {
            _fsConnect.TransmitClientEvent(_com1StbySwapEventId, 0, _groupId);
        }

        /// <inheritdoc />
        public void Com2Swap()
        {
            _fsConnect.TransmitClientEvent(_com2StbySwapEventId, 0, _groupId);
        }

        /// <inheritdoc />
        public void SetNav1StandbyFrequency(double frequency)
        {
            FrequencyBcd freqBcd = new FrequencyBcd(frequency);
            _fsConnect.TransmitClientEvent(_nav1StbyRadioSetHzEventId, freqBcd.Bcd32Value, _groupId);
        }

        /// <inheritdoc />
        public void SetNav1ActiveFrequency(double frequency)
        {
            FrequencyBcd freqBcd = new FrequencyBcd(frequency);
            _fsConnect.TransmitClientEvent(_nav1ActiveRadioSetHzEventId, freqBcd.Bcd32Value, _groupId);
        }

        /// <inheritdoc />
        public void SetNav2StandbyFrequency(double frequency)
        {
            FrequencyBcd freqBcd = new FrequencyBcd(frequency);
            _fsConnect.TransmitClientEvent(_nav2StbyRadioSetHzEventId, freqBcd.Bcd32Value, _groupId);
        }

        /// <inheritdoc />
        public void SetNav2ActiveFrequency(double frequency)
        {
            FrequencyBcd freqBcd = new FrequencyBcd(frequency);
            _fsConnect.TransmitClientEvent(_nav2ActiveRadioSetHzEventId, freqBcd.Bcd32Value, _groupId);
        }

        /// <inheritdoc />
        public void Nav1Swap()
        {
            _fsConnect.TransmitClientEvent(_nav1StbySwapEventId, 0, _groupId);
        }

        /// <inheritdoc />
        public void Nav2Swap()
        {
            _fsConnect.TransmitClientEvent(_nav2StbySwapEventId, 0, _groupId);
        }

        /// <inheritdoc />
        public void SetTransponderCode(uint code)
        {
            uint bcdCode = Bcd.Dec2Bcd(code);
            _fsConnect.TransmitClientEvent(_setTransponderCodeEventId, bcdCode, _groupId);
        }

        private void RegisterEvents()
        {
            _fsConnect.FsDataReceived += OnFsDataReceived;
            _groupId = _fsConnect.GetNextId();

            #region COM

            _com1StbyRadioSetHzEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _com1StbyRadioSetHzEventId, FsEventNameId.ComStbyRadioSetHz);

            _com1ActiveRadioSetHzEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _com1ActiveRadioSetHzEventId, FsEventNameId.ComRadioSetHz);

            _com1StbySwapEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _com1StbySwapEventId, FsEventNameId.ComStbyRadioSwitchTo);

            _com2StbyRadioSetHzEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _com2StbyRadioSetHzEventId, FsEventNameId.Com2StbyRadioSetHz);

            _com2ActiveRadioSetHzEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _com2ActiveRadioSetHzEventId, FsEventNameId.Com2RadioSetHz);

            _com2StbySwapEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _com2StbySwapEventId, FsEventNameId.Com2RadioSwap);

            #endregion

            #region NAV

            _nav1StbyRadioSetHzEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _nav1StbyRadioSetHzEventId, FsEventNameId.Nav1StbyRadioSetHz);

            _nav1ActiveRadioSetHzEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _nav1ActiveRadioSetHzEventId, FsEventNameId.Nav1RadioSetHz);

            _nav1StbySwapEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _nav1StbySwapEventId, FsEventNameId.Nav1RadioSwap);

            _nav2StbyRadioSetHzEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _nav2StbyRadioSetHzEventId, FsEventNameId.Nav2StbyRadioSetHz);

            _nav2ActiveRadioSetHzEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _nav2ActiveRadioSetHzEventId, FsEventNameId.Nav2RadioSetHz);

            _nav2StbySwapEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _nav2StbySwapEventId, FsEventNameId.Nav2RadioSwap);

            #endregion

            _setTransponderCodeEventId = _fsConnect.GetNextId();
            _fsConnect.MapClientEventToSimEvent(_groupId, _setTransponderCodeEventId, FsEventNameId.XpndrSet);

            _fsConnect.SetNotificationGroupPriority(_groupId);

            _radioManagerSimVarsReqId = _fsConnect.GetNextId();
            _radioManagerSimVarsReqIdEnum = (FsConnectEnum)_radioManagerSimVarsReqId;
            _radioManagerSimVarsDefId = _fsConnect.RegisterDataDefinition<RadioManagerSimVars>();
            _radioManagerSimVarsDefIdEnum = (FsConnectEnum)_radioManagerSimVarsDefId;
        }

        private void OnFsDataReceived(object sender, FsDataReceivedEventArgs e)
        {
            try
            {
                if (e.Data == null || e.Data.Count == 0)
                {
                    return;
                }

                if (e.RequestId == _radioManagerSimVarsReqId)
                {
                    _radioManagerSimVars = (RadioManagerSimVars)e.Data.FirstOrDefault();
                    _resetEvent.Set();

                    Com1StandbyFrequency = new FrequencyBcd(_radioManagerSimVars.Com1StandbyFrequency).Value;
                    Com1ActiveFrequency = new FrequencyBcd(_radioManagerSimVars.Com1ActiveFrequency).Value;
                    Com2ActiveFrequency = new FrequencyBcd(_radioManagerSimVars.Com2ActiveFrequency).Value;
                    Com2StandbyFrequency = new FrequencyBcd(_radioManagerSimVars.Com2StandbyFrequency).Value;
                    Com1Status = _radioManagerSimVars.Com1Status;
                    Com1Available = _radioManagerSimVars.Com1Available;
                }

                var radioUpdatedEventArgs = new RadioUpdatedEventsArgs
                {
                    Com1ActiveFrequency = Com1ActiveFrequency,
                    Com1StandbyFrequency = Com1StandbyFrequency,
                    Com2ActiveFrequency = Com2ActiveFrequency,
                    Com2StandbyFrequency = Com2StandbyFrequency,
                    Com1Status = Com1Status,
                    Com1Available = Com1Available
                };

                RadioUpdated?.Invoke(this, radioUpdatedEventArgs);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not handle received MSFS data: " + ex);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                Stop();
                _fsConnect.FsDataReceived -= OnFsDataReceived;
            }

            _disposed = true;
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}