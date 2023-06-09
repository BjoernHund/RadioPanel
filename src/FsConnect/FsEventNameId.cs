namespace FsConnect
{
    /// <summary>
    /// The <see cref="FsEventNameId"/> enum contains all known events.
    /// </summary>
    /// <remarks>
    /// Note: This list is based on known legacy events. Not all events are supported by Microsoft Flight Simulator 2020.
    /// </remarks>
    public enum FsEventNameId
    {
        /// <summary>
        /// Set throttles max
        /// </summary>
        ThrottleFull,
        /// <summary>
        /// Increment throttles
        /// </summary>
        ThrottleIncr,
        /// <summary>
        /// Increment throttles small
        /// </summary>
        ThrottleIncrSmall,
        /// <summary>
        /// Decrement throttles
        /// </summary>
        ThrottleDecr,
        /// <summary>
        /// Decrease throttles small
        /// </summary>
        ThrottleDecrSmall,
        /// <summary>
        /// Set throttles to idle
        /// </summary>
        ThrottleCut,
        /// <summary>
        /// Increment throttles
        /// </summary>
        IncreaseThrottle,
        /// <summary>
        /// Decrement throttles
        /// </summary>
        DecreaseThrottle,
        /// <summary>
        /// Set throttles exactly (0- 16383)
        /// </summary>
        ThrottleSet,
        /// <summary>
        /// Set throttles (0- 16383)
        /// </summary>
        AxisThrottleSet,
        /// <summary>
        /// Set throttle 1 exactly (0 to 16383)
        /// </summary>
        Throttle1Set,
        /// <summary>
        /// Set throttle 2 exactly (0 to 16383)
        /// </summary>
        Throttle2Set,
        /// <summary>
        /// Set throttle 3 exactly (0 to 16383)
        /// </summary>
        Throttle3Set,
        /// <summary>
        /// Set throttle 4 exactly (0 to 16383)
        /// </summary>
        Throttle4Set,
        /// <summary>
        /// Set throttle 1 max
        /// </summary>
        Throttle1Full,
        /// <summary>
        /// Increment throttle 1
        /// </summary>
        Throttle1Incr,
        /// <summary>
        /// Increment throttle 1 small
        /// </summary>
        Throttle1IncrSmall,
        /// <summary>
        /// Decrement throttle 1
        /// </summary>
        Throttle1Decr,
        /// <summary>
        /// Set throttle 1 to idle
        /// </summary>
        Throttle1Cut,
        /// <summary>
        /// Set throttle 2 max
        /// </summary>
        Throttle2Full,
        /// <summary>
        /// Increment throttle 2
        /// </summary>
        Throttle2Incr,
        /// <summary>
        /// Increment throttle 2 small
        /// </summary>
        Throttle2IncrSmall,
        /// <summary>
        /// Decrement throttle 2
        /// </summary>
        Throttle2Decr,
        /// <summary>
        /// Set throttle 2 to idle
        /// </summary>
        Throttle2Cut,
        /// <summary>
        /// Set throttle 3 max
        /// </summary>
        Throttle3Full,
        /// <summary>
        /// Increment throttle 3
        /// </summary>
        Throttle3Incr,
        /// <summary>
        /// Increment throttle 3 small
        /// </summary>
        Throttle3IncrSmall,
        /// <summary>
        /// Decrement throttle 3
        /// </summary>
        Throttle3Decr,
        /// <summary>
        /// Set throttle 3 to idle
        /// </summary>
        Throttle3Cut,
        /// <summary>
        /// Set throttle 1 max
        /// </summary>
        Throttle4Full,
        /// <summary>
        /// Increment throttle 4
        /// </summary>
        Throttle4Incr,
        /// <summary>
        /// Increment throttle 4 small
        /// </summary>
        Throttle4IncrSmall,
        /// <summary>
        /// Decrement throttle 4
        /// </summary>
        Throttle4Decr,
        /// <summary>
        /// Set throttle 4 to idle
        /// </summary>
        Throttle4Cut,
        /// <summary>
        /// Set throttles to 10%
        /// </summary>
        Throttle10,
        /// <summary>
        /// Set throttles to 20%
        /// </summary>
        Throttle20,
        /// <summary>
        /// Set throttles to 30%
        /// </summary>
        Throttle30,
        /// <summary>
        /// Set throttles to 40%
        /// </summary>
        Throttle40,
        /// <summary>
        /// Set throttles to 50%
        /// </summary>
        Throttle50,
        /// <summary>
        /// Set throttles to 60%
        /// </summary>
        Throttle60,
        /// <summary>
        /// Set throttles to 70%
        /// </summary>
        Throttle70,
        /// <summary>
        /// Set throttles to 80%
        /// </summary>
        Throttle80,
        /// <summary>
        /// Set throttles to 90%
        /// </summary>
        Throttle90,
        /// <summary>
        /// Set throttle 1 exactly (-16383 - +16383)
        /// </summary>
        AxisThrottle1Set,
        /// <summary>
        /// Set throttle 2 exactly (-16383 - +16383)
        /// </summary>
        AxisThrottle2Set,
        /// <summary>
        /// Set throttle 3 exactly (-16383 - +16383)
        /// </summary>
        AxisThrottle3Set,
        /// <summary>
        /// Set throttle 4 exactly (-16383 - +16383)
        /// </summary>
        AxisThrottle4Set,
        /// <summary>
        /// Decrease throttle 1 small
        /// </summary>
        Throttle1DecrSmall,
        /// <summary>
        /// Decrease throttle 2 small
        /// </summary>
        Throttle2DecrSmall,
        /// <summary>
        /// Decrease throttle 3 small
        /// </summary>
        Throttle3DecrSmall,
        /// <summary>
        /// Decrease throttle 4 small
        /// </summary>
        Throttle4DecrSmall,
        /// <summary>
        /// Decrease prop levers small
        /// </summary>
        PropPitchDecrSmall,
        /// <summary>
        /// Decrease prop lever 1 small
        /// </summary>
        PropPitch1DecrSmall,
        /// <summary>
        /// Decrease prop lever 2 small
        /// </summary>
        PropPitch2DecrSmall,
        /// <summary>
        /// Decrease prop lever 3 small
        /// </summary>
        PropPitch3DecrSmall,
        /// <summary>
        /// Decrease prop lever 4 small
        /// </summary>
        PropPitch4DecrSmall,
        /// <summary>
        /// Set mixture lever 1 to max rich
        /// </summary>
        Mixture1Rich,
        /// <summary>
        /// Increment mixture lever 1
        /// </summary>
        Mixture1Incr,
        /// <summary>
        /// Increment mixture lever 1 small
        /// </summary>
        Mixture1IncrSmall,
        /// <summary>
        /// Decrement mixture lever 1
        /// </summary>
        Mixture1Decr,
        /// <summary>
        /// Set mixture lever 1 to max lean
        /// </summary>
        Mixture1Lean,
        /// <summary>
        /// Set mixture lever 2 to max rich
        /// </summary>
        Mixture2Rich,
        /// <summary>
        /// Increment mixture lever 2
        /// </summary>
        Mixture2Incr,
        /// <summary>
        /// Increment mixture lever 2 small
        /// </summary>
        Mixture2IncrSmall,
        /// <summary>
        /// Decrement mixture lever 2
        /// </summary>
        Mixture2Decr,
        /// <summary>
        /// Set mixture lever 2 to max lean
        /// </summary>
        Mixture2Lean,
        /// <summary>
        /// Set mixture lever 3 to max rich
        /// </summary>
        Mixture3Rich,
        /// <summary>
        /// Increment mixture lever 3
        /// </summary>
        Mixture3Incr,
        /// <summary>
        /// Increment mixture lever 3 small
        /// </summary>
        Mixture3IncrSmall,
        /// <summary>
        /// Decrement mixture lever 3
        /// </summary>
        Mixture3Decr,
        /// <summary>
        /// Set mixture lever 3 to max lean
        /// </summary>
        Mixture3Lean,
        /// <summary>
        /// Set mixture lever 4 to max rich
        /// </summary>
        Mixture4Rich,
        /// <summary>
        /// Increment mixture lever 4
        /// </summary>
        Mixture4Incr,
        /// <summary>
        /// Increment mixture lever 4 small
        /// </summary>
        Mixture4IncrSmall,
        /// <summary>
        /// Decrement mixture lever 4
        /// </summary>
        Mixture4Decr,
        /// <summary>
        /// Set mixture lever 4 to max lean
        /// </summary>
        Mixture4Lean,
        /// <summary>
        /// Set mixture levers to exact value (0 to 16383)
        /// </summary>
        MixtureSet,
        /// <summary>
        /// Set mixture levers to max rich
        /// </summary>
        MixtureRich,
        /// <summary>
        /// Increment mixture levers
        /// </summary>
        MixtureIncr,
        /// <summary>
        /// Increment mixture levers small
        /// </summary>
        MixtureIncrSmall,
        /// <summary>
        /// Decrement mixture levers
        /// </summary>
        MixtureDecr,
        /// <summary>
        /// Set mixture levers to max lean
        /// </summary>
        MixtureLean,
        /// <summary>
        /// Set mixture lever 1 exact value (0 to 16383)
        /// </summary>
        Mixture1Set,
        /// <summary>
        /// Set mixture lever 2 exact value (0 to 16383)
        /// </summary>
        Mixture2Set,
        /// <summary>
        /// Set mixture lever 3 exact value (0 to 16383)
        /// </summary>
        Mixture3Set,
        /// <summary>
        /// Set mixture lever 4 exact value (0 to 16383)
        /// </summary>
        Mixture4Set,
        /// <summary>
        /// Set mixture lever 1 exact value (-16383 to +16383)
        /// </summary>
        AxisMixtureSet,
        /// <summary>
        /// Set mixture lever 1 exact value (-16383 to +16383)
        /// </summary>
        AxisMixture1Set,
        /// <summary>
        /// Set mixture lever 2 exact value (-16383 to +16383)
        /// </summary>
        AxisMixture2Set,
        /// <summary>
        /// Set mixture lever 3 exact value (-16383 to +16383)
        /// </summary>
        AxisMixture3Set,
        /// <summary>
        /// Set mixture lever 4 exact value (-16383 to +16383)
        /// </summary>
        AxisMixture4Set,
        /// <summary>
        /// Set mixture levers to current best power setting
        /// </summary>
        MixtureSetBest,
        /// <summary>
        /// Decrement mixture levers small
        /// </summary>
        MixtureDecrSmall,
        /// <summary>
        /// Decrement mixture lever 1 small
        /// </summary>
        Mixture1DecrSmall,
        /// <summary>
        /// Decrement mixture lever 4 small
        /// </summary>
        Mixture2DecrSmall,
        /// <summary>
        /// Decrement mixture lever 4 small
        /// </summary>
        Mixture3DecrSmall,
        /// <summary>
        /// Decrement mixture lever 4 small
        /// </summary>
        Mixture4DecrSmall,
        /// <summary>
        /// Set prop pitch levers (0 to 16383)
        /// </summary>
        PropPitchSet,
        /// <summary>
        /// Set prop pitch levers max (lo pitch)
        /// </summary>
        PropPitchLo,
        /// <summary>
        /// Increment prop pitch levers
        /// </summary>
        PropPitchIncr,
        /// <summary>
        /// Increment prop pitch levers small
        /// </summary>
        PropPitchIncrSmall,
        /// <summary>
        /// Decrement prop pitch levers
        /// </summary>
        PropPitchDecr,
        /// <summary>
        /// Set prop pitch levers min (hi pitch)
        /// </summary>
        PropPitchHi,
        /// <summary>
        /// Set prop pitch lever 1 exact value (0 to 16383)
        /// </summary>
        PropPitch1Set,
        /// <summary>
        /// Set prop pitch lever 2 exact value (0 to 16383)
        /// </summary>
        PropPitch2Set,
        /// <summary>
        /// Set prop pitch lever 3 exact value (0 to 16383)
        /// </summary>
        PropPitch3Set,
        /// <summary>
        /// Set prop pitch lever 4 exact value (0 to 16383)
        /// </summary>
        PropPitch4Set,
        /// <summary>
        /// Set prop pitch lever 1 max (lo pitch)
        /// </summary>
        PropPitch1Lo,
        /// <summary>
        /// Increment prop pitch lever 1
        /// </summary>
        PropPitch1Incr,
        /// <summary>
        /// Increment prop pitch lever 1 small
        /// </summary>
        PropPitch1IncrSmall,
        /// <summary>
        /// Decrement prop pitch lever 1
        /// </summary>
        PropPitch1Decr,
        /// <summary>
        /// Set prop pitch lever 1 min (hi pitch)
        /// </summary>
        PropPitch1Hi,
        /// <summary>
        /// Set prop pitch lever 2 max (lo pitch)
        /// </summary>
        PropPitch2Lo,
        /// <summary>
        /// Increment prop pitch lever 2
        /// </summary>
        PropPitch2Incr,
        /// <summary>
        /// Increment prop pitch lever 2 small
        /// </summary>
        PropPitch2IncrSmall,
        /// <summary>
        /// Decrement prop pitch lever 2
        /// </summary>
        PropPitch2Decr,
        /// <summary>
        /// Set prop pitch lever 2 min (hi pitch)
        /// </summary>
        PropPitch2Hi,
        /// <summary>
        /// Set prop pitch lever 3 max (lo pitch)
        /// </summary>
        PropPitch3Lo,
        /// <summary>
        /// Increment prop pitch lever 3
        /// </summary>
        PropPitch3Incr,
        /// <summary>
        /// Increment prop pitch lever 3 small
        /// </summary>
        PropPitch3IncrSmall,
        /// <summary>
        /// Decrement prop pitch lever 3
        /// </summary>
        PropPitch3Decr,
        /// <summary>
        /// Set prop pitch lever 3 min (hi pitch)
        /// </summary>
        PropPitch3Hi,
        /// <summary>
        /// Set prop pitch lever 4 max (lo pitch)
        /// </summary>
        PropPitch4Lo,
        /// <summary>
        /// Increment prop pitch lever 4
        /// </summary>
        PropPitch4Incr,
        /// <summary>
        /// Increment prop pitch lever 4 small
        /// </summary>
        PropPitch4IncrSmall,
        /// <summary>
        /// Decrement prop pitch lever 4
        /// </summary>
        PropPitch4Decr,
        /// <summary>
        /// Set prop pitch lever 4 min (hi pitch)
        /// </summary>
        PropPitch4Hi,
        /// <summary>
        /// Set propeller levers exact value (-16383 to +16383)
        /// </summary>
        AxisPropellerSet,
        /// <summary>
        /// Set propeller lever 1 exact value (-16383 to +16383)
        /// </summary>
        AxisPropeller1Set,
        /// <summary>
        /// Set propeller lever 2 exact value (-16383 to +16383)
        /// </summary>
        AxisPropeller2Set,
        /// <summary>
        /// Set propeller lever 3 exact value (-16383 to +16383)
        /// </summary>
        AxisPropeller3Set,
        /// <summary>
        /// Set propeller lever 4 exact value (-16383 to +16383)
        /// </summary>
        AxisPropeller4Set,
        /// <summary>
        /// Selects jet engine starter (for +/- sequence)
        /// </summary>
        JetStarter,
        /// <summary>
        /// Sets magnetos (0,1)
        /// </summary>
        StarterSet,
        /// <summary>
        /// Toggle starter 1
        /// </summary>
        ToggleStarter1,
        /// <summary>
        /// Toggle starter 2
        /// </summary>
        ToggleStarter2,
        /// <summary>
        /// Toggle starter 3
        /// </summary>
        ToggleStarter3,
        /// <summary>
        /// Toggle starter 4
        /// </summary>
        ToggleStarter4,
        /// <summary>
        /// Toggle starters
        /// </summary>
        ToggleAllStarters,
        /// <summary>
        /// Triggers auto-start
        /// </summary>
        EngineAutoStart,
        /// <summary>
        /// Triggers auto-shutdown
        /// </summary>
        EngineAutoShutdown,
        /// <summary>
        /// Selects magnetos (for +/- sequence)
        /// </summary>
        Magneto,
        /// <summary>
        /// Decrease magneto switches positions
        /// </summary>
        MagnetoDecr,
        /// <summary>
        /// Increase magneto switches positions
        /// </summary>
        MagnetoIncr,
        /// <summary>
        /// Set engine 1 magnetos off
        /// </summary>
        Magneto1Off,
        /// <summary>
        /// Toggle engine 1 right magneto
        /// </summary>
        Magneto1Right,
        /// <summary>
        /// Toggle engine 1 left magneto
        /// </summary>
        Magneto1Left,
        /// <summary>
        /// Set engine 1 magnetos on
        /// </summary>
        Magneto1Both,
        /// <summary>
        /// Set engine 1 magnetos on and toggle starter
        /// </summary>
        Magneto1Start,
        /// <summary>
        /// Set engine 2 magnetos off
        /// </summary>
        Magneto2Off,
        /// <summary>
        /// Toggle engine 2 right magneto
        /// </summary>
        Magneto2Right,
        /// <summary>
        /// Toggle engine 2 left magneto
        /// </summary>
        Magneto2Left,
        /// <summary>
        /// Set engine 2 magnetos on
        /// </summary>
        Magneto2Both,
        /// <summary>
        /// Set engine 2 magnetos on and toggle starter
        /// </summary>
        Magneto2Start,
        /// <summary>
        /// Set engine 3 magnetos off
        /// </summary>
        Magneto3Off,
        /// <summary>
        /// Toggle engine 3 right magneto
        /// </summary>
        Magneto3Right,
        /// <summary>
        /// Toggle engine 3 left magneto
        /// </summary>
        Magneto3Left,
        /// <summary>
        /// Set engine 3 magnetos on
        /// </summary>
        Magneto3Both,
        /// <summary>
        /// Set engine 3 magnetos on and toggle starter
        /// </summary>
        Magneto3Start,
        /// <summary>
        /// Set engine 4 magnetos off
        /// </summary>
        Magneto4Off,
        /// <summary>
        /// Toggle engine 4 right magneto
        /// </summary>
        Magneto4Right,
        /// <summary>
        /// Toggle engine 4 left magneto
        /// </summary>
        Magneto4Left,
        /// <summary>
        /// Set engine 4 magnetos on
        /// </summary>
        Magneto4Both,
        /// <summary>
        /// Set engine 4 magnetos on and toggle starter
        /// </summary>
        Magneto4Start,
        /// <summary>
        /// Set engine magnetos off
        /// </summary>
        MagnetoOff,
        /// <summary>
        /// Set engine right magnetos on
        /// </summary>
        MagnetoRight,
        /// <summary>
        /// Set engine left magnetos on
        /// </summary>
        MagnetoLeft,
        /// <summary>
        /// Set engine magnetos on
        /// </summary>
        MagnetoBoth,
        /// <summary>
        /// Set engine magnetos on and toggle starters
        /// </summary>
        MagnetoStart,
        /// <summary>
        /// Decrease engine 1 magneto switch position
        /// </summary>
        Magneto1Decr,
        /// <summary>
        /// Increase engine 1 magneto switch position
        /// </summary>
        Magneto1Incr,
        /// <summary>
        /// Decrease engine 2 magneto switch position
        /// </summary>
        Magneto2Decr,
        /// <summary>
        /// Increase engine 2 magneto switch position
        /// </summary>
        Magneto2Incr,
        /// <summary>
        /// Decrease engine 3 magneto switch position
        /// </summary>
        Magneto3Decr,
        /// <summary>
        /// Increase engine 3 magneto switch position
        /// </summary>
        Magneto3Incr,
        /// <summary>
        /// Decrease engine 4 magneto switch position
        /// </summary>
        Magneto4Decr,
        /// <summary>
        /// Increase engine 4 magneto switch position
        /// </summary>
        Magneto4Incr,
        /// <summary>
        /// Set engine 1 magneto switch
        /// </summary>
        Magneto1Set,
        /// <summary>
        /// Set engine 2 magneto switch
        /// </summary>
        Magneto2Set,
        /// <summary>
        /// Set engine 3 magneto switch
        /// </summary>
        Magneto3Set,
        /// <summary>
        /// Set engine 4 magneto switch
        /// </summary>
        Magneto4Set,
        /// <summary>
        /// Sets anti-ice switches on
        /// </summary>
        AntiIceOn,
        /// <summary>
        /// Sets anti-ice switches off
        /// </summary>
        AntiIceOff,
        /// <summary>
        /// Sets anti-ice switches from argument (0,1)
        /// </summary>
        AntiIceSet,
        /// <summary>
        /// Toggle anti-ice switches
        /// </summary>
        AntiIceToggle,
        /// <summary>
        /// Toggle engine 1 anti-ice switch
        /// </summary>
        AntiIceToggleEng1,
        /// <summary>
        /// Toggle engine 2 anti-ice switch
        /// </summary>
        AntiIceToggleEng2,
        /// <summary>
        /// Toggle engine 3 anti-ice switch
        /// </summary>
        AntiIceToggleEng3,
        /// <summary>
        /// Toggle engine 4 anti-ice switch
        /// </summary>
        AntiIceToggleEng4,
        /// <summary>
        /// Sets engine 1 anti-ice switch (0,1)
        /// </summary>
        AntiIceSetEng1,
        /// <summary>
        /// Sets engine 2 anti-ice switch (0,1)
        /// </summary>
        AntiIceSetEng2,
        /// <summary>
        /// Sets engine 3 anti-ice switch (0,1)
        /// </summary>
        AntiIceSetEng3,
        /// <summary>
        /// Sets engine 4 anti-ice switch (0,1)
        /// </summary>
        AntiIceSetEng4,
        /// <summary>
        /// Toggle engine fuel valves
        /// </summary>
        ToggleFuelValveAll,
        /// <summary>
        /// Toggle engine 1 fuel valve
        /// </summary>
        ToggleFuelValveEng1,
        /// <summary>
        /// Toggle engine 2 fuel valve
        /// </summary>
        ToggleFuelValveEng2,
        /// <summary>
        /// Toggle engine 3 fuel valve
        /// </summary>
        ToggleFuelValveEng3,
        /// <summary>
        /// Toggle engine 4 fuel valve
        /// </summary>
        ToggleFuelValveEng4,
        /// <summary>
        /// Sets engine 1 cowl flap lever position (0 to 16383)
        /// </summary>
        Cowlflap1Set,
        /// <summary>
        /// Sets engine 2 cowl flap lever position (0 to 16383)
        /// </summary>
        Cowlflap2Set,
        /// <summary>
        /// Sets engine 3 cowl flap lever position (0 to 16383)
        /// </summary>
        Cowlflap3Set,
        /// <summary>
        /// Sets engine 4 cowl flap lever position (0 to 16383)
        /// </summary>
        Cowlflap4Set,
        /// <summary>
        /// Increment cowl flap levers
        /// </summary>
        IncCowlFlaps,
        /// <summary>
        /// Decrement cowl flap levers
        /// </summary>
        DecCowlFlaps,
        /// <summary>
        /// Increment engine 1 cowl flap lever
        /// </summary>
        IncCowlFlaps1,
        /// <summary>
        /// Decrement engine 1 cowl flap lever
        /// </summary>
        DecCowlFlaps1,
        /// <summary>
        /// Increment engine 2 cowl flap lever
        /// </summary>
        IncCowlFlaps2,
        /// <summary>
        /// Decrement engine 2 cowl flap lever
        /// </summary>
        DecCowlFlaps2,
        /// <summary>
        /// Increment engine 3 cowl flap lever
        /// </summary>
        IncCowlFlaps3,
        /// <summary>
        /// Decrement engine 3 cowl flap lever
        /// </summary>
        DecCowlFlaps3,
        /// <summary>
        /// Increment engine 4 cowl flap lever
        /// </summary>
        IncCowlFlaps4,
        /// <summary>
        /// Decrement engine 4 cowl flap lever
        /// </summary>
        DecCowlFlaps4,
        /// <summary>
        /// Toggle electric fuel pumps
        /// </summary>
        FuelPump,
        /// <summary>
        /// Toggle electric fuel pumps
        /// </summary>
        ToggleElectFuelPump,
        /// <summary>
        /// Toggle engine 1 electric fuel pump
        /// </summary>
        ToggleElectFuelPump1,
        /// <summary>
        /// Toggle engine 2 electric fuel pump
        /// </summary>
        ToggleElectFuelPump2,
        /// <summary>
        /// Toggle engine 3 electric fuel pump
        /// </summary>
        ToggleElectFuelPump3,
        /// <summary>
        /// Toggle engine 4 electric fuel pump
        /// </summary>
        ToggleElectFuelPump4,
        /// <summary>
        /// Trigger engine primers
        /// </summary>
        EnginePrimer,
        /// <summary>
        /// Trigger engine primers
        /// </summary>
        TogglePrimer,
        /// <summary>
        /// Trigger engine 1 primer
        /// </summary>
        TogglePrimer1,
        /// <summary>
        /// Trigger engine 2 primer
        /// </summary>
        TogglePrimer2,
        /// <summary>
        /// Trigger engine 3 primer
        /// </summary>
        TogglePrimer3,
        /// <summary>
        /// Trigger engine 4 primer
        /// </summary>
        TogglePrimer4,
        /// <summary>
        /// Trigger propeller switches
        /// </summary>
        ToggleFeatherSwitches,
        /// <summary>
        /// Trigger propeller 1 switch
        /// </summary>
        ToggleFeatherSwitch1,
        /// <summary>
        /// Trigger propeller 2 switch
        /// </summary>
        ToggleFeatherSwitch2,
        /// <summary>
        /// Trigger propeller 3 switch
        /// </summary>
        ToggleFeatherSwitch3,
        /// <summary>
        /// Trigger propeller 4 switch
        /// </summary>
        ToggleFeatherSwitch4,
        /// <summary>
        /// Turns propeller synchronization switch on
        /// </summary>
        TogglePropSync,
        /// <summary>
        /// Turns auto-feather arming switch on.
        /// </summary>
        ToggleArmAutofeather,
        /// <summary>
        /// Toggles afterburners
        /// </summary>
        ToggleAfterburner,
        /// <summary>
        /// Toggles engine 1 afterburner
        /// </summary>
        ToggleAfterburner1,
        /// <summary>
        /// Toggles engine 2 afterburner
        /// </summary>
        ToggleAfterburner2,
        /// <summary>
        /// Toggles engine 3 afterburner
        /// </summary>
        ToggleAfterburner3,
        /// <summary>
        /// Toggles engine 4 afterburner
        /// </summary>
        ToggleAfterburner4,
        /// <summary>
        /// Sets engines for 1,2,3,4 selection (to be followed by SELECT_n)
        /// </summary>
        Engine,
        /// <summary>
        /// Toggles spoiler handle
        /// </summary>
        SpoilersToggle,
        /// <summary>
        /// Sets flap handle to full retract position
        /// </summary>
        FlapsUp,
        /// <summary>
        /// Sets flap handle to first extension position
        /// </summary>
        Flaps1,
        /// <summary>
        /// Sets flap handle to second extension position
        /// </summary>
        Flaps2,
        /// <summary>
        /// Sets flap handle to third extension position
        /// </summary>
        Flaps3,
        /// <summary>
        /// Sets flap handle to full extension position
        /// </summary>
        FlapsDown,
        /// <summary>
        /// Increments elevator trim down
        /// </summary>
        ElevTrimDn,
        /// <summary>
        /// Increments elevator down
        /// </summary>
        ElevDown,
        /// <summary>
        /// Increments ailerons left
        /// </summary>
        AileronsLeft,
        /// <summary>
        /// Centers aileron and rudder positions
        /// </summary>
        CenterAilerRudder,
        /// <summary>
        /// Increments ailerons right
        /// </summary>
        AileronsRight,
        /// <summary>
        /// Increment elevator trim up
        /// </summary>
        ElevTrimUp,
        /// <summary>
        /// Increments elevator up
        /// </summary>
        ElevUp,
        /// <summary>
        /// Increments rudder left
        /// </summary>
        RudderLeft,
        /// <summary>
        /// Centers rudder position
        /// </summary>
        RudderCenter,
        /// <summary>
        /// Increments rudder right
        /// </summary>
        RudderRight,
        /// <summary>
        /// Sets elevator position (-16383 - +16383)
        /// </summary>
        ElevatorSet,
        /// <summary>
        /// Sets aileron position (-16383 - +16383)
        /// </summary>
        AileronSet,
        /// <summary>
        /// Sets rudder position (-16383 - +16383)
        /// </summary>
        RudderSet,
        /// <summary>
        /// Increments flap handle position
        /// </summary>
        FlapsIncr,
        /// <summary>
        /// Decrements flap handle position
        /// </summary>
        FlapsDecr,
        /// <summary>
        /// Sets elevator position (-16383 - +16383)
        /// </summary>
        AxisElevatorSet,
        /// <summary>
        /// Sets aileron position (-16383 - +16383)
        /// </summary>
        AxisAileronsSet,
        /// <summary>
        /// Sets rudder position (-16383 - +16383)
        /// </summary>
        AxisRudderSet,
        /// <summary>
        /// Sets elevator trim position (-16383 - +16383)
        /// </summary>
        AxisElevTrimSet,
        /// <summary>
        /// Sets spoiler handle position (0 to 16383)
        /// </summary>
        SpoilersSet,
        /// <summary>
        /// Toggles arming of auto-spoilers
        /// </summary>
        SpoilersArmToggle,
        /// <summary>
        /// Sets spoiler handle to full extend position
        /// </summary>
        SpoilersOn,
        /// <summary>
        /// Sets spoiler handle to full retract position
        /// </summary>
        SpoilersOff,
        /// <summary>
        /// Sets auto-spoiler arming on
        /// </summary>
        SpoilersArmOn,
        /// <summary>
        /// Sets auto-spoiler arming off
        /// </summary>
        SpoilersArmOff,
        /// <summary>
        /// Sets auto-spoiler arming (0,1)
        /// </summary>
        SpoilersArmSet,
        /// <summary>
        /// Increments aileron trim left
        /// </summary>
        AileronTrimLeft,
        /// <summary>
        /// Increments aileron trim right
        /// </summary>
        AileronTrimRight,
        /// <summary>
        /// Increments rudder trim left
        /// </summary>
        RudderTrimLeft,
        /// <summary>
        /// Increments aileron trim right
        /// </summary>
        RudderTrimRight,
        /// <summary>
        /// Sets spoiler handle position (-16383 - +16383)
        /// </summary>
        AxisSpoilerSet,
        /// <summary>
        /// Sets flap handle to closest increment (0 to 16383)
        /// </summary>
        FlapsSet,
        /// <summary>
        /// Sets elevator trim position (0 to 16383)
        /// </summary>
        ElevatorTrimSet,
        /// <summary>
        /// Sets flap handle to closest increment (-16383 - +16383)
        /// </summary>
        AxisFlapsSet,
        /// <summary>
        /// Toggles AP on/off
        /// </summary>
        ApMaster,
        /// <summary>
        /// Turns AP off
        /// </summary>
        AutopilotOff,
        /// <summary>
        /// Turns AP on
        /// </summary>
        AutopilotOn,
        /// <summary>
        /// Toggles yaw damper on/off
        /// </summary>
        YawDamperToggle,
        /// <summary>
        /// Toggles heading hold mode on/off
        /// </summary>
        ApPanelHeadingHold,
        /// <summary>
        /// Toggles altitude hold mode on/off
        /// </summary>
        ApPanelAltitudeHold,
        /// <summary>
        /// Turns on AP wing leveler and pitch hold mode
        /// </summary>
        ApAttHoldOn,
        /// <summary>
        /// Turns AP localizer hold on/armed and glide-slope hold mode off
        /// </summary>
        ApLocHoldOn,
        /// <summary>
        /// Turns both AP localizer and glide-slope modes on/armed
        /// </summary>
        ApAprHoldOn,
        /// <summary>
        /// Turns heading hold mode on
        /// </summary>
        ApHdgHoldOn,
        /// <summary>
        /// Turns altitude hold mode on
        /// </summary>
        ApAltHoldOn,
        /// <summary>
        /// Turns wing leveler mode on
        /// </summary>
        ApWingLevelerOn,
        /// <summary>
        /// Turns localizer back course hold mode on/armed
        /// </summary>
        ApBcHoldOn,
        /// <summary>
        /// Turns lateral hold mode on
        /// </summary>
        ApNav1HoldOn,
        /// <summary>
        /// Turns off attitude hold mode
        /// </summary>
        ApAttHoldOff,
        /// <summary>
        /// Turns off localizer hold mode
        /// </summary>
        ApLocHoldOff,
        /// <summary>
        /// Turns off approach hold mode
        /// </summary>
        ApAprHoldOff,
        /// <summary>
        /// Turns off heading hold mode
        /// </summary>
        ApHdgHoldOff,
        /// <summary>
        /// Turns off altitude hold mode
        /// </summary>
        ApAltHoldOff,
        /// <summary>
        /// Turns off wing leveler mode
        /// </summary>
        ApWingLevelerOff,
        /// <summary>
        /// Turns off backcourse mode for localizer hold
        /// </summary>
        ApBcHoldOff,
        /// <summary>
        /// Turns off nav hold mode
        /// </summary>
        ApNav1HoldOff,
        /// <summary>
        /// Toggles airspeed hold mode
        /// </summary>
        ApAirspeedHold,
        /// <summary>
        /// Toggles autothrottle arming mode
        /// </summary>
        AutoThrottleArm,
        /// <summary>
        /// Toggles Takeoff/Go Around mode
        /// </summary>
        AutoThrottleToGa,
        /// <summary>
        /// Increments heading hold reference bug
        /// </summary>
        HeadingBugInc,
        /// <summary>
        /// Decrements heading hold reference bug
        /// </summary>
        HeadingBugDec,
        /// <summary>
        /// Set heading hold reference bug (degrees)
        /// </summary>
        HeadingBugSet,
        /// <summary>
        /// Toggles airspeed hold mode
        /// </summary>
        ApPanelSpeedHold,
        /// <summary>
        /// Increments reference altitude
        /// </summary>
        ApAltVarInc,
        /// <summary>
        /// Decrements reference altitude
        /// </summary>
        ApAltVarDec,
        /// <summary>
        /// Increments vertical speed reference
        /// </summary>
        ApVsVarInc,
        /// <summary>
        /// Decrements vertical speed reference
        /// </summary>
        ApVsVarDec,
        /// <summary>
        /// Increments airspeed hold reference
        /// </summary>
        ApSpdVarInc,
        /// <summary>
        /// Decrements airspeed hold reference
        /// </summary>
        ApSpdVarDec,
        /// <summary>
        /// Toggles mach hold
        /// </summary>
        ApPanelMachHold,
        /// <summary>
        /// Increments reference mach
        /// </summary>
        ApMachVarInc,
        /// <summary>
        /// Decrements reference mach
        /// </summary>
        ApMachVarDec,
        /// <summary>
        /// Toggles mach hold
        /// </summary>
        ApMachHold,
        /// <summary>
        /// Sets reference altitude in meters
        /// </summary>
        ApAltVarSetMetric,
        /// <summary>
        /// Sets reference vertical speed in feet per minute
        /// </summary>
        ApVsVarSetEnglish,
        /// <summary>
        /// Sets airspeed reference in knots
        /// </summary>
        ApSpdVarSet,
        /// <summary>
        /// Sets mach reference
        /// </summary>
        ApMachVarSet,
        /// <summary>
        /// Turns yaw damper on
        /// </summary>
        YawDamperOn,
        /// <summary>
        /// Turns yaw damper off
        /// </summary>
        YawDamperOff,
        /// <summary>
        /// Sets yaw damper on/off (1,0)
        /// </summary>
        YawDamperSet,
        /// <summary>
        /// Turns airspeed hold on
        /// </summary>
        ApAirspeedOn,
        /// <summary>
        /// Turns airspeed hold off
        /// </summary>
        ApAirspeedOff,
        /// <summary>
        /// Sets airspeed hold on/off (1,0)
        /// </summary>
        ApAirspeedSet,
        /// <summary>
        /// Turns mach hold on
        /// </summary>
        ApMachOn,
        /// <summary>
        /// Turns mach hold off
        /// </summary>
        ApMachOff,
        /// <summary>
        /// Sets mach hold on/off (1,0)
        /// </summary>
        ApMachSet,
        /// <summary>
        /// Turns altitude hold mode on (without capturing current altitude)
        /// </summary>
        ApPanelAltitudeOn,
        /// <summary>
        /// Turns altitude hold mode off
        /// </summary>
        ApPanelAltitudeOff,
        /// <summary>
        /// Sets altitude hold mode on/off (1,0)
        /// </summary>
        ApPanelAltitudeSet,
        /// <summary>
        /// Turns heading mode on (without capturing current heading)
        /// </summary>
        ApPanelHeadingOn,
        /// <summary>
        /// Turns heading mode off
        /// </summary>
        ApPanelHeadingOff,
        /// <summary>
        /// Set heading mode on/off (1,0)
        /// </summary>
        ApPanelHeadingSet,
        /// <summary>
        /// Turns on mach hold
        /// </summary>
        ApPanelMachOn,
        /// <summary>
        /// Turns off mach hold
        /// </summary>
        ApPanelMachOff,
        /// <summary>
        /// Sets mach hold on/off (1,0)
        /// </summary>
        ApPanelMachSet,
        /// <summary>
        /// Turns on speed hold mode
        /// </summary>
        ApPanelSpeedOn,
        /// <summary>
        /// Turns off speed hold mode
        /// </summary>
        ApPanelSpeedOff,
        /// <summary>
        /// Set speed hold mode on/off (1,0)
        /// </summary>
        ApPanelSpeedSet,
        /// <summary>
        /// Sets altitude reference in feet
        /// </summary>
        ApAltVarSetEnglish,
        /// <summary>
        /// Sets vertical speed reference in meters per minute
        /// </summary>
        ApVsVarSetMetric,
        /// <summary>
        /// Toggles flight director on/off
        /// </summary>
        ToggleFlightDirector,
        /// <summary>
        /// Synchronizes flight director pitch with current aircraft pitch
        /// </summary>
        SyncFlightDirectorPitch,
        /// <summary>
        /// Increments autobrake level
        /// </summary>
        IncAutobrakeControl,
        /// <summary>
        /// Decrements autobrake level
        /// </summary>
        DecAutobrakeControl,
        /// <summary>
        /// Turns airspeed hold mode on with current airspeed
        /// </summary>
        AutopilotAirspeedHoldCurrent,
        /// <summary>
        /// Sets mach hold reference to current mach
        /// </summary>
        AutopilotMachHoldCurrent,
        /// <summary>
        /// Sets the nav (1 or 2) which is used by the Nav hold modes
        /// </summary>
        ApNavSelectSet,
        /// <summary>
        /// Selects the heading bug for use with +/-
        /// </summary>
        HeadingBugSelect,
        /// <summary>
        /// Selects the altitude reference for use with +/-
        /// </summary>
        AltitudeBugSelect,
        /// <summary>
        /// Selects the vertical speed reference for use with +/-
        /// </summary>
        VsiBugSelect,
        /// <summary>
        /// Selects the airspeed reference for use with +/-
        /// </summary>
        AirspeedBugSelect,
        /// <summary>
        /// Increments the pitch reference for pitch hold mode
        /// </summary>
        ApPitchRefIncUp,
        /// <summary>
        /// Decrements the pitch reference for pitch hold mode
        /// </summary>
        ApPitchRefIncDn,
        /// <summary>
        /// Selects pitch reference for use with +/-
        /// </summary>
        ApPitchRefSelect,
        /// <summary>
        /// Toggle attitude hold mode
        /// </summary>
        ApAttHold,
        /// <summary>
        /// Toggles localizer (only) hold mode
        /// </summary>
        ApLocHold,
        /// <summary>
        /// Toggles approach hold (localizer and glide-slope)
        /// </summary>
        ApAprHold,
        /// <summary>
        /// Toggles heading hold mode
        /// </summary>
        ApHdgHold,
        /// <summary>
        /// Toggles altitude hold mode
        /// </summary>
        ApAltHold,
        /// <summary>
        /// Toggles wing leveler mode
        /// </summary>
        ApWingLeveler,
        /// <summary>
        /// Toggles the backcourse mode for the localizer hold
        /// </summary>
        ApBcHold,
        /// <summary>
        /// Toggles the nav hold mode
        /// </summary>
        ApNav1Hold,
        /// <summary>
        /// Autopilot max bank angle increment.
        /// </summary>
        ApMaxBankInc,
        /// <summary>
        /// Autopilot max bank angle decrement.
        /// </summary>
        ApMaxBankDec,
        /// <summary>
        /// Autopilot, hold the N1 percentage at its current level.
        /// </summary>
        ApN1Hold,
        /// <summary>
        /// Increment the autopilot N1 reference.
        /// </summary>
        ApN1RefInc,
        /// <summary>
        /// Decrement the autopilot N1 reference.
        /// </summary>
        ApN1RefDec,
        /// <summary>
        /// Sets the autopilot N1 reference.
        /// </summary>
        ApN1RefSet,
        /// <summary>
        /// Turn on or off the fly by wire Elevators and Ailerons computer.
        /// </summary>
        FlyByWireElacToggle,
        /// <summary>
        /// Turn on or off the fly by wire Flight Augmentation computer.
        /// </summary>
        FlyByWireFacToggle,
        /// <summary>
        /// Turn on or off the fly by wire Spoilers and Elevators computer.
        /// </summary>
        FlyByWireSecToggle,
        /// <summary>
        /// The primary flight display (PFD) should display its current flight plan.
        /// </summary>
        G1000PfdFlightplanButton,
        /// <summary>
        /// Turn to the Procedure page.
        /// </summary>
        G1000PfdProcedureButton,
        /// <summary>
        /// Zoom in on the current map.
        /// </summary>
        G1000PfdZoominButton,
        /// <summary>
        /// Zoom out on the current map.
        /// </summary>
        G1000PfdZoomoutButton,
        /// <summary>
        /// Turn to the Direct To page.
        /// </summary>
        G1000PfdDirecttoButton,
        /// <summary>
        /// If a segmented flight plan is highlighted, activates the associated menu.
        /// </summary>
        G1000PfdMenuButton,
        /// <summary>
        /// Clears the current input.
        /// </summary>
        G1000PfdClearButton,
        /// <summary>
        /// Enters the current input.
        /// </summary>
        G1000PfdEnterButton,
        /// <summary>
        /// Turns on or off a screen cursor.
        /// </summary>
        G1000PfdCursorButton,
        /// <summary>
        /// Step up through the page groups.
        /// </summary>
        G1000PfdGroupKnobInc,
        /// <summary>
        /// Step down through the page groups.
        /// </summary>
        G1000PfdGroupKnobDec,
        /// <summary>
        /// Step up through the individual pages.
        /// </summary>
        G1000PfdPageKnobInc,
        /// <summary>
        /// Step down through the individual pages.
        /// </summary>
        G1000PfdPageKnobDec,
        /// <summary>
        /// Initiate the action for the icon displayed in the softkey position.
        /// </summary>
        G1000PfdSoftkey1,
        /// <summary>
        /// The multi-function display (MFD) should display its current flight plan.
        /// </summary>
        G1000MfdFlightplanButton,
        /// <summary>
        /// Turn to the Procedure page.
        /// </summary>
        G1000MfdProcedureButton,
        /// <summary>
        /// Zoom in on the current map.
        /// </summary>
        G1000MfdZoominButton,
        /// <summary>
        /// Zoom out on the current map.
        /// </summary>
        G1000MfdZoomoutButton,
        /// <summary>
        /// Turn to the Direct To page.
        /// </summary>
        G1000MfdDirecttoButton,
        /// <summary>
        /// If a segmented flight plan is highlighted, activates the associated menu.
        /// </summary>
        G1000MfdMenuButton,
        /// <summary>
        /// Clears the current input.
        /// </summary>
        G1000MfdClearButton,
        /// <summary>
        /// Enters the current input.
        /// </summary>
        G1000MfdEnterButton,
        /// <summary>
        /// Turns on or off a screen cursor.
        /// </summary>
        G1000MfdCursorButton,
        /// <summary>
        /// Step up through the page groups.
        /// </summary>
        G1000MfdGroupKnobInc,
        /// <summary>
        /// Step down through the page groups.
        /// </summary>
        G1000MfdGroupKnobDec,
        /// <summary>
        /// Step up through the individual pages.
        /// </summary>
        G1000MfdPageKnobInc,
        /// <summary>
        /// Step down through the individual pages.
        /// </summary>
        G1000MfdPageKnobDec,
        /// <summary>
        /// Initiate the action for the icon displayed in the softkey position.
        /// </summary>
        G1000MfdSoftkey1,
        /// <summary>
        /// Turns selector 1 to OFF position
        /// </summary>
        FuelSelectorOff,
        /// <summary>
        /// Turns selector 1 to ALL position
        /// </summary>
        FuelSelectorAll,
        /// <summary>
        /// Turns selector 1 to LEFT position (burns from tip then aux then main)
        /// </summary>
        FuelSelectorLeft,
        /// <summary>
        /// Turns selector 1 to RIGHT position (burns from tip then aux then main)
        /// </summary>
        FuelSelectorRight,
        /// <summary>
        /// Turns selector 1 to LEFT AUX position
        /// </summary>
        FuelSelectorLeftAux,
        /// <summary>
        /// Turns selector 1 to RIGHT AUX position
        /// </summary>
        FuelSelectorRightAux,
        /// <summary>
        /// Turns selector 1 to CENTER position
        /// </summary>
        FuelSelectorCenter,
        /// <summary>
        /// Sets selector 1 position (see code list below)
        /// </summary>
        FuelSelectorSet,
        /// <summary>
        /// Turns selector 2 to OFF position
        /// </summary>
        FuelSelector2Off,
        /// <summary>
        /// Turns selector 2 to ALL position
        /// </summary>
        FuelSelector2All,
        /// <summary>
        /// Turns selector 2 to LEFT position (burns from tip then aux then main)
        /// </summary>
        FuelSelector2Left,
        /// <summary>
        /// Turns selector 2 to RIGHT position (burns from tip then aux then main)
        /// </summary>
        FuelSelector2Right,
        /// <summary>
        /// Turns selector 2 to LEFT AUX position
        /// </summary>
        FuelSelector2LeftAux,
        /// <summary>
        /// Turns selector 2 to RIGHT AUX position
        /// </summary>
        FuelSelector2RightAux,
        /// <summary>
        /// Turns selector 2 to CENTER position
        /// </summary>
        FuelSelector2Center,
        /// <summary>
        /// Sets selector 2 position (see code list below)
        /// </summary>
        FuelSelector2Set,
        /// <summary>
        /// Turns selector 3 to OFF position
        /// </summary>
        FuelSelector3Off,
        /// <summary>
        /// Turns selector 3 to ALL position
        /// </summary>
        FuelSelector3All,
        /// <summary>
        /// Turns selector 3 to LEFT position (burns from tip then aux then main)
        /// </summary>
        FuelSelector3Left,
        /// <summary>
        /// Turns selector 3 to RIGHT position (burns from tip then aux then main)
        /// </summary>
        FuelSelector3Right,
        /// <summary>
        /// Turns selector 3 to LEFT AUX position
        /// </summary>
        FuelSelector3LeftAux,
        /// <summary>
        /// Turns selector 3 to RIGHT AUX position
        /// </summary>
        FuelSelector3RightAux,
        /// <summary>
        /// Turns selector 3 to CENTER position
        /// </summary>
        FuelSelector3Center,
        /// <summary>
        /// Sets selector 3 position (see code list below)
        /// </summary>
        FuelSelector3Set,
        /// <summary>
        /// Turns selector 4 to OFF position
        /// </summary>
        FuelSelector4Off,
        /// <summary>
        /// Turns selector 4 to ALL position
        /// </summary>
        FuelSelector4All,
        /// <summary>
        /// Turns selector 4 to LEFT position (burns from tip then aux then main)
        /// </summary>
        FuelSelector4Left,
        /// <summary>
        /// Turns selector 4 to RIGHT position (burns from tip then aux then main)
        /// </summary>
        FuelSelector4Right,
        /// <summary>
        /// Turns selector 4 to LEFT AUX position
        /// </summary>
        FuelSelector4LeftAux,
        /// <summary>
        /// Turns selector 4 to RIGHT AUX position
        /// </summary>
        FuelSelector4RightAux,
        /// <summary>
        /// Turns selector 4 to CENTER position
        /// </summary>
        FuelSelector4Center,
        /// <summary>
        /// Sets selector 4 position (see code list below)
        /// </summary>
        FuelSelector4Set,
        /// <summary>
        /// "Opens cross feed valve (when used in conjunction with ""isolate"" tank)"
        /// </summary>
        CrossFeedOpen,
        /// <summary>
        /// "Toggles crossfeed valve (when used in conjunction with ""isolate"" tank)"
        /// </summary>
        CrossFeedToggle,
        /// <summary>
        /// "Closes crossfeed valve (when used in conjunction with ""isolate"" tank)"
        /// </summary>
        CrossFeedOff,
        /// <summary>
        /// Set to True or False. The switch can only be set to True if fuel_dump_rate is specified in the aircraft configuration file, which indicates that a fuel dump system exists.
        /// </summary>
        FuelDumpSwitchSet,
        /// <summary>
        /// Toggle the anti-detonation valve. Pass a value to determine which tank, if there are multiple tanks, to use. Tanks are indexed from 1. Refer to the document Notes on Aircraft Systems.
        /// </summary>
        ToggleAntidetonationTankValve,
        /// <summary>
        /// Toggle the nitrous valve. Pass a value to determine which tank, if there are multiple tanks, to use. Tanks are indexed from 1.
        /// </summary>
        ToggleNitrousTankValve,
        /// <summary>
        /// Fully repair and refuel the user aircraft. Ignored if flight realism is enforced.
        /// </summary>
        RepairAndRefuel,
        /// <summary>
        /// Turns on or off the fuel dump switch.
        /// </summary>
        FuelDumpToggle,
        /// <summary>
        /// Request a fuel truck. The aircraft must be in a parking spot for this to be successful.
        /// </summary>
        RequestFuel,
        /// <summary>
        /// Sets the fuel selector. Fuel will be taken in the order left tip, left aux,then main fuel tanks.
        /// </summary>
        FuelSelectorLeftMain,
        /// <summary>
        /// Sets the fuel selector for engine 2.
        /// </summary>
        FuelSelector2LeftMain,
        /// <summary>
        /// Sets the fuel selector for engine 3.
        /// </summary>
        FuelSelector3LeftMain,
        /// <summary>
        /// Sets the fuel selector for engine 4.
        /// </summary>
        FuelSelector4LeftMain,
        /// <summary>
        /// Sets the fuel selector. Fuel will be taken in the order right tip, right aux,then main fuel tanks.
        /// </summary>
        FuelSelectorRightMain,
        /// <summary>
        /// Sets the fuel selector for engine 2.
        /// </summary>
        FuelSelector2RightMain,
        /// <summary>
        /// Sets the fuel selector for engine 3.
        /// </summary>
        FuelSelector3RightMain,
        /// <summary>
        /// Sets the fuel selector for engine 4.
        /// </summary>
        FuelSelector4RightMain,
        /// <summary>
        /// Sequentially selects the transponder digits for use with +/-.
        /// </summary>
        Xpndr,
        /// <summary>
        /// Sequentially selects the ADF tuner digits for use with +/-. Follow byKEY_SELECT_2 for ADF 2.
        /// </summary>
        Adf,
        /// <summary>
        /// Selects the DME for use with +/-
        /// </summary>
        Dme,
        /// <summary>
        /// Sequentially selects the COM tuner digits for use with +/-. Follow byKEY_SELECT_2 for COM 2.
        /// </summary>
        ComRadio,
        /// <summary>
        /// Sequentially selects the VOR OBS for use with +/-. Follow by KEY_SELECT_2 for VOR 2.
        /// </summary>
        VorObs,
        /// <summary>
        /// Sequentially selects the NAV tuner digits for use with +/-. Follow byKEY_SELECT_2 for NAV 2.
        /// </summary>
        NavRadio,
        /// <summary>
        /// Decrements COM by one MHz
        /// </summary>
        ComRadioWholeDec,
        /// <summary>
        /// Increments COM by one MHz
        /// </summary>
        ComRadioWholeInc,
        /// <summary>
        /// Decrements COM by 25 KHz
        /// </summary>
        ComRadioFractDec,
        /// <summary>
        /// Increments COM by 25 KHz
        /// </summary>
        ComRadioFractInc,
        /// <summary>
        /// Decrements Nav 1 by one MHz
        /// </summary>
        Nav1RadioWholeDec,
        /// <summary>
        /// Increments Nav 1 by one MHz
        /// </summary>
        Nav1RadioWholeInc,
        /// <summary>
        /// Decrements Nav 1 by 25 KHz
        /// </summary>
        Nav1RadioFractDec,
        /// <summary>
        /// Increments Nav 1 by 25 KHz
        /// </summary>
        Nav1RadioFractInc,
        /// <summary>
        /// Decrements Nav 2 by one MHz
        /// </summary>
        Nav2RadioWholeDec,
        /// <summary>
        /// Increments Nav 2 by one MHz
        /// </summary>
        Nav2RadioWholeInc,
        /// <summary>
        /// Decrements Nav 2 by 25 KHz
        /// </summary>
        Nav2RadioFractDec,
        /// <summary>
        /// Increments Nav 2 by 25 KHz
        /// </summary>
        Nav2RadioFractInc,
        /// <summary>
        /// Increments ADF by 100 KHz
        /// </summary>
        Adf100Inc,
        /// <summary>
        /// Increments ADF by 10 KHz
        /// </summary>
        Adf10Inc,
        /// <summary>
        /// Increments ADF by 1 KHz
        /// </summary>
        Adf1Inc,
        /// <summary>
        /// Increments first digit of transponder
        /// </summary>
        Xpndr1000Inc,
        /// <summary>
        /// Increments second digit of transponder
        /// </summary>
        Xpndr100Inc,
        /// <summary>
        /// Increments third digit of transponder
        /// </summary>
        Xpndr10Inc,
        /// <summary>
        /// Increments fourth digit of transponder
        /// </summary>
        Xpndr1Inc,
        /// <summary>
        /// Decrements the VOR 1 OBS setting
        /// </summary>
        Vor1ObiDec,
        /// <summary>
        /// Increments the VOR 1 OBS setting
        /// </summary>
        Vor1ObiInc,
        /// <summary>
        /// Decrements the VOR 2 OBS setting
        /// </summary>
        Vor2ObiDec,
        /// <summary>
        /// Increments the VOR 2 OBS setting
        /// </summary>
        Vor2ObiInc,
        /// <summary>
        /// Decrements ADF by 100 KHz
        /// </summary>
        Adf100Dec,
        /// <summary>
        /// Decrements ADF by 10 KHz
        /// </summary>
        Adf10Dec,
        /// <summary>
        /// Decrements ADF by 1 KHz
        /// </summary>
        Adf1Dec,
        /// <summary>
        /// Sets COM frequency (BCD Hz)
        /// </summary>
        ComRadioSet,
        /// <summary>
        /// Sets NAV 1 frequency (BCD Hz)
        /// </summary>
        Nav1RadioSet,
        /// <summary>
        /// Sets NAV 2 frequency (BCD Hz)
        /// </summary>
        Nav2RadioSet,
        /// <summary>
        /// Sets ADF frequency (BCD Hz)
        /// </summary>
        AdfSet,
        /// <summary>
        /// Sets transponder code (BCD)
        /// </summary>
        XpndrSet,
        /// <summary>
        /// Sets OBS 1 (0 to 360)
        /// </summary>
        Vor1Set,
        /// <summary>
        /// Sets OBS 2 (0 to 360)
        /// </summary>
        Vor2Set,
        /// <summary>
        /// Sets DME display to Nav 1
        /// </summary>
        Dme1Toggle,
        /// <summary>
        /// Sets DME display to Nav 2
        /// </summary>
        Dme2Toggle,
        /// <summary>
        /// Turns NAV 1 ID off
        /// </summary>
        RadioVor1IdentDisable,
        /// <summary>
        /// Turns NAV 2 ID off
        /// </summary>
        RadioVor2IdentDisable,
        /// <summary>
        /// Turns DME 1 ID off
        /// </summary>
        RadioDme1IdentDisable,
        /// <summary>
        /// Turns DME 2 ID off
        /// </summary>
        RadioDme2IdentDisable,
        /// <summary>
        /// Turns ADF 1 ID off
        /// </summary>
        RadioAdfIdentDisable,
        /// <summary>
        /// Turns NAV 1 ID on
        /// </summary>
        RadioVor1IdentEnable,
        /// <summary>
        /// Turns NAV 2 ID on
        /// </summary>
        RadioVor2IdentEnable,
        /// <summary>
        /// Turns DME 1 ID on
        /// </summary>
        RadioDme1IdentEnable,
        /// <summary>
        /// Turns DME 2 ID on
        /// </summary>
        RadioDme2IdentEnable,
        /// <summary>
        /// Turns ADF 1 ID on
        /// </summary>
        RadioAdfIdentEnable,
        /// <summary>
        /// Toggles NAV 1 ID
        /// </summary>
        RadioVor1IdentToggle,
        /// <summary>
        /// Toggles NAV 2 ID
        /// </summary>
        RadioVor2IdentToggle,
        /// <summary>
        /// Toggles DME 1 ID
        /// </summary>
        RadioDme1IdentToggle,
        /// <summary>
        /// Toggles DME 2 ID
        /// </summary>
        RadioDme2IdentToggle,
        /// <summary>
        /// Toggles ADF 1 ID
        /// </summary>
        RadioAdfIdentToggle,
        /// <summary>
        /// Sets NAV 1 ID (on/off)
        /// </summary>
        RadioVor1IdentSet,
        /// <summary>
        /// Sets NAV 2 ID (on/off)
        /// </summary>
        RadioVor2IdentSet,
        /// <summary>
        /// Sets DME 1 ID (on/off)
        /// </summary>
        RadioDme1IdentSet,
        /// <summary>
        /// Sets DME 2 ID (on/off)
        /// </summary>
        RadioDme2IdentSet,
        /// <summary>
        /// Sets ADF 1 ID (on/off)
        /// </summary>
        RadioAdfIdentSet,
        /// <summary>
        /// Increments ADF card
        /// </summary>
        AdfCardInc,
        /// <summary>
        /// Decrements ADF card
        /// </summary>
        AdfCardDec,
        /// <summary>
        /// Sets ADF card (0-360)
        /// </summary>
        AdfCardSet,
        /// <summary>
        /// Toggles between NAV 1 and NAV 2
        /// </summary>
        DmeToggle,
        /// <summary>
        /// Sets the avionics master switch
        /// </summary>
        AvionicsMasterSet,
        /// <summary>
        /// Toggles the avionics master switch
        /// </summary>
        ToggleAvionicsMaster,
        /// <summary>
        /// Sets COM 1 standby frequency (BCD Hz)
        /// </summary>
        ComStbyRadioSet,
        /// <summary>
        /// Swaps COM 1 frequency with standby
        /// </summary>
        ComStbyRadioSwitchTo,
        /// <summary>
        /// Decrement COM 1 frequency by 25 KHz, and carry when digit wraps
        /// </summary>
        ComRadioFractDecCarry,
        /// <summary>
        /// Increment COM 1 frequency by 25 KHz, and carry when digit wraps
        /// </summary>
        ComRadioFractIncCarry,
        /// <summary>
        /// Decrement COM 2 frequency by 1 MHz, with no carry when digit wraps
        /// </summary>
        Com2RadioWholeDec,
        /// <summary>
        /// Increment COM 2 frequency by 1 MHz, with no carry when digit wraps
        /// </summary>
        Com2RadioWholeInc,
        /// <summary>
        /// Decrement COM 2 frequency by 25 KHz, with no carry when digit wraps
        /// </summary>
        Com2RadioFractDec,
        /// <summary>
        /// Decrement COM 2 frequency by 25 KHz, and carry when digit wraps
        /// </summary>
        Com2RadioFractDecCarry,
        /// <summary>
        /// Increment COM 2 frequency by 25 KHz, with no carry when digit wraps
        /// </summary>
        Com2RadioFractInc,
        /// <summary>
        /// Increment COM 2 frequency by 25 KHz, and carry when digit wraps
        /// </summary>
        Com2RadioFractIncCarry,
        /// <summary>
        /// Sets COM 2 frequency (BCD Hz)
        /// </summary>
        Com2RadioSet,
        /// <summary>
        /// Sets COM 2 standby frequency (BCD Hz)
        /// </summary>
        Com2StbyRadioSet,
        /// <summary>
        /// Swaps COM 2 frequency with standby
        /// </summary>
        Com2RadioSwap,
        /// <summary>
        /// Decrement NAV 1 frequency by 50 KHz, and carry when digit wraps
        /// </summary>
        Nav1RadioFractDecCarry,
        /// <summary>
        /// Increment NAV 1 frequency by 50 KHz, and carry when digit wraps
        /// </summary>
        Nav1RadioFractIncCarry,
        /// <summary>
        /// Sets NAV 1 standby frequency (BCD Hz)
        /// </summary>
        Nav1StbySet,
        /// <summary>
        /// Swaps NAV 1 frequency with standby
        /// </summary>
        Nav1RadioSwap,
        /// <summary>
        /// Decrement NAV 2 frequency by 50 KHz, and carry when digit wraps
        /// </summary>
        Nav2RadioFractDecCarry,
        /// <summary>
        /// Increment NAV 2 frequency by 50 KHz, and carry when digit wraps
        /// </summary>
        Nav2RadioFractIncCarry,
        /// <summary>
        /// Sets NAV 2 standby frequency (BCD Hz)
        /// </summary>
        Nav2StbySet,
        /// <summary>
        /// Swaps NAV 2 frequency with standby
        /// </summary>
        Nav2RadioSwap,
        /// <summary>
        /// Decrements ADF 1 by 0.1 KHz.
        /// </summary>
        Adf1RadioTenthsDec,
        /// <summary>
        /// Increments ADF 1 by 0.1 KHz.
        /// </summary>
        Adf1RadioTenthsInc,
        /// <summary>
        /// Decrements first digit of transponder
        /// </summary>
        Xpndr1000Dec,
        /// <summary>
        /// Decrements second digit of transponder
        /// </summary>
        Xpndr100Dec,
        /// <summary>
        /// Decrements third digit of transponder
        /// </summary>
        Xpndr10Dec,
        /// <summary>
        /// Decrements fourth digit of transponder
        /// </summary>
        Xpndr1Dec,
        /// <summary>
        /// Decrements fourth digit of transponder, and with carry.
        /// </summary>
        XpndrDecCarry,
        /// <summary>
        /// Increments fourth digit of transponder, and with carry.
        /// </summary>
        XpndrIncCarry,
        /// <summary>
        /// Decrements ADF 1 frequency by 0.1 KHz, with carry
        /// </summary>
        AdfFractDecCarry,
        /// <summary>
        /// Increments ADF 1 frequency by 0.1 KHz, with carry
        /// </summary>
        AdfFractIncCarry,
        /// <summary>
        /// Selects COM 1 to transmit
        /// </summary>
        Com1TransmitSelect,
        /// <summary>
        /// Selects COM 2 to transmit
        /// </summary>
        Com2TransmitSelect,
        /// <summary>
        /// Toggles all COM radios to receive on
        /// </summary>
        ComReceiveAllToggle,
        /// <summary>
        /// Sets whether to receive on all COM radios (1,0)
        /// </summary>
        ComReceiveAllSet,
        /// <summary>
        /// Toggles marker beacon sound on/off
        /// </summary>
        MarkerSoundToggle,
        /// <summary>
        /// Sets ADF 1 frequency (BCD Hz)
        /// </summary>
        AdfCompleteSet,
        /// <summary>
        /// Increments ADF 1 by 1 KHz, with carry as digits wrap.
        /// </summary>
        AdfWholeInc,
        /// <summary>
        /// Decrements ADF 1 by 1 KHz, with carry as digits wrap.
        /// </summary>
        AdfWholeDec,
        /// <summary>
        /// Increments the ADF 2 frequency 100 digit, with wrapping
        /// </summary>
        Adf2100Inc,
        /// <summary>
        /// Increments the ADF 2 frequency 10 digit, with wrapping
        /// </summary>
        Adf210Inc,
        /// <summary>
        /// Increments the ADF 2 frequency 1 digit, with wrapping
        /// </summary>
        Adf21Inc,
        /// <summary>
        /// Increments ADF 2 frequency 1/10 digit, with wrapping
        /// </summary>
        Adf2RadioTenthsInc,
        /// <summary>
        /// Decrements the ADF 2 frequency 100 digit, with wrapping
        /// </summary>
        Adf2100Dec,
        /// <summary>
        /// Decrements the ADF 2 frequency 10 digit, with wrapping
        /// </summary>
        Adf210Dec,
        /// <summary>
        /// Decrements the ADF 2 frequency 1 digit, with wrapping
        /// </summary>
        Adf21Dec,
        /// <summary>
        /// Decrements ADF 2 frequency 1/10 digit, with wrapping
        /// </summary>
        Adf2RadioTenthsDec,
        /// <summary>
        /// Increments ADF 2 by 1 KHz, with carry as digits wrap.
        /// </summary>
        Adf2WholeInc,
        /// <summary>
        /// Decrements ADF 2 by 1 KHz, with carry as digits wrap.
        /// </summary>
        Adf2WholeDec,
        /// <summary>
        /// Decrements ADF 2 frequency by 0.1 KHz, with carry
        /// </summary>
        Adf2FractIncCarry,
        /// <summary>
        /// Increments ADF 2 frequency by 0.1 KHz, with carry
        /// </summary>
        Adf2FractDecCarry,
        /// <summary>
        /// Sets ADF 1 frequency (BCD Hz)
        /// </summary>
        Adf2CompleteSet,
        /// <summary>
        /// Turns ADF 2 ID off
        /// </summary>
        RadioAdf2IdentDisable,
        /// <summary>
        /// Turns ADF 2 ID on
        /// </summary>
        RadioAdf2IdentEnable,
        /// <summary>
        /// Toggles ADF 2 ID
        /// </summary>
        RadioAdf2IdentToggle,
        /// <summary>
        /// Sets ADF 2 ID on/off (1,0)
        /// </summary>
        RadioAdf2IdentSet,
        /// <summary>
        /// Swaps frequency with standby on whichever NAV or COM radio is selected.
        /// </summary>
        FrequencySwap,
        /// <summary>
        /// Toggles between GPS and NAV 1 driving NAV 1 OBS display (and AP)
        /// </summary>
        ToggleGpsDrivesNav1,
        /// <summary>
        /// Toggles power button
        /// </summary>
        GpsPowerButton,
        /// <summary>
        /// Selects Nearest Airport Page
        /// </summary>
        GpsNearestButton,
        /// <summary>
        /// Toggles automatic sequencing of waypoints
        /// </summary>
        GpsObsButton,
        /// <summary>
        /// Toggles the Message Page
        /// </summary>
        GpsMsgButton,
        /// <summary>
        /// Triggers the pressing of the message button.
        /// </summary>
        GpsMsgButtonDown,
        /// <summary>
        /// Triggers the release of the message button
        /// </summary>
        GpsMsgButtonUp,
        /// <summary>
        /// Displays the programmed flightplan.
        /// </summary>
        GpsFlightplanButton,
        /// <summary>
        /// Displays terrain information on default display
        /// </summary>
        GpsTerrainButton,
        /// <summary>
        /// Displays the approach procedure page.
        /// </summary>
        GpsProcedureButton,
        /// <summary>
        /// Zooms in default display
        /// </summary>
        GpsZoominButton,
        /// <summary>
        /// Zooms out default display
        /// </summary>
        GpsZoomoutButton,
        /// <summary>
        /// "Brings up the ""Direct To"" page"
        /// </summary>
        GpsDirecttoButton,
        /// <summary>
        /// Brings up page to select active legs in a flightplan.
        /// </summary>
        GpsMenuButton,
        /// <summary>
        /// Clears entered data on a page
        /// </summary>
        GpsClearButton,
        /// <summary>
        /// Clears all data immediately
        /// </summary>
        GpsClearAllButton,
        /// <summary>
        /// Triggers the pressing of the Clear button
        /// </summary>
        GpsClearButtonDown,
        /// <summary>
        /// Triggers the release of the Clear button.
        /// </summary>
        GpsClearButtonUp,
        /// <summary>
        /// Approves entered data.
        /// </summary>
        GpsEnterButton,
        /// <summary>
        /// Selects GPS cursor
        /// </summary>
        GpsCursorButton,
        /// <summary>
        /// Increments cursor
        /// </summary>
        GpsGroupKnobInc,
        /// <summary>
        /// Decrements cursor
        /// </summary>
        GpsGroupKnobDec,
        /// <summary>
        /// Increments through pages
        /// </summary>
        GpsPageKnobInc,
        /// <summary>
        /// Decrements through pages
        /// </summary>
        GpsPageKnobDec,
        /// <summary>
        /// Selects one of the two DME systems (1,2).
        /// </summary>
        DmeSelect,
        /// <summary>
        /// Turns on the identification sound for the selected DME.
        /// </summary>
        RadioSelectedDmeIdentEnable,
        /// <summary>
        /// Turns off the identification sound for the selected DME.
        /// </summary>
        RadioSelectedDmeIdentDisable,
        /// <summary>
        /// Sets the DME identification sound to the given filename.
        /// </summary>
        RadioSelectedDmeIdentSet,
        /// <summary>
        /// Turns on or off the identification sound for the selected DME.
        /// </summary>
        RadioSelectedDmeIdentToggle,
        /// <summary>
        /// Selects EGT bug for +/-
        /// </summary>
        Egt,
        /// <summary>
        /// Increments EGT bugs
        /// </summary>
        EgtInc,
        /// <summary>
        /// Decrements EGT bugs
        /// </summary>
        EgtDec,
        /// <summary>
        /// Sets EGT bugs (0 to 32767)
        /// </summary>
        EgtSet,
        /// <summary>
        /// Syncs altimeter setting to sea level pressure, or 29.92 if above 18000 feet
        /// </summary>
        Barometric,
        /// <summary>
        /// Increments heading indicator
        /// </summary>
        GyroDriftInc,
        /// <summary>
        /// Decrements heading indicator
        /// </summary>
        GyroDriftDec,
        /// <summary>
        /// Increments altimeter setting
        /// </summary>
        KohlsmanInc,
        /// <summary>
        /// Decrements altimeter setting
        /// </summary>
        KohlsmanDec,
        /// <summary>
        /// Sets altimeter setting (Millibars * 16)
        /// </summary>
        KohlsmanSet,
        /// <summary>
        /// Increments airspeed indicators true airspeed reference card
        /// </summary>
        TrueAirspeedCalibrateInc,
        /// <summary>
        /// Decrements airspeed indicators true airspeed reference card
        /// </summary>
        TrueAirspeedCalibrateDec,
        /// <summary>
        /// Sets airspeed indicators true airspeed reference card (degrees, where 0 is standard sea level conditions)
        /// </summary>
        TrueAirspeedCalSet,
        /// <summary>
        /// Increments EGT bug 1
        /// </summary>
        Egt1Inc,
        /// <summary>
        /// Decrements EGT bug 1
        /// </summary>
        Egt1Dec,
        /// <summary>
        /// Sets EGT bug 1 (0 to 32767)
        /// </summary>
        Egt1Set,
        /// <summary>
        /// Increments EGT bug 2
        /// </summary>
        Egt2Inc,
        /// <summary>
        /// Decrements EGT bug 2
        /// </summary>
        Egt2Dec,
        /// <summary>
        /// Sets EGT bug 2 (0 to 32767)
        /// </summary>
        Egt2Set,
        /// <summary>
        /// Increments EGT bug 3
        /// </summary>
        Egt3Inc,
        /// <summary>
        /// Decrements EGT bug 3
        /// </summary>
        Egt3Dec,
        /// <summary>
        /// Sets EGT bug 3 (0 to 32767)
        /// </summary>
        Egt3Set,
        /// <summary>
        /// Increments EGT bug 4
        /// </summary>
        Egt4Inc,
        /// <summary>
        /// Decrements EGT bug 4
        /// </summary>
        Egt4Dec,
        /// <summary>
        /// Sets EGT bug 4 (0 to 32767)
        /// </summary>
        Egt4Set,
        /// <summary>
        /// Increments attitude indicator pitch reference bars
        /// </summary>
        AttitudeBarsPositionInc,
        /// <summary>
        /// Decrements attitude indicator pitch reference bars
        /// </summary>
        AttitudeBarsPositionDec,
        /// <summary>
        /// Cages attitude indicator at 0 pitch and bank
        /// </summary>
        ToggleAttitudeCage,
        /// <summary>
        /// Resets max/min indicated G force to 1.0.
        /// </summary>
        ResetGForceIndicator,
        /// <summary>
        /// Reset max indicated engine rpm to 0.
        /// </summary>
        ResetMaxRpmIndicator,
        /// <summary>
        /// Sets heading indicator to 0 drift error.
        /// </summary>
        HeadingGyroSet,
        /// <summary>
        /// Sets heading indicator drift angle (degrees).
        /// </summary>
        GyroDriftSet,
        /// <summary>
        /// Toggle strobe lights
        /// </summary>
        StrobesToggle,
        /// <summary>
        /// Toggle all lights
        /// </summary>
        AllLightsToggle,
        /// <summary>
        /// Toggle panel lights
        /// </summary>
        PanelLightsToggle,
        /// <summary>
        /// Toggle landing lights
        /// </summary>
        LandingLightsToggle,
        /// <summary>
        /// Rotate landing light up
        /// </summary>
        LandingLightUp,
        /// <summary>
        /// Rotate landing light down
        /// </summary>
        LandingLightDown,
        /// <summary>
        /// Rotate landing light left
        /// </summary>
        LandingLightLeft,
        /// <summary>
        /// Rotate landing light right
        /// </summary>
        LandingLightRight,
        /// <summary>
        /// Return landing light to default position
        /// </summary>
        LandingLightHome,
        /// <summary>
        /// Turn strobe lights on
        /// </summary>
        StrobesOn,
        /// <summary>
        /// Turn strobe light off
        /// </summary>
        StrobesOff,
        /// <summary>
        /// Set strobe lights on/off (1,0)
        /// </summary>
        StrobesSet,
        /// <summary>
        /// Turn panel lights on
        /// </summary>
        PanelLightsOn,
        /// <summary>
        /// Turn panel lights off
        /// </summary>
        PanelLightsOff,
        /// <summary>
        /// Set panel lights on/off (1,0)
        /// </summary>
        PanelLightsSet,
        /// <summary>
        /// Turn landing lights on
        /// </summary>
        LandingLightsOn,
        /// <summary>
        /// Turn landing lights off
        /// </summary>
        LandingLightsOff,
        /// <summary>
        /// Set landing lights on/off (1,0)
        /// </summary>
        LandingLightsSet,
        /// <summary>
        /// Toggle beacon lights
        /// </summary>
        ToggleBeaconLights,
        /// <summary>
        /// Toggle taxi lights
        /// </summary>
        ToggleTaxiLights,
        /// <summary>
        /// Toggle logo lights
        /// </summary>
        ToggleLogoLights,
        /// <summary>
        /// Toggle recognition lights
        /// </summary>
        ToggleRecognitionLights,
        /// <summary>
        /// Toggle wing lights
        /// </summary>
        ToggleWingLights,
        /// <summary>
        /// Toggle navigation lights
        /// </summary>
        ToggleNavLights,
        /// <summary>
        /// Toggle cockpit/cabin lights
        /// </summary>
        ToggleCabinLights,
        /// <summary>
        /// Toggle vacuum system failure
        /// </summary>
        ToggleVacuumFailure,
        /// <summary>
        /// Toggle electrical system failure
        /// </summary>
        ToggleElectricalFailure,
        /// <summary>
        /// Toggles blocked pitot tube
        /// </summary>
        TogglePitotBlockage,
        /// <summary>
        /// Toggles blocked static port
        /// </summary>
        ToggleStaticPortBlockage,
        /// <summary>
        /// Toggles hydraulic system failure
        /// </summary>
        ToggleHydraulicFailure,
        /// <summary>
        /// Toggles brake failure (both)
        /// </summary>
        ToggleTotalBrakeFailure,
        /// <summary>
        /// Toggles left brake failure
        /// </summary>
        ToggleLeftBrakeFailure,
        /// <summary>
        /// Toggles right brake failure
        /// </summary>
        ToggleRightBrakeFailure,
        /// <summary>
        /// Toggle engine 1 failure
        /// </summary>
        ToggleEngine1Failure,
        /// <summary>
        /// Toggle engine 2 failure
        /// </summary>
        ToggleEngine2Failure,
        /// <summary>
        /// Toggle engine 3 failure
        /// </summary>
        ToggleEngine3Failure,
        /// <summary>
        /// Toggle engine 4 failure
        /// </summary>
        ToggleEngine4Failure,
        /// <summary>
        /// Toggle smoke system switch
        /// </summary>
        SmokeToggle,
        /// <summary>
        /// Toggle gear handle
        /// </summary>
        GearToggle,
        /// <summary>
        /// Increment brake pressure
        /// </summary>
        Brakes,
        /// <summary>
        /// Sets gear handle position up/down (0,1)
        /// </summary>
        GearSet,
        /// <summary>
        /// Increments left brake pressure
        /// </summary>
        BrakesLeft,
        /// <summary>
        /// Increments right brake pressure
        /// </summary>
        BrakesRight,
        /// <summary>
        /// Toggles parking brake on/off
        /// </summary>
        ParkingBrakes,
        /// <summary>
        /// Increments emergency gear extension
        /// </summary>
        GearPump,
        /// <summary>
        /// Toggles pitot heat switch
        /// </summary>
        PitotHeatToggle,
        /// <summary>
        /// Turns smoke system on
        /// </summary>
        SmokeOn,
        /// <summary>
        /// Turns smoke system off
        /// </summary>
        SmokeOff,
        /// <summary>
        /// Sets smoke system on/off (1,0)
        /// </summary>
        SmokeSet,
        /// <summary>
        /// Turns pitot heat switch on
        /// </summary>
        PitotHeatOn,
        /// <summary>
        /// Turns pitot heat switch off
        /// </summary>
        PitotHeatOff,
        /// <summary>
        /// Sets pitot heat switch on/off (1,0)
        /// </summary>
        PitotHeatSet,
        /// <summary>
        /// Sets gear handle in UP position
        /// </summary>
        GearUp,
        /// <summary>
        /// Sets gear handle in DOWN position
        /// </summary>
        GearDown,
        /// <summary>
        /// Toggles main battery switch
        /// </summary>
        ToggleMasterBattery,
        /// <summary>
        /// Toggles main alternator/generator switch
        /// </summary>
        ToggleMasterAlternator,
        /// <summary>
        /// Toggles backup electric vacuum pump
        /// </summary>
        ToggleElectricVacuumPump,
        /// <summary>
        /// Toggles alternate static pressure port
        /// </summary>
        ToggleAlternateStatic,
        /// <summary>
        /// Decrements decision height reference
        /// </summary>
        DecisionHeightDec,
        /// <summary>
        /// Increments decision height reference
        /// </summary>
        DecisionHeightInc,
        /// <summary>
        /// Toggles structural deice switch
        /// </summary>
        ToggleStructuralDeice,
        /// <summary>
        /// Toggles propeller deice switch
        /// </summary>
        TogglePropellerDeice,
        /// <summary>
        /// Toggles alternator/generator 1 switch
        /// </summary>
        ToggleAlternator1,
        /// <summary>
        /// Toggles alternator/generator 2 switch
        /// </summary>
        ToggleAlternator2,
        /// <summary>
        /// Toggles alternator/generator 3 switch
        /// </summary>
        ToggleAlternator3,
        /// <summary>
        /// Toggles alternator/generator 4 switch
        /// </summary>
        ToggleAlternator4,
        /// <summary>
        /// Toggles master battery and alternator switch
        /// </summary>
        ToggleMasterBatteryAlternator,
        /// <summary>
        /// Sets left brake position from axis controller (e.g. joystick). -16383 (0brakes) to +16383 (max brakes)
        /// </summary>
        AxisLeftBrakeSet,
        /// <summary>
        /// Sets right brake position from axis controller (e.g. joystick). -16383 (0brakes) to +16383 (max brakes)
        /// </summary>
        AxisRightBrakeSet,
        /// <summary>
        /// Toggles primary door open/close. Follow by KEY_SELECT_2, etc for subsequent doors.
        /// </summary>
        ToggleAircraftExit,
        /// <summary>
        /// Toggles wing folding
        /// </summary>
        ToggleWingFold,
        /// <summary>
        /// Sets the wings into the folded position suitable for storage, typically on a carrier. Takes a value:1 -fold wings, 0 - unfold wings
        /// </summary>
        SetWingFold,
        /// <summary>
        /// Toggles tail hook
        /// </summary>
        ToggleTailHookHandle,
        /// <summary>
        /// Sets the tail hook handle. Takes a value: 1 - set tail hook, 0 - retract tail hook
        /// </summary>
        SetTailHookHandle,
        /// <summary>
        /// Toggles water rudders
        /// </summary>
        ToggleWaterRudder,
        /// <summary>
        /// Toggles pushback.
        /// </summary>
        PushbackSet,
        /// <summary>
        /// Triggers tug and sets the desired heading. The units are a 32 bit integer (0 to4294967295) which represent 0 to 360 degrees. To set a 45 degree angle, for example, set the value to 4294967295 / 8.
        /// </summary>
        TugHeading,
        /// <summary>
        /// Triggers tug, and sets desired speed, in feet per second. The speed can be bothpositive (forward movement) and negative (backward movement).
        /// </summary>
        TugSpeed,
        /// <summary>
        /// Disables tug
        /// </summary>
        TugDisable,
        /// <summary>
        /// Toggles master ignition switch
        /// </summary>
        ToggleMasterIgnitionSwitch,
        /// <summary>
        /// Toggles tail wheel lock
        /// </summary>
        ToggleTailwheelLock,
        /// <summary>
        /// Adds fuel to the aircraft, 25% of capacity by default. 0 to 65535 (max fuel) canbe passed.
        /// </summary>
        AddFuelQuantity,
        /// <summary>
        /// Release a towed aircraft, usually a glider.
        /// </summary>
        TowPlaneRelease,
        /// <summary>
        /// Request a tow plane. The user aircraft must be tow-able, stationary, on the ground and not already attached for this to succeed.
        /// </summary>
        RequestTowPlane,
        /// <summary>
        /// Release one droppable object. Multiple key events will release multiple objects.
        /// </summary>
        ReleaseDroppableObjects,
        /// <summary>
        /// If the plane has retractable floats, moves the retract position from Extend to Neutral, or Neutral to Retract.
        /// </summary>
        RetractFloatSwitchDec,
        /// <summary>
        /// If the plane has retractable floats, moves the retract position from Retract to Neutral, or Neutral to Extend.
        /// </summary>
        RetractFloatSwitchInc,
        /// <summary>
        /// Turn the water ballast valve on or off.
        /// </summary>
        ToggleWaterBallastValve,
        /// <summary>
        /// Turn the variometer on or off.
        /// </summary>
        ToggleVariometerSwitch,
        /// <summary>
        /// Turn the turn indicator on or off.
        /// </summary>
        ToggleTurnIndicatorSwitch,
        /// <summary>
        /// Start up the auxiliary power unit (APU).
        /// </summary>
        ApuStarter,
        /// <summary>
        /// Turn the APU off.
        /// </summary>
        ApuOffSwitch,
        /// <summary>
        /// Turn the auxiliary generator on or off.
        /// </summary>
        ApuGeneratorSwitchToggle,
        /// <summary>
        /// Set the auxiliary generator switch (0,1).
        /// </summary>
        ApuGeneratorSwitchSet,
        /// <summary>
        /// Takes a two digit argument.The first digit represents the fire extinguisher index, and the second represents the engine index.For example,11 would represent using bottle 1 on engine 1.21 would represent using bottle 2 on engine 1.Typical entries for a twin engine aircraft would be 11 and 22.
        /// </summary>
        ExtinguishEngineFire,
        /// <summary>
        /// Turn the hydraulic switch on or off.
        /// </summary>
        HydraulicSwitchToggle,
        /// <summary>
        /// Increases the bleed air source control.
        /// </summary>
        BleedAirSourceControlInc,
        /// <summary>
        /// Decreases the bleed air source control.
        /// </summary>
        BleedAirSourceControlDec,
        /// <summary>
        /// Set to one of: 0: auto1: off2: apu3: engines
        /// </summary>
        BleedAirSourceControlSet,
        /// <summary>
        /// Turn the turbine ignition switch on or off.
        /// </summary>
        TurbineIgnitionSwitchToggle,
        /// <summary>
        /// "Turn the ""No smoking"" alert on or off."
        /// </summary>
        CabinNoSmokingAlert,
        /// <summary>
        /// "Turn the ""Fasten seatbelts"" alert on or off."
        /// </summary>
        CabinSeatbeltsAlert,
        /// <summary>
        /// Turn the anti-skid braking system on or off.
        /// </summary>
        AntiskidBrakesToggle,
        /// <summary>
        /// Turn the g round proximity warning system (GPWS) on or off.
        /// </summary>
        GpwsSwitchToggle,
        /// <summary>
        /// Activate the manual fuel pressure pump.
        /// </summary>
        ManualFuelPressurePump,
        /// <summary>
        /// Togles the annunciator switch.
        /// </summary>
        AnnunciatorSwitchToggle,
        /// <summary>
        /// Turns on the annunciator switch.
        /// </summary>
        AnnunciatorSwitchOn,
        /// <summary>
        /// Turns off the annunciator switch.
        /// </summary>
        AnnunciatorSwitchOff,
        /// <summary>
        /// Increments the nose wheel steering position by 5 percent.
        /// </summary>
        SteeringInc,
        /// <summary>
        /// Decrements the nose wheel steering position by 5 percent.
        /// </summary>
        SteeringDec,
        /// <summary>
        /// Sets the value of the nose wheel steering position. Zero is straight ahead(-16383, far left +16383, far right).
        /// </summary>
        SteeringSet,
        /// <summary>
        /// Increases the altitude that the cabin is pressurized to.
        /// </summary>
        PressurizationPressureAltInc,
        /// <summary>
        /// Decreases the altitude that the cabin is pressurized to.
        /// </summary>
        PressurizationPressureAltDec,
        /// <summary>
        /// Sets the rate at which cabin pressurization is increased.
        /// </summary>
        PressurizationClimbRateInc,
        /// <summary>
        /// Sets the rate at which cabin pressurization is decreased.
        /// </summary>
        PressurizationClimbRateDec,
        /// <summary>
        /// Sets the cabin pressure to the outside air pressure.
        /// </summary>
        PressurizationPressureDump,
        /// <summary>
        /// Deploy or remove the assist arm. Refer to the document Notes on Aircraft Systems.
        /// </summary>
        TakeoffAssistArmToggle,
        /// <summary>
        /// Value: TRUE request set FALSE request unset
        /// </summary>
        TakeoffAssistArmSet,
        /// <summary>
        /// If everything is set up correctly. Launch from the catapult.
        /// </summary>
        TakeoffAssistFire,
        /// <summary>
        /// Toggle the request for the launch bar to be installed or removed.
        /// </summary>
        ToggleLaunchBarSwitch,
        /// <summary>
        /// Value: TRUE request set FALSE request unset
        /// </summary>
        SetLaunchbarSwitch,
        /// <summary>
        /// Triggers rotor braking input
        /// </summary>
        RotorBrake,
        /// <summary>
        /// Toggles on electric rotor clutch switch
        /// </summary>
        RotorClutchSwitchToggle,
        /// <summary>
        /// Sets electric rotor clutch switch on/off (1,0)
        /// </summary>
        RotorClutchSwitchSet,
        /// <summary>
        /// Toggles the electric rotor governor switch
        /// </summary>
        RotorGovSwitchToggle,
        /// <summary>
        /// Sets the electric rotor governor switch on/off (1,0)
        /// </summary>
        RotorGovSwitchSet,
        /// <summary>
        /// Increments the lateral (right) rotor trim
        /// </summary>
        RotorLateralTrimInc,
        /// <summary>
        /// Decrements the lateral (right) rotor trim
        /// </summary>
        RotorLateralTrimDec,
        /// <summary>
        /// Sets the lateral (right) rotor trim (0 to 16383)
        /// </summary>
        RotorLateralTrimSet,
        /// <summary>
        /// Toggle between pickup and release mode. Hold mode is automatic and cannot be selected. Refer to the document Notes on Aircraft Systems.
        /// </summary>
        SlingPickupRelease,
        /// <summary>
        /// The rate at which a hoist cable extends is set in the Aircraft Configuration File.
        /// </summary>
        HoistSwitchExtend,
        /// <summary>
        /// The rate at which a hoist cable retracts is set in the Aircraft Configuration File.
        /// </summary>
        HoistSwitchRetract,
        /// <summary>
        /// The data value should be set to one of: &lt;0 up=0 off &gt;0 down
        /// </summary>
        HoistSwitchSet,
        /// <summary>
        /// Toggles the hoist arm switch, extend or retract.
        /// </summary>
        HoistDeployToggle,
        /// <summary>
        /// The data value should be set to: 0 - set hoist switch to retract the arm1 - set hoist switch to extend the arm
        /// </summary>
        HoistDeploySet,
        /// <summary>
        /// Toggles slew on/off
        /// </summary>
        SlewToggle,
        /// <summary>
        /// Turns slew off
        /// </summary>
        SlewOff,
        /// <summary>
        /// Turns slew on
        /// </summary>
        SlewOn,
        /// <summary>
        /// Sets slew on/off (1,0)
        /// </summary>
        SlewSet,
        /// <summary>
        /// Stop slew and reset pitch, bank, and heading all to zero.
        /// </summary>
        SlewReset,
        /// <summary>
        /// Slew upward fast
        /// </summary>
        SlewAltitUpFast,
        /// <summary>
        /// Slew upward slow
        /// </summary>
        SlewAltitUpSlow,
        /// <summary>
        /// Stop vertical slew
        /// </summary>
        SlewAltitFreeze,
        /// <summary>
        /// Slew downward slow
        /// </summary>
        SlewAltitDnSlow,
        /// <summary>
        /// Slew downward fast
        /// </summary>
        SlewAltitDnFast,
        /// <summary>
        /// Increase upward slew
        /// </summary>
        SlewAltitPlus,
        /// <summary>
        /// Decrease upward slew
        /// </summary>
        SlewAltitMinus,
        /// <summary>
        /// Slew pitch downward fast
        /// </summary>
        SlewPitchDnFast,
        /// <summary>
        /// Slew pitch downward slow
        /// </summary>
        SlewPitchDnSlow,
        /// <summary>
        /// Stop pitch slew
        /// </summary>
        SlewPitchFreeze,
        /// <summary>
        /// Slew pitch up slow
        /// </summary>
        SlewPitchUpSlow,
        /// <summary>
        /// Slew pitch upward fast
        /// </summary>
        SlewPitchUpFast,
        /// <summary>
        /// Increase pitch up slew
        /// </summary>
        SlewPitchPlus,
        /// <summary>
        /// Decrease pitch up slew
        /// </summary>
        SlewPitchMinus,
        /// <summary>
        /// Increase left bank slew
        /// </summary>
        SlewBankMinus,
        /// <summary>
        /// Increase forward slew
        /// </summary>
        SlewAheadPlus,
        /// <summary>
        /// Increase right bank slew
        /// </summary>
        SlewBankPlus,
        /// <summary>
        /// Slew to the left
        /// </summary>
        SlewLeft,
        /// <summary>
        /// Stop all slew
        /// </summary>
        SlewFreeze,
        /// <summary>
        /// Slew to the right
        /// </summary>
        SlewRight,
        /// <summary>
        /// Increase slew heading to the left
        /// </summary>
        SlewHeadingMinus,
        /// <summary>
        /// Decrease forward slew
        /// </summary>
        SlewAheadMinus,
        /// <summary>
        /// Increase slew heading to the right
        /// </summary>
        SlewHeadingPlus,
        /// <summary>
        /// Sets forward slew (+/- 16383)
        /// </summary>
        AxisSlewAheadSet,
        /// <summary>
        /// Sets sideways slew (+/- 16383)
        /// </summary>
        AxisSlewSidewaysSet,
        /// <summary>
        /// Sets heading slew (+/- 16383)
        /// </summary>
        AxisSlewHeadingSet,
        /// <summary>
        /// Sets vertical slew (+/- 16383)
        /// </summary>
        AxisSlewAltSet,
        /// <summary>
        /// Sets roll slew (+/- 16383)
        /// </summary>
        AxisSlewBankSet,
        /// <summary>
        /// Sets pitch slew (+/- 16383)
        /// </summary>
        AxisSlewPitchSet,
        /// <summary>
        /// Selects next view
        /// </summary>
        ViewMode,
        /// <summary>
        /// Sets active window to front
        /// </summary>
        ViewWindowToFront,
        /// <summary>
        /// Resets the view to the default
        /// </summary>
        ViewReset,
        /// <summary>
        /// 
        /// </summary>
        ViewAlwaysPanUp,
        /// <summary>
        /// 
        /// </summary>
        ViewAlwaysPanDown,
        /// <summary>
        /// 
        /// </summary>
        NextSubView,
        /// <summary>
        /// 
        /// </summary>
        PrevSubView,
        /// <summary>
        /// 
        /// </summary>
        ViewTrackPanToggle,
        /// <summary>
        /// 
        /// </summary>
        ViewPreviousToggle,
        /// <summary>
        /// 
        /// </summary>
        ViewCameraSelectStarting,
        /// <summary>
        /// 
        /// </summary>
        PanelHudNext,
        /// <summary>
        /// 
        /// </summary>
        PanelHudPrevious,
        /// <summary>
        /// Zooms view in
        /// </summary>
        ZoomIn,
        /// <summary>
        /// Zooms view out
        /// </summary>
        ZoomOut,
        /// <summary>
        /// Fine zoom in map view
        /// </summary>
        MapZoomFineIn,
        /// <summary>
        /// Pans view left
        /// </summary>
        PanLeft,
        /// <summary>
        /// Pans view right
        /// </summary>
        PanRight,
        /// <summary>
        /// Fine zoom out in map view
        /// </summary>
        MapZoomFineOut,
        /// <summary>
        /// Sets view direction forward
        /// </summary>
        ViewForward,
        /// <summary>
        /// Sets view direction forward and right
        /// </summary>
        ViewForwardRight,
        /// <summary>
        /// Sets view direction to the right
        /// </summary>
        ViewRight,
        /// <summary>
        /// Sets view direction to the rear and right
        /// </summary>
        ViewRearRight,
        /// <summary>
        /// Sets view direction to the rear
        /// </summary>
        ViewRear,
        /// <summary>
        /// Sets view direction to the rear and left
        /// </summary>
        ViewRearLeft,
        /// <summary>
        /// Sets view direction to the left
        /// </summary>
        ViewLeft,
        /// <summary>
        /// Sets view direction forward and left
        /// </summary>
        ViewForwardLeft,
        /// <summary>
        /// Sets view direction down
        /// </summary>
        ViewDown,
        /// <summary>
        /// Decreases zoom
        /// </summary>
        ZoomMinus,
        /// <summary>
        /// Increase zoom
        /// </summary>
        ZoomPlus,
        /// <summary>
        /// Pan view up
        /// </summary>
        PanUp,
        /// <summary>
        /// Pan view down
        /// </summary>
        PanDown,
        /// <summary>
        /// Reverse view cycle
        /// </summary>
        ViewModeRev,
        /// <summary>
        /// Zoom in fine
        /// </summary>
        ZoomInFine,
        /// <summary>
        /// Zoom out fine
        /// </summary>
        ZoomOutFine,
        /// <summary>
        /// Close current view
        /// </summary>
        CloseView,
        /// <summary>
        /// Open new view
        /// </summary>
        NewView,
        /// <summary>
        /// Select next view
        /// </summary>
        NextView,
        /// <summary>
        /// Select previous view
        /// </summary>
        PrevView,
        /// <summary>
        /// Pan view left
        /// </summary>
        PanLeftUp,
        /// <summary>
        /// Pan view left and down
        /// </summary>
        PanLeftDown,
        /// <summary>
        /// Pan view right and up
        /// </summary>
        PanRightUp,
        /// <summary>
        /// Pan view right and down
        /// </summary>
        PanRightDown,
        /// <summary>
        /// Tilt view left
        /// </summary>
        PanTiltLeft,
        /// <summary>
        /// Tilt view right
        /// </summary>
        PanTiltRight,
        /// <summary>
        /// Reset view to forward
        /// </summary>
        PanReset,
        /// <summary>
        /// Sets view forward and up
        /// </summary>
        ViewForwardUp,
        /// <summary>
        /// Sets view forward, right, and up
        /// </summary>
        ViewForwardRightUp,
        /// <summary>
        /// Sets view right and up
        /// </summary>
        ViewRightUp,
        /// <summary>
        /// Sets view rear, right, and up
        /// </summary>
        ViewRearRightUp,
        /// <summary>
        /// Sets view rear and up
        /// </summary>
        ViewRearUp,
        /// <summary>
        /// Sets view rear left and up
        /// </summary>
        ViewRearLeftUp,
        /// <summary>
        /// Sets view left and up
        /// </summary>
        ViewLeftUp,
        /// <summary>
        /// Sets view forward left and up
        /// </summary>
        ViewForwardLeftUp,
        /// <summary>
        /// Sets view up
        /// </summary>
        ViewUp,
        /// <summary>
        /// Reset panning to forward, if in cockpit view
        /// </summary>
        PanResetCockpit,
        /// <summary>
        /// Cycle view to next target
        /// </summary>
        ChaseViewNext,
        /// <summary>
        /// Cycle view to previous target
        /// </summary>
        ChaseViewPrev,
        /// <summary>
        /// Toggles chase view on/off
        /// </summary>
        ChaseViewToggle,
        /// <summary>
        /// Move eyepoint up
        /// </summary>
        EyepointUp,
        /// <summary>
        /// Move eyepoint down
        /// </summary>
        EyepointDown,
        /// <summary>
        /// Move eyepoint right
        /// </summary>
        EyepointRight,
        /// <summary>
        /// Move eyepoint left
        /// </summary>
        EyepointLeft,
        /// <summary>
        /// Move eyepoint forward
        /// </summary>
        EyepointForward,
        /// <summary>
        /// Move eyepoint backward
        /// </summary>
        EyepointBack,
        /// <summary>
        /// Move eyepoint to default position
        /// </summary>
        EyepointReset,
        /// <summary>
        /// Opens new map view
        /// </summary>
        NewMap,
        /// <summary>
        /// Switch immediately to the forward view, in 2D mode.
        /// </summary>
        ViewCockpitForward,
        /// <summary>
        /// Switch immediately to the forward view, in virtual cockpit mode.
        /// </summary>
        ViewVirtualCockpitForward,
        /// <summary>
        /// Sets the alpha-blending value for the panel. Takes a parameter in the range 0to 255. The alpha-blending can be changed from the keyboard using Ctrl-Shift-T,and the plus and minus keys.
        /// </summary>
        ViewPanelAlphaSet,
        /// <summary>
        /// Sets the mode to change the alpha-blending, so the keys KEY_PLUS and KEY_MINUS increment and decrement the value.
        /// </summary>
        ViewPanelAlphaSelect,
        /// <summary>
        /// Increment alpha-blending for the panel.
        /// </summary>
        ViewPanelAlphaInc,
        /// <summary>
        /// Decrement alpha-blending for the panel.
        /// </summary>
        ViewPanelAlphaDec,
        /// <summary>
        /// Links all the views from one camera together, so that panning the view will change the view of all the linked cameras.
        /// </summary>
        ViewLinkingSet,
        /// <summary>
        /// Turns view linking on or off.
        /// </summary>
        ViewLinkingToggle,
        /// <summary>
        /// Increments the distance of the view camera from the chase object (such as in Spot Plane view, or viewing an AI controlled aircraft).
        /// </summary>
        ViewChaseDistanceAdd,
        /// <summary>
        /// Decrements the distance of the view camera from the chase object.
        /// </summary>
        ViewChaseDistanceSub,
        /// <summary>
        /// Toggles pause on/off
        /// </summary>
        PauseToggle,
        /// <summary>
        /// Turns pause on
        /// </summary>
        PauseOn,
        /// <summary>
        /// Turns pause off
        /// </summary>
        PauseOff,
        /// <summary>
        /// Sets pause on/off (1,0)
        /// </summary>
        PauseSet,
        /// <summary>
        /// Stops demo system playback
        /// </summary>
        DemoStop,
        /// <summary>
        /// "Sets ""selected"" index (for other events) to 1"
        /// </summary>
        Select1,
        /// <summary>
        /// "Sets ""selected"" index (for other events) to 2"
        /// </summary>
        Select2,
        /// <summary>
        /// "Sets ""selected"" index (for other events) to 3"
        /// </summary>
        Select3,
        /// <summary>
        /// "Sets ""selected"" index (for other events) to 4"
        /// </summary>
        Select4,
        /// <summary>
        /// "Used in conjunction with ""selected"" parameters to decrease their value (e.g.,radio frequency)"
        /// </summary>
        Minus,
        /// <summary>
        /// "Used in conjunction with ""selected"" parameters to increase their value (e.g.,radio frequency)"
        /// </summary>
        Plus,
        /// <summary>
        /// Sets zoom level to 1
        /// </summary>
        Zoom1x,
        /// <summary>
        /// Toggles sound on/off
        /// </summary>
        SoundToggle,
        /// <summary>
        /// Selects simulation rate (use KEY_MINUS, KEY_PLUS to change)
        /// </summary>
        SimRate,
        /// <summary>
        /// Toggles joystick on/off
        /// </summary>
        JoystickCalibrate,
        /// <summary>
        /// Saves flight situation
        /// </summary>
        SituationSave,
        /// <summary>
        /// Resets flight situation
        /// </summary>
        SituationReset,
        /// <summary>
        /// Sets sound on/off (1,0)
        /// </summary>
        SoundSet,
        /// <summary>
        /// Quit ESP with a message
        /// </summary>
        Exit,
        /// <summary>
        /// Quit ESP without a message
        /// </summary>
        Abort,
        /// <summary>
        /// Cycle through information readouts while in slew
        /// </summary>
        ReadoutsSlew,
        /// <summary>
        /// Cycle through information readouts
        /// </summary>
        ReadoutsFlight,
        /// <summary>
        /// Used with other events
        /// </summary>
        MinusShift,
        /// <summary>
        /// Used with other events
        /// </summary>
        PlusShift,
        /// <summary>
        /// Increase sim rate
        /// </summary>
        SimRateIncr,
        /// <summary>
        /// Decrease sim rate
        /// </summary>
        SimRateDecr,
        /// <summary>
        /// Toggles kneeboard
        /// </summary>
        Kneeboard,
        /// <summary>
        /// Toggles panel 1
        /// </summary>
        Panel1,
        /// <summary>
        /// Toggles panel 2
        /// </summary>
        Panel2,
        /// <summary>
        /// Toggles panel 3
        /// </summary>
        Panel3,
        /// <summary>
        /// Toggles panel 4
        /// </summary>
        Panel4,
        /// <summary>
        /// Toggles panel 5
        /// </summary>
        Panel5,
        /// <summary>
        /// Toggles panel 6
        /// </summary>
        Panel6,
        /// <summary>
        /// Toggles panel 7
        /// </summary>
        Panel7,
        /// <summary>
        /// Toggles panel 8
        /// </summary>
        Panel8,
        /// <summary>
        /// Toggles panel 9
        /// </summary>
        Panel9,
        /// <summary>
        /// Turns sound on
        /// </summary>
        SoundOn,
        /// <summary>
        /// Turns sound off
        /// </summary>
        SoundOff,
        /// <summary>
        /// Brings up Help system
        /// </summary>
        InvokeHelp,
        /// <summary>
        /// Toggles aircraft labels
        /// </summary>
        ToggleAircraftLabels,
        /// <summary>
        /// Brings up flight map
        /// </summary>
        FlightMap,
        /// <summary>
        /// Reload panel data
        /// </summary>
        ReloadPanels,
        /// <summary>
        /// Toggles indexed panel (1 to 9)
        /// </summary>
        PanelIdToggle,
        /// <summary>
        /// Opens indexed panel (1 to 9)
        /// </summary>
        PanelIdOpen,
        /// <summary>
        /// Closes indexed panel (1 to 9)
        /// </summary>
        PanelIdClose,
        /// <summary>
        /// Reloads the user aircraft data (from cache if same type loaded as an AI,otherwise from disk)
        /// </summary>
        ControlReloadUserAircraft,
        /// <summary>
        /// Resets aircraft state
        /// </summary>
        SimReset,
        /// <summary>
        /// Turns Flying Tips on/off
        /// </summary>
        VirtualCopilotToggle,
        /// <summary>
        /// Sets Flying Tips on/off (1,0)
        /// </summary>
        VirtualCopilotSet,
        /// <summary>
        /// Triggers action noted in Flying Tips
        /// </summary>
        VirtualCopilotAction,
        /// <summary>
        /// Reloads scenery
        /// </summary>
        RefreshScenery,
        /// <summary>
        /// Decrements time by hours
        /// </summary>
        ClockHoursDec,
        /// <summary>
        /// Increments time by hours
        /// </summary>
        ClockHoursInc,
        /// <summary>
        /// Decrements time by minutes
        /// </summary>
        ClockMinutesDec,
        /// <summary>
        /// Increments time by minutes
        /// </summary>
        ClockMinutesInc,
        /// <summary>
        /// Zeros seconds
        /// </summary>
        ClockSecondsZero,
        /// <summary>
        /// Sets hour of day
        /// </summary>
        ClockHoursSet,
        /// <summary>
        /// Sets minutes of the hour
        /// </summary>
        ClockMinutesSet,
        /// <summary>
        /// Sets hours, zulu time
        /// </summary>
        ZuluHoursSet,
        /// <summary>
        /// Sets minutes, in zulu time
        /// </summary>
        ZuluMinutesSet,
        /// <summary>
        /// Sets day, in zulu time
        /// </summary>
        ZuluDaySet,
        /// <summary>
        /// Sets year, in zulu time
        /// </summary>
        ZuluYearSet,
        /// <summary>
        /// Enables a keystroke to be sent to a gauge that is in focus. The keystrokes can only be in the range 0 to 9, A to Z, and the four keys: plus, minus, comma and period. This is typically used to allow some keyboard entry to a complex device such as a GPS to enter such things as ICAO codes using the keyboard, rather than turning dials.
        /// </summary>
        GaugeKeystroke,
        /// <summary>
        /// Display the ATC window.
        /// </summary>
        SimuiWindowHideshow,
        /// <summary>
        /// Turn window titles on or off.
        /// </summary>
        WindowTitlesToggle,
        /// <summary>
        /// Sets the pitch of the axis. Requires an angle.
        /// </summary>
        AxisPanPitch,
        /// <summary>
        /// Sets the heading of the axis. Requires an angle.
        /// </summary>
        AxisPanHeading,
        /// <summary>
        /// Sets the tilt of the axis. Requires an angle.
        /// </summary>
        AxisPanTilt,
        /// <summary>
        /// Step through the view axes.
        /// </summary>
        AxisIndicatorCycle,
        /// <summary>
        /// Step through the map orientations.
        /// </summary>
        MapOrientationCycle,
        /// <summary>
        /// Requests a jetway, which will only be answered if the aircraft is at a parking spot.
        /// </summary>
        ToggleJetway,
        /// <summary>
        /// Turn on or off the video recording feature. This records uncompressed AVI format files to: My Documents\Videos\
        /// </summary>
        VideoRecordToggle,
        /// <summary>
        /// Turn on or off the airport name.
        /// </summary>
        ToggleAirportNameDisplay,
        /// <summary>
        /// Capture the current view as a screenshot. Which will be saved to a bmp file in: My Documents\Pictures\
        /// </summary>
        CaptureScreenshot,
        /// <summary>
        /// Switch Mouse Look mode on or off. Mouse Look mode enables a user to control their view using the mouse, and holding down the space bar.
        /// </summary>
        MouseLookToggle,
        /// <summary>
        /// Switch inversion of Y axis controls on or off.
        /// </summary>
        YaxisInvertToggle,
        /// <summary>
        /// Turn the automatic rudder control feature on or off.
        /// </summary>
        AutocoordToggle,
        /// <summary>
        /// Turns the freezing of the lat/lon position of the aircraft (either user or AI controlled) on or off. If this key event is set, it means that the latitude and longitude of the aircraft are not being controlled by ESP, so enabling, for example, a SimConnect client to control the position of the aircraft. This can also apply to altitude and attitude. Refer to the simulation variables: IS LATITUDE LONGITUDE FREEZE ON, IS ALTITUDE FREEZE ON, and IS ATTITUDE FREEZE ON Refer also to the SimConnect_AIReleaseControl function.
        /// </summary>
        FreezeLatitudeLongitudeToggle,
        /// <summary>
        /// Freezes the lat/lon position of the aircraft.
        /// </summary>
        FreezeLatitudeLongitudeSet,
        /// <summary>
        /// Turns the freezing of the altitude of the aircraft on or off.
        /// </summary>
        FreezeAltitudeToggle,
        /// <summary>
        /// Freezes the altitude of the aircraft.
        /// </summary>
        FreezeAltitudeSet,
        /// <summary>
        /// Turns the freezing of the attitude (pitch, bank and heading) of the aircraft on or off.
        /// </summary>
        FreezeAttitudeToggle,
        /// <summary>
        /// Freezes the attitude (pitch, bank and heading) of the aircraft.
        /// </summary>
        FreezeAttitudeSet,
        /// <summary>
        /// Turn the point-of-interest indicator (often a light beam) on or off. Refer to the Missions system documentation.
        /// </summary>
        PointOfInterestTogglePointer,
        /// <summary>
        /// Change the current point-of-interest to the previous point-of-interest.
        /// </summary>
        PointOfInterestCyclePrevious,
        /// <summary>
        /// Change the current point-of-interest to the next point-of-interest.
        /// </summary>
        PointOfInterestCycleNext,
        /// <summary>
        /// Activates ATC window
        /// </summary>
        Atc,
        /// <summary>
        /// Selects ATC option 1
        /// </summary>
        AtcMenu1,
        /// <summary>
        /// Selects ATC option 2
        /// </summary>
        AtcMenu2,
        /// <summary>
        /// Selects ATC option 3
        /// </summary>
        AtcMenu3,
        /// <summary>
        /// Selects ATC option 4
        /// </summary>
        AtcMenu4,
        /// <summary>
        /// Selects ATC option 5
        /// </summary>
        AtcMenu5,
        /// <summary>
        /// Selects ATC option 6
        /// </summary>
        AtcMenu6,
        /// <summary>
        /// Selects ATC option 7
        /// </summary>
        AtcMenu7,
        /// <summary>
        /// Selects ATC option 8
        /// </summary>
        AtcMenu8,
        /// <summary>
        /// Selects ATC option 9
        /// </summary>
        AtcMenu9,
        /// <summary>
        /// Selects ATC option 10
        /// </summary>
        AtcMenu0,
        /// <summary>
        /// Toggle to the next player to track
        /// </summary>
        MultiplayerTransferControl,
        /// <summary>
        /// Cycle through the current user aircraft.
        /// </summary>
        MultiplayerPlayerCycle,
        /// <summary>
        /// Set the view to follow the selected user aircraft.
        /// </summary>
        MultiplayerPlayerFollow,
        /// <summary>
        /// Toggles chat window visible/invisible
        /// </summary>
        MultiplayerChat,
        /// <summary>
        /// Activates chat window
        /// </summary>
        MultiplayerActivateChat,
        /// <summary>
        /// Start capturing audio from the users computer and transmitting it to all other players in the multiplayer session who are turned to the same radio frequency.
        /// </summary>
        MultiplayerVoiceCaptureStart,
        /// <summary>
        /// Stop capturing radio audio.
        /// </summary>
        MultiplayerVoiceCaptureStop,
        /// <summary>
        /// Start capturing audio from the users computer and transmitting it to all other players in the multiplayer session.
        /// </summary>
        MultiplayerBroadcastVoice,
        /// <summary>
        /// Show or hide multi-player race results.
        /// </summary>
        ToggleRaceresultsWindow,
        /// <summary>
        /// Set COM1 Active frequency.
        /// </summary>
        ComRadioSetHz,
        /// <summary>
        /// Set COM2 Active frequency.
        /// </summary>
        Com2RadioSetHz,
        /// <summary>
        /// Set NAV1 Standby frequency.
        /// </summary>
        Nav1RadioSetHz,
        /// <summary>
        /// Set NAV2 Standby frequency.
        /// </summary>
        Nav2RadioSetHz,
        /// <summary>
        /// Set COM1 Standby frequency.
        /// </summary>
        ComStbyRadioSetHz,
        /// <summary>
        /// Set COM2 Standby frequency.
        /// </summary>
        Com2StbyRadioSetHz,
        /// <summary>
        /// Set NAV1 Standby frequency.
        /// </summary>
        Nav1StbyRadioSetHz,
        /// <summary>
        /// Set NAV2 Standby frequency.
        /// </summary>
        Nav2StbyRadioSetHz,
    };
    
    /// <summary>
    /// Provides lookup of FsEventNameId enums to event names that can be registered in MSFS.
    /// </summary>
    internal static class FsEventNameLookup
    {
        private static string[] _fsEventName = new string[] {
            "THROTTLE_FULL",
            "THROTTLE_INCR",
            "THROTTLE_INCR_SMALL",
            "THROTTLE_DECR",
            "THROTTLE_DECR_SMALL",
            "THROTTLE_CUT",
            "INCREASE_THROTTLE",
            "DECREASE_THROTTLE",
            "THROTTLE_SET",
            "AXIS_THROTTLE_SET",
            "THROTTLE1_SET",
            "THROTTLE2_SET",
            "THROTTLE3_SET",
            "THROTTLE4_SET",
            "THROTTLE1_FULL",
            "THROTTLE1_INCR",
            "THROTTLE1_INCR_SMALL",
            "THROTTLE1_DECR",
            "THROTTLE1_CUT",
            "THROTTLE2_FULL",
            "THROTTLE2_INCR",
            "THROTTLE2_INCR_SMALL",
            "THROTTLE2_DECR",
            "THROTTLE2_CUT",
            "THROTTLE3_FULL",
            "THROTTLE3_INCR",
            "THROTTLE3_INCR_SMALL",
            "THROTTLE3_DECR",
            "THROTTLE3_CUT",
            "THROTTLE4_FULL",
            "THROTTLE4_INCR",
            "THROTTLE4_INCR_SMALL",
            "THROTTLE4_DECR",
            "THROTTLE4_CUT",
            "THROTTLE_10",
            "THROTTLE_20",
            "THROTTLE_30",
            "THROTTLE_40",
            "THROTTLE_50",
            "THROTTLE_60",
            "THROTTLE_70",
            "THROTTLE_80",
            "THROTTLE_90",
            "AXIS_THROTTLE1_SET",
            "AXIS_THROTTLE2_SET",
            "AXIS_THROTTLE3_SET",
            "AXIS_THROTTLE4_SET",
            "THROTTLE1_DECR_SMALL",
            "THROTTLE2_DECR_SMALL",
            "THROTTLE3_DECR_SMALL",
            "THROTTLE4_DECR_SMALL",
            "PROP_PITCH_DECR_SMALL",
            "PROP_PITCH1_DECR_SMALL",
            "PROP_PITCH2_DECR_SMALL",
            "PROP_PITCH3_DECR_SMALL",
            "PROP_PITCH4_DECR_SMALL",
            "MIXTURE1_RICH",
            "MIXTURE1_INCR",
            "MIXTURE1_INCR_SMALL",
            "MIXTURE1_DECR",
            "MIXTURE1_LEAN",
            "MIXTURE2_RICH",
            "MIXTURE2_INCR",
            "MIXTURE2_INCR_SMALL",
            "MIXTURE2_DECR",
            "MIXTURE2_LEAN",
            "MIXTURE3_RICH",
            "MIXTURE3_INCR",
            "MIXTURE3_INCR_SMALL",
            "MIXTURE3_DECR",
            "MIXTURE3_LEAN",
            "MIXTURE4_RICH",
            "MIXTURE4_INCR",
            "MIXTURE4_INCR_SMALL",
            "MIXTURE4_DECR",
            "MIXTURE4_LEAN",
            "MIXTURE_SET",
            "MIXTURE_RICH",
            "MIXTURE_INCR",
            "MIXTURE_INCR_SMALL",
            "MIXTURE_DECR",
            "MIXTURE_LEAN",
            "MIXTURE1_SET",
            "MIXTURE2_SET",
            "MIXTURE3_SET",
            "MIXTURE4_SET",
            "AXIS_MIXTURE_SET",
            "AXIS_MIXTURE1_SET",
            "AXIS_MIXTURE2_SET",
            "AXIS_MIXTURE3_SET",
            "AXIS_MIXTURE4_SET",
            "MIXTURE_SET_BEST",
            "MIXTURE_DECR_SMALL",
            "MIXTURE1_DECR_SMALL",
            "MIXTURE2_DECR_SMALL",
            "MIXTURE3_DECR_SMALL",
            "MIXTURE4_DECR_SMALL",
            "PROP_PITCH_SET",
            "PROP_PITCH_LO",
            "PROP_PITCH_INCR",
            "PROP_PITCH_INCR_SMALL",
            "PROP_PITCH_DECR",
            "PROP_PITCH_HI",
            "PROP_PITCH1_SET",
            "PROP_PITCH2_SET",
            "PROP_PITCH3_SET",
            "PROP_PITCH4_SET",
            "PROP_PITCH1_LO",
            "PROP_PITCH1_INCR",
            "PROP_PITCH1_INCR_SMALL",
            "PROP_PITCH1_DECR",
            "PROP_PITCH1_HI",
            "PROP_PITCH2_LO",
            "PROP_PITCH2_INCR",
            "PROP_PITCH2_INCR_SMALL",
            "PROP_PITCH2_DECR",
            "PROP_PITCH2_HI",
            "PROP_PITCH3_LO",
            "PROP_PITCH3_INCR",
            "PROP_PITCH3_INCR_SMALL",
            "PROP_PITCH3_DECR",
            "PROP_PITCH3_HI",
            "PROP_PITCH4_LO",
            "PROP_PITCH4_INCR",
            "PROP_PITCH4_INCR_SMALL",
            "PROP_PITCH4_DECR",
            "PROP_PITCH4_HI",
            "AXIS_PROPELLER_SET",
            "AXIS_PROPELLER1_SET",
            "AXIS_PROPELLER2_SET",
            "AXIS_PROPELLER3_SET",
            "AXIS_PROPELLER4_SET",
            "JET_STARTER",
            "STARTER_SET",
            "TOGGLE_STARTER1",
            "TOGGLE_STARTER2",
            "TOGGLE_STARTER3",
            "TOGGLE_STARTER4",
            "TOGGLE_ALL_STARTERS",
            "ENGINE_AUTO_START",
            "ENGINE_AUTO_SHUTDOWN",
            "MAGNETO",
            "MAGNETO_DECR",
            "MAGNETO_INCR",
            "MAGNETO1_OFF",
            "MAGNETO1_RIGHT",
            "MAGNETO1_LEFT",
            "MAGNETO1_BOTH",
            "MAGNETO1_START",
            "MAGNETO2_OFF",
            "MAGNETO2_RIGHT",
            "MAGNETO2_LEFT",
            "MAGNETO2_BOTH",
            "MAGNETO2_START",
            "MAGNETO3_OFF",
            "MAGNETO3_RIGHT",
            "MAGNETO3_LEFT",
            "MAGNETO3_BOTH",
            "MAGNETO3_START",
            "MAGNETO4_OFF",
            "MAGNETO4_RIGHT",
            "MAGNETO4_LEFT",
            "MAGNETO4_BOTH",
            "MAGNETO4_START",
            "MAGNETO_OFF",
            "MAGNETO_RIGHT",
            "MAGNETO_LEFT",
            "MAGNETO_BOTH",
            "MAGNETO_START",
            "MAGNETO1_DECR",
            "MAGNETO1_INCR",
            "MAGNETO2_DECR",
            "MAGNETO2_INCR",
            "MAGNETO3_DECR",
            "MAGNETO3_INCR",
            "MAGNETO4_DECR",
            "MAGNETO4_INCR",
            "MAGNETO1_SET",
            "MAGNETO2_SET",
            "MAGNETO3_SET",
            "MAGNETO4_SET",
            "ANTI_ICE_ON",
            "ANTI_ICE_OFF",
            "ANTI_ICE_SET",
            "ANTI_ICE_TOGGLE",
            "ANTI_ICE_TOGGLE_ENG1",
            "ANTI_ICE_TOGGLE_ENG2",
            "ANTI_ICE_TOGGLE_ENG3",
            "ANTI_ICE_TOGGLE_ENG4",
            "ANTI_ICE_SET_ENG1",
            "ANTI_ICE_SET_ENG2",
            "ANTI_ICE_SET_ENG3",
            "ANTI_ICE_SET_ENG4",
            "TOGGLE_FUEL_VALVE_ALL",
            "TOGGLE_FUEL_VALVE_ENG1",
            "TOGGLE_FUEL_VALVE_ENG2",
            "TOGGLE_FUEL_VALVE_ENG3",
            "TOGGLE_FUEL_VALVE_ENG4",
            "COWLFLAP1_SET",
            "COWLFLAP2_SET",
            "COWLFLAP3_SET",
            "COWLFLAP4_SET",
            "INC_COWL_FLAPS",
            "DEC_COWL_FLAPS",
            "INC_COWL_FLAPS1",
            "DEC_COWL_FLAPS1",
            "INC_COWL_FLAPS2",
            "DEC_COWL_FLAPS2",
            "INC_COWL_FLAPS3",
            "DEC_COWL_FLAPS3",
            "INC_COWL_FLAPS4",
            "DEC_COWL_FLAPS4",
            "FUEL_PUMP",
            "TOGGLE_ELECT_FUEL_PUMP",
            "TOGGLE_ELECT_FUEL_PUMP1",
            "TOGGLE_ELECT_FUEL_PUMP2",
            "TOGGLE_ELECT_FUEL_PUMP3",
            "TOGGLE_ELECT_FUEL_PUMP4",
            "ENGINE_PRIMER",
            "TOGGLE_PRIMER",
            "TOGGLE_PRIMER1",
            "TOGGLE_PRIMER2",
            "TOGGLE_PRIMER3",
            "TOGGLE_PRIMER4",
            "TOGGLE_FEATHER_SWITCHES",
            "TOGGLE_FEATHER_SWITCH_1",
            "TOGGLE_FEATHER_SWITCH_2",
            "TOGGLE_FEATHER_SWITCH_3",
            "TOGGLE_FEATHER_SWITCH_4",
            "TOGGLE_PROP_SYNC",
            "TOGGLE_ARM_AUTOFEATHER",
            "TOGGLE_AFTERBURNER",
            "TOGGLE_AFTERBURNER1",
            "TOGGLE_AFTERBURNER2",
            "TOGGLE_AFTERBURNER3",
            "TOGGLE_AFTERBURNER4",
            "ENGINE",
            "SPOILERS_TOGGLE",
            "FLAPS_UP",
            "FLAPS_1",
            "FLAPS_2",
            "FLAPS_3",
            "FLAPS_DOWN",
            "ELEV_TRIM_DN",
            "ELEV_DOWN",
            "AILERONS_LEFT",
            "CENTER_AILER_RUDDER",
            "AILERONS_RIGHT",
            "ELEV_TRIM_UP",
            "ELEV_UP",
            "RUDDER_LEFT",
            "RUDDER_CENTER",
            "RUDDER_RIGHT",
            "ELEVATOR_SET",
            "AILERON_SET",
            "RUDDER_SET",
            "FLAPS_INCR",
            "FLAPS_DECR",
            "AXIS_ELEVATOR_SET",
            "AXIS_AILERONS_SET",
            "AXIS_RUDDER_SET",
            "AXIS_ELEV_TRIM_SET",
            "SPOILERS_SET",
            "SPOILERS_ARM_TOGGLE",
            "SPOILERS_ON",
            "SPOILERS_OFF",
            "SPOILERS_ARM_ON",
            "SPOILERS_ARM_OFF",
            "SPOILERS_ARM_SET",
            "AILERON_TRIM_LEFT",
            "AILERON_TRIM_RIGHT",
            "RUDDER_TRIM_LEFT",
            "RUDDER_TRIM_RIGHT",
            "AXIS_SPOILER_SET",
            "FLAPS_SET",
            "ELEVATOR_TRIM_SET",
            "AXIS_FLAPS_SET",
            "AP_MASTER",
            "AUTOPILOT_OFF",
            "AUTOPILOT_ON",
            "YAW_DAMPER_TOGGLE",
            "AP_PANEL_HEADING_HOLD",
            "AP_PANEL_ALTITUDE_HOLD",
            "AP_ATT_HOLD_ON",
            "AP_LOC_HOLD_ON",
            "AP_APR_HOLD_ON",
            "AP_HDG_HOLD_ON",
            "AP_ALT_HOLD_ON",
            "AP_WING_LEVELER_ON",
            "AP_BC_HOLD_ON",
            "AP_NAV1_HOLD_ON",
            "AP_ATT_HOLD_OFF",
            "AP_LOC_HOLD_OFF",
            "AP_APR_HOLD_OFF",
            "AP_HDG_HOLD_OFF",
            "AP_ALT_HOLD_OFF",
            "AP_WING_LEVELER_OFF",
            "AP_BC_HOLD_OFF",
            "AP_NAV1_HOLD_OFF",
            "AP_AIRSPEED_HOLD",
            "AUTO_THROTTLE_ARM",
            "AUTO_THROTTLE_TO_GA",
            "HEADING_BUG_INC",
            "HEADING_BUG_DEC",
            "HEADING_BUG_SET",
            "AP_PANEL_SPEED_HOLD",
            "AP_ALT_VAR_INC",
            "AP_ALT_VAR_DEC",
            "AP_VS_VAR_INC",
            "AP_VS_VAR_DEC",
            "AP_SPD_VAR_INC",
            "AP_SPD_VAR_DEC",
            "AP_PANEL_MACH_HOLD",
            "AP_MACH_VAR_INC",
            "AP_MACH_VAR_DEC",
            "AP_MACH_HOLD",
            "AP_ALT_VAR_SET_METRIC",
            "AP_VS_VAR_SET_ENGLISH",
            "AP_SPD_VAR_SET",
            "AP_MACH_VAR_SET",
            "YAW_DAMPER_ON",
            "YAW_DAMPER_OFF",
            "YAW_DAMPER_SET",
            "AP_AIRSPEED_ON",
            "AP_AIRSPEED_OFF",
            "AP_AIRSPEED_SET",
            "AP_MACH_ON",
            "AP_MACH_OFF",
            "AP_MACH_SET",
            "AP_PANEL_ALTITUDE_ON",
            "AP_PANEL_ALTITUDE_OFF",
            "AP_PANEL_ALTITUDE_SET",
            "AP_PANEL_HEADING_ON",
            "AP_PANEL_HEADING_OFF",
            "AP_PANEL_HEADING_SET",
            "AP_PANEL_MACH_ON",
            "AP_PANEL_MACH_OFF",
            "AP_PANEL_MACH_SET",
            "AP_PANEL_SPEED_ON",
            "AP_PANEL_SPEED_OFF",
            "AP_PANEL_SPEED_SET",
            "AP_ALT_VAR_SET_ENGLISH",
            "AP_VS_VAR_SET_METRIC",
            "TOGGLE_FLIGHT_DIRECTOR",
            "SYNC_FLIGHT_DIRECTOR_PITCH",
            "INC_AUTOBRAKE_CONTROL",
            "DEC_AUTOBRAKE_CONTROL",
            "AUTOPILOT_AIRSPEED_HOLD_CURRENT",
            "AUTOPILOT_MACH_HOLD_CURRENT",
            "AP_NAV_SELECT_SET",
            "HEADING_BUG_SELECT",
            "ALTITUDE_BUG_SELECT",
            "VSI_BUG_SELECT",
            "AIRSPEED_BUG_SELECT",
            "AP_PITCH_REF_INC_UP",
            "AP_PITCH_REF_INC_DN",
            "AP_PITCH_REF_SELECT",
            "AP_ATT_HOLD",
            "AP_LOC_HOLD",
            "AP_APR_HOLD",
            "AP_HDG_HOLD",
            "AP_ALT_HOLD",
            "AP_WING_LEVELER",
            "AP_BC_HOLD",
            "AP_NAV1_HOLD",
            "AP_MAX_BANK_INC",
            "AP_MAX_BANK_DEC",
            "AP_N1_HOLD",
            "AP_N1_REF_INC",
            "AP_N1_REF_DEC",
            "AP_N1_REF_SET",
            "FLY_BY_WIRE_ELAC_TOGGLE",
            "FLY_BY_WIRE_FAC_TOGGLE",
            "FLY_BY_WIRE_SEC_TOGGLE",
            "G1000_PFD_FLIGHTPLAN_BUTTON",
            "G1000_PFD_PROCEDURE_BUTTON",
            "G1000_PFD_ZOOMIN_BUTTON",
            "G1000_PFD_ZOOMOUT_BUTTON",
            "G1000_PFD_DIRECTTO_BUTTON",
            "G1000_PFD_MENU_BUTTON",
            "G1000_PFD_CLEAR_BUTTON",
            "G1000_PFD_ENTER_BUTTON",
            "G1000_PFD_CURSOR_BUTTON",
            "G1000_PFD_GROUP_KNOB_INC",
            "G1000_PFD_GROUP_KNOB_DEC",
            "G1000_PFD_PAGE_KNOB_INC",
            "G1000_PFD_PAGE_KNOB_DEC",
            "G1000_PFD_SOFTKEY1",
            "G1000_MFD_FLIGHTPLAN_BUTTON",
            "G1000_MFD_PROCEDURE_BUTTON",
            "G1000_MFD_ZOOMIN_BUTTON",
            "G1000_MFD_ZOOMOUT_BUTTON",
            "G1000_MFD_DIRECTTO_BUTTON",
            "G1000_MFD_MENU_BUTTON",
            "G1000_MFD_CLEAR_BUTTON",
            "G1000_MFD_ENTER_BUTTON",
            "G1000_MFD_CURSOR_BUTTON",
            "G1000_MFD_GROUP_KNOB_INC",
            "G1000_MFD_GROUP_KNOB_DEC",
            "G1000_MFD_PAGE_KNOB_INC",
            "G1000_MFD_PAGE_KNOB_DEC",
            "G1000_MFD_SOFTKEY1",
            "FUEL_SELECTOR_OFF",
            "FUEL_SELECTOR_ALL",
            "FUEL_SELECTOR_LEFT",
            "FUEL_SELECTOR_RIGHT",
            "FUEL_SELECTOR_LEFT_AUX",
            "FUEL_SELECTOR_RIGHT_AUX",
            "FUEL_SELECTOR_CENTER",
            "FUEL_SELECTOR_SET",
            "FUEL_SELECTOR_2_OFF",
            "FUEL_SELECTOR_2_ALL",
            "FUEL_SELECTOR_2_LEFT",
            "FUEL_SELECTOR_2_RIGHT",
            "FUEL_SELECTOR_2_LEFT_AUX",
            "FUEL_SELECTOR_2_RIGHT_AUX",
            "FUEL_SELECTOR_2_CENTER",
            "FUEL_SELECTOR_2_SET",
            "FUEL_SELECTOR_3_OFF",
            "FUEL_SELECTOR_3_ALL",
            "FUEL_SELECTOR_3_LEFT",
            "FUEL_SELECTOR_3_RIGHT",
            "FUEL_SELECTOR_3_LEFT_AUX",
            "FUEL_SELECTOR_3_RIGHT_AUX",
            "FUEL_SELECTOR_3_CENTER",
            "FUEL_SELECTOR_3_SET",
            "FUEL_SELECTOR_4_OFF",
            "FUEL_SELECTOR_4_ALL",
            "FUEL_SELECTOR_4_LEFT",
            "FUEL_SELECTOR_4_RIGHT",
            "FUEL_SELECTOR_4_LEFT_AUX",
            "FUEL_SELECTOR_4_RIGHT_AUX",
            "FUEL_SELECTOR_4_CENTER",
            "FUEL_SELECTOR_4_SET",
            "CROSS_FEED_OPEN",
            "CROSS_FEED_TOGGLE",
            "CROSS_FEED_OFF",
            "FUEL_DUMP_SWITCH_SET",
            "TOGGLE_ANTIDETONATION_TANK_VALVE",
            "TOGGLE_NITROUS_TANK_VALVE",
            "REPAIR_AND_REFUEL",
            "FUEL_DUMP_TOGGLE",
            "REQUEST_FUEL",
            "FUEL_SELECTOR_LEFT_MAIN",
            "FUEL_SELECTOR_2_LEFT_MAIN",
            "FUEL_SELECTOR_3_LEFT_MAIN",
            "FUEL_SELECTOR_4_LEFT_MAIN",
            "FUEL_SELECTOR_RIGHT_MAIN",
            "FUEL_SELECTOR_2_RIGHT_MAIN",
            "FUEL_SELECTOR_3_RIGHT_MAIN",
            "FUEL_SELECTOR_4_RIGHT_MAIN",
            "XPNDR",
            "ADF",
            "DME",
            "COM_RADIO",
            "VOR_OBS",
            "NAV_RADIO",
            "COM_RADIO_WHOLE_DEC",
            "COM_RADIO_WHOLE_INC",
            "COM_RADIO_FRACT_DEC",
            "COM_RADIO_FRACT_INC",
            "NAV1_RADIO_WHOLE_DEC",
            "NAV1_RADIO_WHOLE_INC",
            "NAV1_RADIO_FRACT_DEC",
            "NAV1_RADIO_FRACT_INC",
            "NAV2_RADIO_WHOLE_DEC",
            "NAV2_RADIO_WHOLE_INC",
            "NAV2_RADIO_FRACT_DEC",
            "NAV2_RADIO_FRACT_INC",
            "ADF_100_INC",
            "ADF_10_INC",
            "ADF_1_INC",
            "XPNDR_1000_INC",
            "XPNDR_100_INC",
            "XPNDR_10_INC",
            "XPNDR_1_INC",
            "VOR1_OBI_DEC",
            "VOR1_OBI_INC",
            "VOR2_OBI_DEC",
            "VOR2_OBI_INC",
            "ADF_100_DEC",
            "ADF_10_DEC",
            "ADF_1_DEC",
            "COM_RADIO_SET",
            "NAV1_RADIO_SET",
            "NAV2_RADIO_SET",
            "ADF_SET",
            "XPNDR_SET",
            "VOR1_SET",
            "VOR2_SET",
            "DME1_TOGGLE",
            "DME2_TOGGLE",
            "RADIO_VOR1_IDENT_DISABLE",
            "RADIO_VOR2_IDENT_DISABLE",
            "RADIO_DME1_IDENT_DISABLE",
            "RADIO_DME2_IDENT_DISABLE",
            "RADIO_ADF_IDENT_DISABLE",
            "RADIO_VOR1_IDENT_ENABLE",
            "RADIO_VOR2_IDENT_ENABLE",
            "RADIO_DME1_IDENT_ENABLE",
            "RADIO_DME2_IDENT_ENABLE",
            "RADIO_ADF_IDENT_ENABLE",
            "RADIO_VOR1_IDENT_TOGGLE",
            "RADIO_VOR2_IDENT_TOGGLE",
            "RADIO_DME1_IDENT_TOGGLE",
            "RADIO_DME2_IDENT_TOGGLE",
            "RADIO_ADF_IDENT_TOGGLE",
            "RADIO_VOR1_IDENT_SET",
            "RADIO_VOR2_IDENT_SET",
            "RADIO_DME1_IDENT_SET",
            "RADIO_DME2_IDENT_SET",
            "RADIO_ADF_IDENT_SET",
            "ADF_CARD_INC",
            "ADF_CARD_DEC",
            "ADF_CARD_SET",
            "DME_TOGGLE",
            "AVIONICS_MASTER_SET",
            "TOGGLE_AVIONICS_MASTER",
            "COM_STBY_RADIO_SET",
            "COM_STBY_RADIO_SWAP",
            "COM_RADIO_FRACT_DEC_CARRY",
            "COM_RADIO_FRACT_INC_CARRY",
            "COM2_RADIO_WHOLE_DEC",
            "COM2_RADIO_WHOLE_INC",
            "COM2_RADIO_FRACT_DEC",
            "COM2_RADIO_FRACT_DEC_CARRY",
            "COM2_RADIO_FRACT_INC",
            "COM2_RADIO_FRACT_INC_CARRY",
            "COM2_RADIO_SET",
            "COM2_STBY_RADIO_SET",
            "COM2_RADIO_SWAP",
            "NAV1_RADIO_FRACT_DEC_CARRY",
            "NAV1_RADIO_FRACT_INC_CARRY",
            "NAV1_STBY_SET",
            "NAV1_RADIO_SWAP",
            "NAV2_RADIO_FRACT_DEC_CARRY",
            "NAV2_RADIO_FRACT_INC_CARRY",
            "NAV2_STBY_SET",
            "NAV2_RADIO_SWAP",
            "ADF1_RADIO_TENTHS_DEC",
            "ADF1_RADIO_TENTHS_INC",
            "XPNDR_1000_DEC",
            "XPNDR_100_DEC",
            "XPNDR_10_DEC",
            "XPNDR_1_DEC",
            "XPNDR_DEC_CARRY",
            "XPNDR_INC_CARRY",
            "ADF_FRACT_DEC_CARRY",
            "ADF_FRACT_INC_CARRY",
            "COM1_TRANSMIT_SELECT",
            "COM2_TRANSMIT_SELECT",
            "COM_RECEIVE_ALL_TOGGLE",
            "COM_RECEIVE_ALL_SET",
            "MARKER_SOUND_TOGGLE",
            "ADF_COMPLETE_SET",
            "ADF_WHOLE_INC",
            "ADF_WHOLE_DEC",
            "ADF2_100_INC",
            "ADF2_10_INC",
            "ADF2_1_INC",
            "ADF2_RADIO_TENTHS_INC",
            "ADF2_100_DEC",
            "ADF2_10_DEC",
            "ADF2_1_DEC",
            "ADF2_RADIO_TENTHS_DEC",
            "ADF2_WHOLE_INC",
            "ADF2_WHOLE_DEC",
            "ADF2_FRACT_INC_CARRY",
            "ADF2_FRACT_DEC_CARRY",
            "ADF2_COMPLETE_SET",
            "RADIO_ADF2_IDENT_DISABLE",
            "RADIO_ADF2_IDENT_ENABLE",
            "RADIO_ADF2_IDENT_TOGGLE",
            "RADIO_ADF2_IDENT_SET",
            "FREQUENCY_SWAP",
            "TOGGLE_GPS_DRIVES_NAV1",
            "GPS_POWER_BUTTON",
            "GPS_NEAREST_BUTTON",
            "GPS_OBS_BUTTON",
            "GPS_MSG_BUTTON",
            "GPS_MSG_BUTTON_DOWN",
            "GPS_MSG_BUTTON_UP",
            "GPS_FLIGHTPLAN_BUTTON",
            "GPS_TERRAIN_BUTTON",
            "GPS_PROCEDURE_BUTTON",
            "GPS_ZOOMIN_BUTTON",
            "GPS_ZOOMOUT_BUTTON",
            "GPS_DIRECTTO_BUTTON",
            "GPS_MENU_BUTTON",
            "GPS_CLEAR_BUTTON",
            "GPS_CLEAR_ALL_BUTTON",
            "GPS_CLEAR_BUTTON_DOWN",
            "GPS_CLEAR_BUTTON_UP",
            "GPS_ENTER_BUTTON",
            "GPS_CURSOR_BUTTON",
            "GPS_GROUP_KNOB_INC",
            "GPS_GROUP_KNOB_DEC",
            "GPS_PAGE_KNOB_INC",
            "GPS_PAGE_KNOB_DEC",
            "DME_SELECT",
            "RADIO_SELECTED_DME_IDENT_ENABLE",
            "RADIO_SELECTED_DME_IDENT_DISABLE",
            "RADIO_SELECTED_DME_IDENT_SET",
            "RADIO_SELECTED_DME_IDENT_TOGGLE",
            "EGT",
            "EGT_INC",
            "EGT_DEC",
            "EGT_SET",
            "BAROMETRIC",
            "GYRO_DRIFT_INC",
            "GYRO_DRIFT_DEC",
            "KOHLSMAN_INC",
            "KOHLSMAN_DEC",
            "KOHLSMAN_SET",
            "TRUE_AIRSPEED_CALIBRATE_INC",
            "TRUE_AIRSPEED_CALIBRATE_DEC",
            "TRUE_AIRSPEED_CAL_SET",
            "EGT1_INC",
            "EGT1_DEC",
            "EGT1_SET",
            "EGT2_INC",
            "EGT2_DEC",
            "EGT2_SET",
            "EGT3_INC",
            "EGT3_DEC",
            "EGT3_SET",
            "EGT4_INC",
            "EGT4_DEC",
            "EGT4_SET",
            "ATTITUDE_BARS_POSITION_INC",
            "ATTITUDE_BARS_POSITION_DEC",
            "TOGGLE_ATTITUDE_CAGE",
            "RESET_G_FORCE_INDICATOR",
            "RESET_MAX_RPM_INDICATOR",
            "HEADING_GYRO_SET",
            "GYRO_DRIFT_SET",
            "STROBES_TOGGLE",
            "ALL_LIGHTS_TOGGLE",
            "PANEL_LIGHTS_TOGGLE",
            "LANDING_LIGHTS_TOGGLE",
            "LANDING_LIGHT_UP",
            "LANDING_LIGHT_DOWN",
            "LANDING_LIGHT_LEFT",
            "LANDING_LIGHT_RIGHT",
            "LANDING_LIGHT_HOME",
            "STROBES_ON",
            "STROBES_OFF",
            "STROBES_SET",
            "PANEL_LIGHTS_ON",
            "PANEL_LIGHTS_OFF",
            "PANEL_LIGHTS_SET",
            "LANDING_LIGHTS_ON",
            "LANDING_LIGHTS_OFF",
            "LANDING_LIGHTS_SET",
            "TOGGLE_BEACON_LIGHTS",
            "TOGGLE_TAXI_LIGHTS",
            "TOGGLE_LOGO_LIGHTS",
            "TOGGLE_RECOGNITION_LIGHTS",
            "TOGGLE_WING_LIGHTS",
            "TOGGLE_NAV_LIGHTS",
            "TOGGLE_CABIN_LIGHTS",
            "TOGGLE_VACUUM_FAILURE",
            "TOGGLE_ELECTRICAL_FAILURE",
            "TOGGLE_PITOT_BLOCKAGE",
            "TOGGLE_STATIC_PORT_BLOCKAGE",
            "TOGGLE_HYDRAULIC_FAILURE",
            "TOGGLE_TOTAL_BRAKE_FAILURE",
            "TOGGLE_LEFT_BRAKE_FAILURE",
            "TOGGLE_RIGHT_BRAKE_FAILURE",
            "TOGGLE_ENGINE1_FAILURE",
            "TOGGLE_ENGINE2_FAILURE",
            "TOGGLE_ENGINE3_FAILURE",
            "TOGGLE_ENGINE4_FAILURE",
            "SMOKE_TOGGLE",
            "GEAR_TOGGLE",
            "BRAKES",
            "GEAR_SET",
            "BRAKES_LEFT",
            "BRAKES_RIGHT",
            "PARKING_BRAKES",
            "GEAR_PUMP",
            "PITOT_HEAT_TOGGLE",
            "SMOKE_ON",
            "SMOKE_OFF",
            "SMOKE_SET",
            "PITOT_HEAT_ON",
            "PITOT_HEAT_OFF",
            "PITOT_HEAT_SET",
            "GEAR_UP",
            "GEAR_DOWN",
            "TOGGLE_MASTER_BATTERY",
            "TOGGLE_MASTER_ALTERNATOR",
            "TOGGLE_ELECTRIC_VACUUM_PUMP",
            "TOGGLE_ALTERNATE_STATIC",
            "DECISION_HEIGHT_DEC",
            "DECISION_HEIGHT_INC",
            "TOGGLE_STRUCTURAL_DEICE",
            "TOGGLE_PROPELLER_DEICE",
            "TOGGLE_ALTERNATOR1",
            "TOGGLE_ALTERNATOR2",
            "TOGGLE_ALTERNATOR3",
            "TOGGLE_ALTERNATOR4",
            "TOGGLE_MASTER_BATTERY_ALTERNATOR",
            "AXIS_LEFT_BRAKE_SET",
            "AXIS_RIGHT_BRAKE_SET",
            "TOGGLE_AIRCRAFT_EXIT",
            "TOGGLE_WING_FOLD",
            "SET_WING_FOLD",
            "TOGGLE_TAIL_HOOK_HANDLE",
            "SET_TAIL_HOOK_HANDLE",
            "TOGGLE_WATER_RUDDER",
            "PUSHBACK_SET",
            "TUG_HEADING",
            "TUG_SPEED",
            "TUG_DISABLE",
            "TOGGLE_MASTER_IGNITION_SWITCH",
            "TOGGLE_TAILWHEEL_LOCK",
            "ADD_FUEL_QUANTITY",
            "TOW_PLANE_RELEASE",
            "REQUEST_TOW_PLANE",
            "RELEASE_DROPPABLE_OBJECTS",
            "RETRACT_FLOAT_SWITCH_DEC",
            "RETRACT_FLOAT_SWITCH_INC",
            "TOGGLE_WATER_BALLAST_VALVE",
            "TOGGLE_VARIOMETER_SWITCH",
            "TOGGLE_TURN_INDICATOR_SWITCH",
            "APU_STARTER",
            "APU_OFF_SWITCH",
            "APU_GENERATOR_SWITCH_TOGGLE",
            "APU_GENERATOR_SWITCH_SET",
            "EXTINGUISH_ENGINE_FIRE",
            "HYDRAULIC_SWITCH_TOGGLE",
            "BLEED_AIR_SOURCE_CONTROL_INC",
            "BLEED_AIR_SOURCE_CONTROL_DEC",
            "BLEED_AIR_SOURCE_CONTROL_SET",
            "TURBINE_IGNITION_SWITCH_TOGGLE",
            "CABIN_NO_SMOKING_ALERT_",
            "CABIN_SEATBELTS_ALERT_",
            "ANTISKID_BRAKES_TOGGLE",
            "GPWS_SWITCH_TOGGLE",
            "MANUAL_FUEL_PRESSURE_PUMP",
            "ANNUNCIATOR_SWITCH_TOGGLE",
            "ANNUNCIATOR_SWITCH_ON",
            "ANNUNCIATOR_SWITCH_OFF",
            "STEERING_INC",
            "STEERING_DEC",
            "STEERING_SET",
            "PRESSURIZATION_PRESSURE_ALT_INC",
            "PRESSURIZATION_PRESSURE_ALT_DEC",
            "PRESSURIZATION_CLIMB_RATE_INC",
            "PRESSURIZATION_CLIMB_RATE_DEC",
            "PRESSURIZATION_PRESSURE_DUMP",
            "TAKEOFF_ASSIST_ARM_TOGGLE",
            "TAKEOFF_ASSIST_ARM_SET",
            "TAKEOFF_ASSIST_FIRE",
            "TOGGLE_LAUNCH_BAR_SWITCH",
            "SET_LAUNCHBAR_SWITCH",
            "ROTOR_BRAKE",
            "ROTOR_CLUTCH_SWITCH_TOGGLE",
            "ROTOR_CLUTCH_SWITCH_SET",
            "ROTOR_GOV_SWITCH_TOGGLE",
            "ROTOR_GOV_SWITCH_SET",
            "ROTOR_LATERAL_TRIM_INC",
            "ROTOR_LATERAL_TRIM_DEC",
            "ROTOR_LATERAL_TRIM_SET",
            "SLING_PICKUP_RELEASE",
            "HOIST_SWITCH_EXTEND",
            "HOIST_SWITCH_RETRACT",
            "HOIST_SWITCH_SET",
            "HOIST_DEPLOY_TOGGLE",
            "HOIST_DEPLOY_SET",
            "SLEW_TOGGLE",
            "SLEW_OFF",
            "SLEW_ON",
            "SLEW_SET",
            "SLEW_RESET",
            "SLEW_ALTIT_UP_FAST",
            "SLEW_ALTIT_UP_SLOW",
            "SLEW_ALTIT_FREEZE",
            "SLEW_ALTIT_DN_SLOW",
            "SLEW_ALTIT_DN_FAST",
            "SLEW_ALTIT_PLUS",
            "SLEW_ALTIT_MINUS",
            "SLEW_PITCH_DN_FAST",
            "SLEW_PITCH_DN_SLOW",
            "SLEW_PITCH_FREEZE",
            "SLEW_PITCH_UP_SLOW",
            "SLEW_PITCH_UP_FAST",
            "SLEW_PITCH_PLUS",
            "SLEW_PITCH_MINUS",
            "SLEW_BANK_MINUS",
            "SLEW_AHEAD_PLUS",
            "SLEW_BANK_PLUS",
            "SLEW_LEFT",
            "SLEW_FREEZE",
            "SLEW_RIGHT",
            "SLEW_HEADING_MINUS",
            "SLEW_AHEAD_MINUS",
            "SLEW_HEADING_PLUS",
            "AXIS_SLEW_AHEAD_SET",
            "AXIS_SLEW_SIDEWAYS_SET",
            "AXIS_SLEW_HEADING_SET",
            "AXIS_SLEW_ALT_SET",
            "AXIS_SLEW_BANK_SET",
            "AXIS_SLEW_PITCH_SET",
            "VIEW_MODE",
            "VIEW_WINDOW_TO_FRONT",
            "VIEW_RESET",
            "VIEW_ALWAYS_PAN_UP",
            "VIEW_ALWAYS_PAN_DOWN",
            "NEXT_SUB_VIEW",
            "PREV_SUB_VIEW",
            "VIEW_TRACK_PAN_TOGGLE",
            "VIEW_PREVIOUS_TOGGLE",
            "VIEW_CAMERA_SELECT_STARTING",
            "PANEL_HUD_NEXT",
            "PANEL_HUD_PREVIOUS",
            "ZOOM_IN",
            "ZOOM_OUT",
            "MAP_ZOOM_FINE_IN",
            "PAN_LEFT",
            "PAN_RIGHT",
            "MAP_ZOOM_FINE_OUT",
            "VIEW_FORWARD",
            "VIEW_FORWARD_RIGHT",
            "VIEW_RIGHT",
            "VIEW_REAR_RIGHT",
            "VIEW_REAR",
            "VIEW_REAR_LEFT",
            "VIEW_LEFT",
            "VIEW_FORWARD_LEFT",
            "VIEW_DOWN",
            "ZOOM_MINUS",
            "ZOOM_PLUS",
            "PAN_UP",
            "PAN_DOWN",
            "VIEW_MODE_REV",
            "ZOOM_IN_FINE",
            "ZOOM_OUT_FINE",
            "CLOSE_VIEW",
            "NEW_VIEW",
            "NEXT_VIEW",
            "PREV_VIEW",
            "PAN_LEFT_UP",
            "PAN_LEFT_DOWN",
            "PAN_RIGHT_UP",
            "PAN_RIGHT_DOWN",
            "PAN_TILT_LEFT",
            "PAN_TILT_RIGHT",
            "PAN_RESET",
            "VIEW_FORWARD_UP",
            "VIEW_FORWARD_RIGHT_UP",
            "VIEW_RIGHT_UP",
            "VIEW_REAR_RIGHT_UP",
            "VIEW_REAR_UP",
            "VIEW_REAR_LEFT_UP",
            "VIEW_LEFT_UP",
            "VIEW_FORWARD_LEFT_UP",
            "VIEW_UP",
            "PAN_RESET_COCKPIT",
            "CHASE_VIEW_NEXT",
            "CHASE_VIEW_PREV",
            "CHASE_VIEW_TOGGLE",
            "EYEPOINT_UP",
            "EYEPOINT_DOWN",
            "EYEPOINT_RIGHT",
            "EYEPOINT_LEFT",
            "EYEPOINT_FORWARD",
            "EYEPOINT_BACK",
            "EYEPOINT_RESET",
            "NEW_MAP",
            "VIEW_COCKPIT_FORWARD",
            "VIEW_VIRTUAL_COCKPIT_FORWARD",
            "VIEW_PANEL_ALPHA_SET",
            "VIEW_PANEL_ALPHA_SELECT",
            "VIEW_PANEL_ALPHA_INC",
            "VIEW_PANEL_ALPHA_DEC",
            "VIEW_LINKING_SET",
            "VIEW_LINKING_TOGGLE",
            "VIEW_CHASE_DISTANCE_ADD",
            "VIEW_CHASE_DISTANCE_SUB",
            "PAUSE_TOGGLE",
            "PAUSE_ON",
            "PAUSE_OFF",
            "PAUSE_SET",
            "DEMO_STOP",
            "SELECT_1",
            "SELECT_2",
            "SELECT_3",
            "SELECT_4",
            "MINUS",
            "PLUS",
            "ZOOM_1X",
            "SOUND_TOGGLE",
            "SIM_RATE",
            "JOYSTICK_CALIBRATE",
            "SITUATION_SAVE",
            "SITUATION_RESET",
            "SOUND_SET",
            "EXIT",
            "ABORT",
            "READOUTS_SLEW",
            "READOUTS_FLIGHT",
            "MINUS_SHIFT",
            "PLUS_SHIFT",
            "SIM_RATE_INCR",
            "SIM_RATE_DECR",
            "KNEEBOARD",
            "PANEL_1",
            "PANEL_2",
            "PANEL_3",
            "PANEL_4",
            "PANEL_5",
            "PANEL_6",
            "PANEL_7",
            "PANEL_8",
            "PANEL_9",
            "SOUND_ON",
            "SOUND_OFF",
            "INVOKE_HELP",
            "TOGGLE_AIRCRAFT_LABELS",
            "FLIGHT_MAP",
            "RELOAD_PANELS",
            "PANEL_ID_TOGGLE",
            "PANEL_ID_OPEN",
            "PANEL_ID_CLOSE",
            "CONTROL_RELOAD_USER_AIRCRAFT",
            "SIM_RESET",
            "VIRTUAL_COPILOT_TOGGLE",
            "VIRTUAL_COPILOT_SET",
            "VIRTUAL_COPILOT_ACTION",
            "REFRESH_SCENERY",
            "CLOCK_HOURS_DEC",
            "CLOCK_HOURS_INC",
            "CLOCK_MINUTES_DEC",
            "CLOCK_MINUTES_INC",
            "CLOCK_SECONDS_ZERO",
            "CLOCK_HOURS_SET",
            "CLOCK_MINUTES_SET",
            "ZULU_HOURS_SET",
            "ZULU_MINUTES_SET",
            "ZULU_DAY_SET",
            "ZULU_YEAR_SET",
            "GAUGE_KEYSTROKE",
            "SIMUI_WINDOW_HIDESHOW",
            "WINDOW_TITLES_TOGGLE",
            "AXIS_PAN_PITCH",
            "AXIS_PAN_HEADING",
            "AXIS_PAN_TILT",
            "AXIS_INDICATOR_CYCLE",
            "MAP_ORIENTATION_CYCLE",
            "TOGGLE_JETWAY",
            "VIDEO_RECORD_TOGGLE",
            "TOGGLE_AIRPORT_NAME_DISPLAY",
            "CAPTURE_SCREENSHOT",
            "MOUSE_LOOK_TOGGLE",
            "YAXIS_INVERT_TOGGLE",
            "AUTOCOORD_TOGGLE",
            "FREEZE_LATITUDE_LONGITUDE_TOGGLE",
            "FREEZE_LATITUDE_LONGITUDE_SET",
            "FREEZE_ALTITUDE_TOGGLE",
            "FREEZE_ALTITUDE_SET",
            "FREEZE_ATTITUDE_TOGGLE",
            "FREEZE_ATTITUDE_SET",
            "POINT_OF_INTEREST_TOGGLE_POINTER",
            "POINT_OF_INTEREST_CYCLE_PREVIOUS",
            "POINT_OF_INTEREST_CYCLE_NEXT",
            "ATC",
            "ATC_MENU_1",
            "ATC_MENU_2",
            "ATC_MENU_3",
            "ATC_MENU_4",
            "ATC_MENU_5",
            "ATC_MENU_6",
            "ATC_MENU_7",
            "ATC_MENU_8",
            "ATC_MENU_9",
            "ATC_MENU_0",
            "MULTIPLAYER_TRANSFER_CONTROL",
            "MULTIPLAYER_PLAYER_CYCLE",
            "MULTIPLAYER_PLAYER_FOLLOW",
            "MULTIPLAYER_CHAT",
            "MULTIPLAYER_ACTIVATE_CHAT",
            "MULTIPLAYER_VOICE_CAPTURE_START",
            "MULTIPLAYER_VOICE_CAPTURE_STOP",
            "MULTIPLAYER_BROADCAST_VOICE_",
            "TOGGLE_RACERESULTS_WINDOW",
            "COM_RADIO_SET_HZ",
            "COM2_RADIO_SET_HZ",
            "NAV1_RADIO_SET_HZ",
            "NAV2_RADIO_SET_HZ",
            "COM_STBY_RADIO_SET_HZ",
            "COM2_STBY_RADIO_SET_HZ",
            "NAV1_STBY_SET_HZ",
            "NAV2_STBY_SET_HZ"
        };
        
        /// <summary>
        /// Returns an event name for a given event name id.
        /// </summary>
        /// <param name="eventNameId">An <see cref="FsEventNameId"/> representing a MSFS event.</param>
        public static string GetFsEventName(FsEventNameId eventNameId)
        {
            return _fsEventName[(int)eventNameId];
        }
    }
}
