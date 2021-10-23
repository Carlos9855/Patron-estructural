using Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestProjectStockSystem
{
    [TestClass]
    public class TestAdapter
    {
        [TestMethod]
        public void TestMethodViewStockSystem()
        {
            ITarget Itarget = new VehicleAdapter();
            Client client = new Client(Itarget);
            string[][] vehicles = new string[4][];
            vehicles[0] = new string[] { "Model: Suzuki Baleno", "Year: 2022", "Color: White", "Price: 12.000 $" };
            vehicles[1] = new string[] { "Model: Trek x-caliber 7", "Year: 2017", "Color: Black/Blue", "Price: 1.100 $" };
            vehicles[2] = new string[] { "Model: Mercedes Benz ML-3220", "Year: 1999", "Color: Gray", "Price: 5.000 $" };
            vehicles[3] = new string[] { "Model: Orbea Rallon M-LTD", "Year: 2021", "Color: Green", "Price: 2.000 $" };
            CollectionAssert.Equals(vehicles, client.ShowVehiclesList());
        }
    }
}
