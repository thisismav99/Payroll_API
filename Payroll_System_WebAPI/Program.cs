using Microsoft.EntityFrameworkCore;
using Payroll_System_BLL.Interfaces;
using Payroll_System_BLL.Services;
using Payroll_System_DAL;
using Payroll_System_DAL.Repositories;
using Payroll_System_DAL.Entities;
using Payroll_System_DAL.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllers();
builder.Services.AddDbContext<PayrollSystemDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("PayrollSystemDB"))
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IPayrollRepository<>), typeof(PayrollRepository<>));
builder.Services.AddScoped(typeof(IPayrollUnitOfWork<>), typeof(PayrollUnitOfWork<>));
builder.Services.AddScoped<IEmployee, EmployeeService>();
#endregion

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
