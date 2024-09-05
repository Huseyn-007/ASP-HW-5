using System.Linq.Expressions;
using WebAbiHomework5.Entities;
using WebAbiHomework5.Repositories.Abstracts;
using WebAbiHomework5.Services.Abstracts;

namespace WebAbiHomework5.Services.Concretes;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task Add(Customer entity)
    {
        await _customerRepository.Add(entity);
    }

    public async void Delete(Customer entity)
    {
         _customerRepository.Delete(entity);
    }

    public async Task<Customer> Get(Expression<Func<Customer, bool>> predicate)
    {
        var item = await _customerRepository.Get(predicate);
        return item;
    }

    public async Task<IEnumerable<Customer>> GetAll()
    {
        return await _customerRepository.GetAll();
    }

    public async Task Update(Customer entity)
    {
        await _customerRepository.Update(entity);
    }
}
