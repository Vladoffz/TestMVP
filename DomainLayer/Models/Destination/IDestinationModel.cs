using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Destination
{
    interface IDestinationModel
    {
        string StreetName { get; set; }
        int Distance { get; set; }
    }
}
