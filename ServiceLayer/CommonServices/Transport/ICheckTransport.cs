using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CommonServices
{
    interface ICheckTransport
    {
        void ValidateModel<TTransportModel>(TTransportModel transportModel);
    }
}
