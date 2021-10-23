using System;
using System.Collections.Generic;

namespace Adapter
{
    static class Program
    {
        static void Main(string[] args)
        {
            ITarget Itarget = new VehicleAdapter();
            Client client = new Client(Itarget);
            List<string> vehicle=client.ShowVehiclesList();
            Console.WriteLine("*** Vehicles List ***");
            foreach (var item in vehicle)
            {
                Console.Write(item);
            }
            Console.ReadKey();

        }
    }
}
