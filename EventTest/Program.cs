using EventTest.Shipment;
using System;

namespace EventTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ShipmentManager shipmentManager = new ShipmentManager();
            shipmentManager.AddLabelMaker(new LabelMaker());
            shipmentManager.AddLabelMaker(new LabelMaker());
            shipmentManager.AddLabelMaker(new LabelMaker());
            shipmentManager.AddPackageScanner(new PackageScanner());
            shipmentManager.CreatePackage("abcd1234");
            shipmentManager.CreatePackage("1234abcd");
        }
    }
}