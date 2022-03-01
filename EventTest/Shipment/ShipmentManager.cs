using EventTest.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventTest.Shipment
{
    public class ShipmentManager
    {
        private List<LabelMaker> LabelMakers;

        private List<PackageScanner> PackageScanners;

        public ShipmentManager()
        {
            this.LabelMakers = new List<LabelMaker>();
            this.PackageScanners = new List<PackageScanner>();
        }

        public void AddLabelMaker(LabelMaker l)
        {
            this.LabelMakers.Add(l);
        }

        public void AddPackageScanner(PackageScanner p)
        {
            p.OnNewShipment += PrintLabel;
            this.PackageScanners.Add(p);
        }

        public void PrintLabel(object s, ShipmentArgs e)
        {
            string labelMessage = String.Format("Tracking Number {0} created at {1}", e.TrackingNumber, e.TimeCreated);
            foreach (LabelMaker l in LabelMakers)
            {
                l.PrintLabel(labelMessage);
            }
        }

        public void CreatePackage(string TrackingNumber)
        {
            foreach (PackageScanner p in PackageScanners)
            {
                p.Scan(TrackingNumber);
            }
        }
    }
}