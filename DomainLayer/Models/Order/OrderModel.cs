using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Destination;
using DomainLayer.Models.Good;
using DomainLayer.Models.Transport;

namespace DomainLayer.Models.Order
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public GoodModel Good { get; set; }
        public DestinationModel Destination { get; set; }
        public TransportModel Transport { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
