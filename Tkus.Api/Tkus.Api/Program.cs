using Microsoft.EntityFrameworkCore;
using Tkus.Core.Interfaces;
using Tkus.Infrastructure.Data;
using Tkus.Infrastructure.Repositoryes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Conxicon a la base de datos
builder.Services.AddDbContext<TkosContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Tkos"));
});
//Injeccion de dependendecias
builder.Services.AddTransient<IFormRepository, FormRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<ISupplierRepository, SupplierRepository>();
builder.Services.AddTransient<ITypeformRepository, TypeformRepository>();
builder.Services.AddTransient<ICityRepository, CityRepository>();

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
