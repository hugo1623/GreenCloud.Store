using GreenCloud.Store.Application.Implementations;
using GreenCloud.Store.Application.Interfaces;
using GreenCloud.Store.Repository;
using GreenCloud.Store.Repository.Implementations;
using GreenCloud.Store.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StoreContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
builder.Services.AddScoped<IProductsApplication, ProductsApplication>();//siempre que llames a esta interfaz voy a querer que loimplemente productAplication
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
