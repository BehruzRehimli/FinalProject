using Microsoft.EntityFrameworkCore;
using Yolcu360.Core.Repositories;
using Yolcu360.Data;
using Yolcu360.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Yolcu360DbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBrandRepository, BrandRepository>();

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
