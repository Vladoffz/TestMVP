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
    interface IOrderModel
    {
        GoodModel Good { get; set; }
        DestinationModel Destination { get; set; }
        TransportModel Transport { get; set; }
        string Name { get; set; }
        DateTime Date { get; set; }
    }
}
