namespace FsConnect.Managers
{
    /// <summary>
    /// The <see cref="IRadioManager"/> controls the navigation and communication radios in the current aircraft.
    /// </summary>
    /// <remarks>
    /// Supports:
    /// - Get and set COM and NAV active and standby frequencies.
    /// - Get and set transponder
    ///
    /// Usage:
    /// Call <see cref="Update"/> to refresh properties with latest values from MSFS.
    /// </remarks>
    public interface IRadioManager
    {
        /// <summary>
        /// Gets the COM1 Active frequency as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        /// <remarks>
        /// The active frequency is changed by setting the COM1 standby frequency and calling <see cref="IRadioManager.COM1Swap()"/>
        /// </remarks>
        double Com1ActiveFrequency { get; }

        /// <summary>
        /// Gets the COM1 Standby frequency as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        double Com1StandbyFrequency { get; }

        /// <summary>
        /// Gets the COM2 Active frequency as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        /// <remarks>
        /// The active frequency is changed by setting the COM2 standby frequency and calling <see cref="IRadioManager.COM2Swap()"/>
        /// </remarks>
        double Com2ActiveFrequency { get; }

        /// <summary>
        /// Gets the COM2 Standby frequency as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        double Com2StandbyFrequency { get; }

        /// <summary>
        /// Gets the COM1 status as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        int Com1Status { get; }

        /// <summary>
        /// Gets the COM1 available value as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        /// <remarks>
        /// -1 = Invalid
        ///  0 = OK
        ///  1 = Does not exist
        ///  2 = No electricity
        ///  3 = Failed
        /// </remarks>
        int Com1Available { get; }

        /// <summary>
        /// Sets the COM1 standby frequency.
        /// </summary>
        /// <param name="frequency">The frequency, in MHz, e.g. 124.100</param>
        /// <remarks>
        /// Range: 118.000 to 135.975Mhz
        /// </remarks>
        void SetCom1StandbyFrequency(double frequency);

        /// <summary>
        /// Sets the COM1 active frequency.
        /// </summary>
        /// <param name="frequency">The frequency, in MHz, e.g. 124.100</param>
        /// <remarks>
        /// Range: 118.000 to 135.975Mhz
        /// </remarks>
        void SetCom1ActiveFrequency(double frequency);

        /// <summary>
        /// Sets the COM2 standby frequency.
        /// </summary>
        /// <param name="frequency">The frequency, in MHz, e.g. 124.100</param>
        /// <remarks>
        /// Range: 118.000 to 135.975Mhz
        /// </remarks>
        void SetCom2StandbyFrequency(double frequency);

        /// <summary>
        /// Sets the COM2 active frequency.
        /// </summary>
        /// <param name="frequency">The frequency, in MHz, e.g. 124.10</param>
        /// <remarks>
        /// Range: 118.000 to 135.975Mhz
        /// </remarks>
        void SetCom2ActiveFrequency(double frequency);

        /// <summary>
        /// Swaps COMS1 active and standby frequency.
        /// </summary>
        void Com1Swap();

        /// <summary>
        /// Swaps COMS2 active and standby frequency.
        /// </summary>
        void Com2Swap();

        #region NAV

        /// <summary>
        /// Gets the Nav1 Active frequency as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        /// <remarks>
        /// The active frequency is changed by setting the Nav1 standby frequency and calling <see cref="IRadioManager.Nav1Swap()"/>
        /// </remarks>
        double Nav1ActiveFrequency { get; }

        /// <summary>
        /// Gets the Nav1 Standby frequency as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        double Nav1StandbyFrequency { get; }

        /// <summary>
        /// Gets the Nav2 Active frequency as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        /// <remarks>
        /// The active frequency is changed by setting the Nav2 standby frequency and calling <see cref="IRadioManager.Nav2Swap()"/>
        /// </remarks>
        double Nav2ActiveFrequency { get; }

        /// <summary>
        /// Gets the Nav2 Standby frequency as returned from the last call with <see cref="IRadioManager.Update()"/>.
        /// </summary>
        double Nav2StandbyFrequency { get; }

        /// <summary>
        /// Gets the transponder code.
        /// </summary>
        uint TransponderCode { get; }

        /// <summary>
        /// Sets the Nav1 standby frequency.
        /// </summary>
        /// <param name="frequency">The frequency, in MHz, e.g. 124.100</param>
        /// <remarks>
        /// Range: 118.000 to 135.975Mhz
        /// </remarks>
        void SetNav1StandbyFrequency(double frequency);

        /// <summary>
        /// Sets the Nav1 active frequency.
        /// </summary>
        /// <param name="frequency">The frequency, in MHz, e.g. 124.100</param>
        /// <remarks>
        /// Range: 118.000 to 135.975Mhz
        /// </remarks>
        void SetNav1ActiveFrequency(double frequency);

        /// <summary>
        /// Sets the Nav2 standby frequency.
        /// </summary>
        /// <param name="frequency">The frequency, in MHz, e.g. 124.100</param>
        /// <remarks>
        /// Range: 118.000 to 135.975Mhz
        /// </remarks>
        void SetNav2StandbyFrequency(double frequency);

        /// <summary>
        /// Sets the Nav2 active frequency.
        /// </summary>
        /// <param name="frequency">The frequency, in MHz, e.g. 124.10</param>
        /// <remarks>
        /// Range: 118.000 to 135.975Mhz
        /// </remarks>
        void SetNav2ActiveFrequency(double frequency);

        /// <summary>
        /// Swaps NavS1 active and standby frequency.
        /// </summary>
        void Nav1Swap();

        /// <summary>
        /// Swaps NavS2 active and standby frequency.
        /// </summary>
        void Nav2Swap();

        #endregion

        /// <summary>
        /// Sets the transponder code.
        /// </summary>
        /// <param name="code"></param>
        void SetTransponderCode(uint code);

        /// <summary>
        /// Request new radio data from MSFS.
        /// </summary>
        /// <remarks>
        /// The call is blocked until an update is returned.
        /// </remarks>
        void Update();
    }
}