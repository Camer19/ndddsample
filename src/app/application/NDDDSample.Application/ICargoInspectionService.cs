﻿namespace NDDDSample.Application
{
    using Domain.Model.Cargos;

    /// <summary>
    /// Cargo inspection service.
    /// </summary>
    public interface ICargoInspectionService
    {
        /// <summary>
        /// Inspect cargo and send relevant notifications to interested parties,
        /// for example if a cargo has been misdirected, or unloaded
        ///  at the final destination.
        /// </summary>
        /// <param name="trackingId">cargo tracking id</param>
        void inspectCargo(TrackingId trackingId);
    }
}