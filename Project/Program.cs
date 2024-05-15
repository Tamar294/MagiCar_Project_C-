using Dal.Api;
using Dal.DalImplement;
using Dal.Models;
using Dal.DalImplementations;
using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("MagiCarDB");
builder.Services.AddDbContext<MagiCarContext>((options) => options.UseSqlServer(connString));

builder.Services.AddScoped<IAddressRepo, AddressRepo>();
builder.Services.AddScoped<ICarRepo, CarRepo>();
builder.Services.AddScoped<ICarsToUsersRepo, CarsToUsersRepo>();
builder.Services.AddScoped<ICreditDetailRepo, CreditDetailRepo>();
builder.Services.AddScoped<IScheduleRepo, ScheduleRepo>();
builder.Services.AddScoped<ITypeCarRepo, TypeCarRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
