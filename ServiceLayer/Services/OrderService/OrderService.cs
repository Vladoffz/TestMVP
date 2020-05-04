using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Order;
using ServiceLayer.Repository;
using ServiceLayer.Services.DestinationService;

namespace ServiceLayer.Services.OrderService
{
    class OrderService : IOrderService, IOrderRepository
    {
        private IOrderService _orderService;
        private IOrderRepository _orderRepository;

        public OrderService(IOrderService orderService, IOrderRepository orderRepository)
        {
            _orderService = orderService;
            _orderRepository = orderRepository;
        }

        public void ValidateModel(OrderModel orderModel)
        {
            throw new NotImplementedException();
        }

        public void Add(OrderModel orderModel)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderModel orderModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrderModel orderModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderModel Get(int OrderID)
        {
            throw new NotImplementedException();
        }
    }
}
