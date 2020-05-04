using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Transport
{
    interface ITransportModel
    {
        int Speed { get; set; }
        int RequiredWidth { get; set; }
        int RequiredHeight { get; set; }
        int RequiredWeight { get; set; }
        TransportType Type { get; set; }
        bool IsBusy { get; set; }
    }
}
