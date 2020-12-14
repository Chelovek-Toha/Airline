﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Airline.Implementation.Airline
{
    public interface IAirline<SpaceVehicle>
    {
        /// <summary>
        /// Personal ID of a company
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Name of company
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Total number of vehicles
        /// </summary>
        int VehicleCount { get; }

        /// <summary>
        /// Method to get maximum number of passengers
        /// </summary>
        int GetSeatingCapacity();

        /// <summary>
        /// Method to get maximum number of passengers
        /// </summary>
        double GetLiftingCapacity();

        /// <summary>
        /// Method to sort vehicle list by maximum range of flight in ascending order
        /// </summary>
        void AscendingSortByFlightRange();

        /// <summary>
        /// Method to get space vehicle
        /// </summary>
        /// <param name="vehiclePosition"></param>
        /// <returns>SpaceVehicle</returns>
        SpaceVehicle GetVehicle(int vehiclePosition);

        /// <summary>
        /// Method to seatch for a specific vehicle by name
        /// </summary>
        /// <param name="nameToSearch"></param>
        /// <returns>List<SpaceVehicle></returns>
        List<SpaceVehicle> SearchByName(string nameToSearch);

        List<SpaceVehicle> SearchByFuelConsumption(decimal minimumFuelConsumption, decimal MaximumFuelConsumption);
    }
}
