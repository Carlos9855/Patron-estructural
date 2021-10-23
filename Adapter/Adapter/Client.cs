using System;
using System.Collections.Generic;

namespace Adapter
{
    public class Client
    {
        private readonly ITarget _vehicleSource;

        public Client(ITarget vehicleSource)
        {
            this._vehicleSource = vehicleSource;
        }

        public List<string> ShowVehiclesList()
        {
            List<string> vehicle = _vehicleSource.GetVehiclesList();
            return vehicle;

            

        }
    }
}
