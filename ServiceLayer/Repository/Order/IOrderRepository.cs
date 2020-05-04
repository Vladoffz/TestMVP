using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Order;

namespace ServiceLayer.Repository
{
    public interface IOrderRepository
    {
        void Add(OrderModel orderModel);
        void Update(OrderModel orderModel);
        void Delete(OrderModel orderModel);
        IEnumerable<OrderModel> GetAll();
        OrderModel Get(int OrderID);
    }
}
