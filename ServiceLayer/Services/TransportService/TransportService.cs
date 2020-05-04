using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Transport;

namespace ServiceLayer.Services.TransportService
{
    public class TransportService : ITransportService, ITransportRepository
    {
        private ITransportService _transportService;
        private ITransportRepository _transportRepository;

        public TransportService(ITransportService transportService, ITransportRepository transportRepository)
        {
            _transportService = transportService;
            _transportRepository = transportRepository;
        }

        public void ValidateModel(TransportModel transportModel)
        {
            throw new NotImplementedException();
        }

        public void Add(TransportModel transportModel)
        {
            throw new NotImplementedException();
        }

        public void Update(TransportModel transportModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(TransportModel transportModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransportModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public TransportModel Get(int TransportID)
        {
            throw new NotImplementedException();
        }
    }
}
