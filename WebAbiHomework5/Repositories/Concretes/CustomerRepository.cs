using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebAbiHomework5.Entities;
using WebAbiHomework5.Repositories.Abstracts;

namespace WebAbiHomework5.Repositories.Concretes;

public class CustomerRepository : ICustomerRepository
{
    private readonly EcommerceDBContext _context;
    public CustomerRepository(EcommerceDBContext context)
    {
        _context = context;
    }
    public async Task Add(Customer entity)
    {
        await _context.Customers.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public void Delete(Customer entity)
    {
        _context.Customers.Remove(entity);
        _context.SaveChanges();
    }

    public  async Task<Customer> Get(Expression<Func<Customer, bool>> predicate)
    {
        var customer = await _context.Customers.FirstOrDefaultAsync(predicate);
        return customer;
    }

    public async Task<IEnumerable<Customer>> GetAll()
    {
        return await Task.Run(() =>
        {
            return _context.Customers;
        });
    }

    public async Task Update(Customer entity)
    {
        await Task.Run(() =>
        {
            _context.Customers.Update(entity);
        });
        await _context.SaveChangesAsync();
    }
}
