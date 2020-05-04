using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CommonServices.Order
{
    public interface ICheckOrder
    {
        void ValidateModel<TOrderModel>(TOrderModel orderModel);
    }
}
