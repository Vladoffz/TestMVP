using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Destination;
using ServiceLayer.Repository;
using ServiceLayer.Services.GoodService;

namespace ServiceLayer.Services.DestinationService
{
    class DestinationService : IDestinationRepository, IDestinationService 
    {
        private IDestinationService _destinationService;
        private IDestinationRepository _destinationRepository;

        public DestinationService(IDestinationService destinationService, IDestinationRepository destinationRepository)
        {
            _destinationService = destinationService;
            _destinationRepository = destinationRepository;
        }

        public void Add(DestinationModel destinationModel)
        {
            throw new NotImplementedException();
        }

        public void Update(DestinationModel destinationModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(DestinationModel destinationModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DestinationModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public DestinationModel Get(int DestinationID)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(DestinationModel destinationModel)
        {
            throw new NotImplementedException();
        }
    }
}
