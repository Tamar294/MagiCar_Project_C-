using Dal.Api;
using Dal.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Dal.Implement;
//using Bl.Api;
//using Bl.Implement;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("MagiCarDB");
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
