using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebAbiHomework5.Entities;
using WebAbiHomework5.Repositories.Abstracts;

namespace WebAbiHomework5.Repositories.Concretes;

public class ProductRepository:IProductRepository
{
    private readonly EcommerceDBContext _context;
    public ProductRepository(EcommerceDBContext context)
    {
        _context = context;
    }
    public async Task Add(Product entity)
    {
        await _context.Products.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public void Delete(Product entity)
    {
        _context.Products.Remove(entity);
        _context.SaveChanges();
    }

    public async Task<Product> Get(Expression<Func<Product, bool>> predicate)
    {
        var product = await _context.Products.FirstOrDefaultAsync(predicate);
        return product;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await Task.Run(() =>
        {
            return _context.Products;
        });
    }

    public async Task Update(Product entity)
    {
        await Task.Run(() =>
        {
            _context.Products.Update(entity);
        });
        await _context.SaveChangesAsync();
    }
}
