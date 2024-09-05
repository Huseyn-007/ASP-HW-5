using System.Linq.Expressions;
using WebAbiHomework5.Entities;
using WebAbiHomework5.Repositories.Abstracts;

namespace WebAbiHomework5.Services.Concretes;

public class ProductService:IProductRepository
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task Add(Product entity)
    {
        await _productRepository.Add(entity);
    }

    public async void Delete(Product entity)
    {
        _productRepository.Delete(entity);
    }

    public async Task<Product> Get(Expression<Func<Product, bool>> predicate)
    {
        var item = await _productRepository.Get(predicate);
        return item;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _productRepository.GetAll();
    }

    public async Task Update(Product entity)
    {
        await _productRepository.Update(entity);
    }
}
