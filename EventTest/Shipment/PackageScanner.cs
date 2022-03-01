using EventTest.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventTest.Shipment
{
    public class PackageScanner
    {
        public event EventHandler<ShipmentArgs> OnNewShipment;

        public void Scan(string TrackingNumber)
        {
            ShipmentArgs e = new ShipmentArgs();
            e.TimeCreated = DateTime.Now;
            e.TrackingNumber = TrackingNumber;
            CreateNewShipment(e);
        }

        protected virtual void CreateNewShipment(ShipmentArgs e)
        {
            OnNewShipment?.Invoke(this, e);
        }
    }
}