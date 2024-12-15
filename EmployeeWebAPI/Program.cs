using EmployeeWebAPI;
using EmployeeWebAPI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(Options =>
         Options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
             .AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
