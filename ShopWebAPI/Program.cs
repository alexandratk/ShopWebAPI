using System.Reflection;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ShopWebAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddComponents();

builder.Services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(Application.AssemblyInfo).GetTypeInfo().Assembly));
builder.Services.AddAutoMapper(typeof(Application.AssemblyInfo).GetTypeInfo().Assembly);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ShopDbContext>(options =>
    options.UseSqlServer(connectionString));

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