using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DomainLayer.Models.Transport;

namespace ServiceLayer.Services.TransportService
{
    public interface ITransportRepository
    {
        void Add(TransportModel transportModel);
        void Update(TransportModel transportModel);
        void Delete(TransportModel transportModel);
        IEnumerable<TransportModel> GetAll();
        TransportModel Get(int TransportID);
    }
}
