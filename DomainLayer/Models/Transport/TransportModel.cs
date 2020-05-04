using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Transport
{
    public class TransportModel
    {
        public int TransportID { get; set; } 
        public int Speed { get; set; }
        public int RequiredWidth { get; set; }
        public int RequiredHeight { get; set; }
        public int RequiredWeight { get; set; }
        public TransportType Type { get; set; }
        public bool IsBusy { get; set; }
    }
}
