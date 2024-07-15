using Dal.Api;
using Dal.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Dal.Implement;
using System.Diagnostics;
//using Bl.Api;
//using Bl.Implement;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
Console.WriteLine("hi");
Debug.WriteLine("hi debug");
Console.WriteLine(configuration["ConnectionStrings:MagiCarDB"]);
Debug.WriteLine(configuration["ConnectionStrings:MagiCarDB"]);

builder.Services.AddControllers();



builder.Services.AddDbContext<MagiCarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MagiCarDB"))
);
DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("MagiCarDB");
Console.WriteLine("Final Connection String: " + connString);
Debug.WriteLine("Final Connection String: " + connString);
builder.Services.AddDbContext<MagiCarContext>((options) => options.UseSqlServer(connString));

builder.Services.AddScoped<IAddressRepo, AddressRepo>();
//builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<ICarRepo, CarRepo>();
builder.Services.AddScoped<ICarRentalRepo, CarRentalRepo>();
builder.Services.AddScoped<IPayDetailRepo, PayDetailRepo>();
builder.Services.AddScoped<IRentalHistoryRepo, RentalHistoryRepo>();
builder.Services.AddScoped<ITypeCarRepo, TypeCarRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
