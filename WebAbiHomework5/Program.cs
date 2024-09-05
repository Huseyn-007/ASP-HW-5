using Microsoft.EntityFrameworkCore;
using WebAbiHomework5.Entities;
using WebAbiHomework5.Repositories.Abstracts;
using WebAbiHomework5.Services.Abstracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerRepository>();
builder.Services.AddScoped<IProductRepository>();
builder.Services.AddScoped<IOrderRepository>();
builder.Services.AddScoped<IOrderService>();
builder.Services.AddScoped<ICustomerService>();
builder.Services.AddScoped<IProductService>();

var conn = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<EcommerceDBContext>(opt =>
{
    opt.UseSqlServer(conn);
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
