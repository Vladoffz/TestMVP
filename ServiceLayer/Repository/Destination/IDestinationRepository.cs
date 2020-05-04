using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Destination;

namespace ServiceLayer.Repository
{
    interface IDestinationRepository
    {
        void Add(DestinationModel destinationModel);
        void Update(DestinationModel destinationModel);
        void Delete(DestinationModel destinationModel);
        IEnumerable<DestinationModel> GetAll();
        DestinationModel Get(int DestinationID);
    }
}
