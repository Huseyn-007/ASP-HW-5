using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebAbiHomework5.Entities;
using WebAbiHomework5.Repositories.Abstracts;

namespace WebAbiHomework5.Repositories.Concretes;

public class OrderRepository:IOrderRepository
{
    private readonly EcommerceDBContext _context;
    public OrderRepository(EcommerceDBContext context)
    {
        _context = context;
    }
    public async Task Add(Order entity)
    {
        await _context.Orders.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public void Delete(Order entity)
    {
        _context.Orders.Remove(entity);
        _context.SaveChanges();
    }

    public  async Task<Order> Get(Expression<Func<Order, bool>> predicate)
    {
       var order = await _context.Orders.FirstOrDefaultAsync(predicate);
        return order;
        
    }

    public async Task<IEnumerable<Order>> GetAll()
    {
        return await Task.Run(() =>
        {
            return _context.Orders;
        });
    }

    public async Task Update(Order entity)
    {
        await Task.Run(() =>
        {
            _context.Orders.Update(entity);
        });
        await _context.SaveChangesAsync();
    }
}
