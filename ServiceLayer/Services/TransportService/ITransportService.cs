using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Transport;

namespace ServiceLayer.Services.TransportService
{
    public interface ITransportService
    {
        void ValidateModel(TransportModel transportModel);
    }
}
