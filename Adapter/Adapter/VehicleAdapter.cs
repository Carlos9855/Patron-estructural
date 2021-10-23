using System;
using System.Collections.Generic;
namespace Adapter
{
    public class VehicleAdapter: StockSystem, ITarget
    {
        public List<string> GetVehiclesList()
        {
            List<string> vehicleList = new List<string>();
            string[][] vehicles = GetVehicles();
            foreach (string[] vehicle in vehicles)
            {
                vehicleList.Add(vehicle[0]);
                vehicleList.Add(",");
                vehicleList.Add(vehicle[1]);
                vehicleList.Add(",");
                vehicleList.Add(vehicle[2]);
                vehicleList.Add("\n");
            }

            return vehicleList;
        }

    }
}
