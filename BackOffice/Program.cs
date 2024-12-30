using BackOffice.Masters.IRepository;
using BackOffice.Masters.IService;
using BackOffice.Masters.Repository;
using BackOffice.Masters.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ICompanyDetails,CompanyDetailsRepository>();
builder.Services.AddSingleton<ICompanyDetailsService, CompanyDetailsService>();
builder.Services.AddSingleton<IRoles, RolesRepository>();
builder.Services.AddSingleton<IRolesService, RolesService>();
builder.Services.AddSingleton<IServicesService, ServicesService>();
builder.Services.AddSingleton<IServices, ServicesRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
