using API.Scheduler.IServices;
using API.Scheduler.Services;
using Data;
using Data.Queries;
using Logic.IContext;
using Logic.ILogic;
using Logic.Logic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUserService, UserService>();

builder.Services.AddSingleton<IUserLogic, UserLogic>();

builder.Services.AddSingleton<ITransactionQuery, TransactionQuery>();
builder.Services.AddSingleton(typeof(IEntityQuery<>), typeof(EntityQuery<>));

builder.Services.AddDbContext<SchedulerContext>(
        options => options.UseSqlServer("name=ConnectionStrings:ServiceContext").LogTo(Console.WriteLine),
        ServiceLifetime.Singleton);

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