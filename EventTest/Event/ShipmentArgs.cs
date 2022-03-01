using System;
using System.Collections.Generic;
using System.Text;

namespace EventTest.Event
{
    public class ShipmentArgs : EventArgs
    {
        public string TrackingNumber { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}