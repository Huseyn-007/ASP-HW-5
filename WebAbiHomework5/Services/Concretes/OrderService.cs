using System.Linq.Expressions;
using WebAbiHomework5.Entities;
using WebAbiHomework5.Repositories.Abstracts;
using WebAbiHomework5.Services.Abstracts;

namespace WebAbiHomework5.Services.Concretes
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task Add(Order entity)
        {
            await _orderRepository.Add(entity);
        }

        public async void Delete(Order entity)
        {
            _orderRepository.Delete(entity);
        }

        public async Task<Order> Get(Expression<Func<Order, bool>> predicate)
        {
            var item = await _orderRepository.Get(predicate);
            return item;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _orderRepository.GetAll();
        }

        public async Task Update(Order entity)
        {
            await _orderRepository.Update(entity);
        }
    }
}
