using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Order;

namespace ServiceLayer.Services.OrderService
{
    public interface IOrderService
    {
        void ValidateModel(OrderModel orderModel);
    }
}
