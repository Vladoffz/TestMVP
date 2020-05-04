using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Destination;

namespace ServiceLayer.Services.DestinationService
{
    public interface IDestinationService
    {
        void ValidateModel(DestinationModel destinationModel);
    }
}
