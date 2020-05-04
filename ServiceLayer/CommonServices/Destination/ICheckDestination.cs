using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CommonServices.Destination
{
    public interface ICheckDestination
    {
        void ValidateModel<TDestinationModel>(TDestinationModel destinationModel);
    }
}
