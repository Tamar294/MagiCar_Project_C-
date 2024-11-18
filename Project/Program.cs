using Bl.Api;
using Bl.Implement;
using Dal;
using Dal.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add controllers
builder.Services.AddControllers();

// Get connection string and register DbContext
DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("MagiCarDB");
builder.Services.AddDbContext<MagiCarContext>((options) => options.UseSqlServer(connString));

// Register DalManager as a Singleton
builder.Services.AddSingleton<DalManager>(provider =>
{
    return new DalManager(connString); // יוצר את DalManager עם חיבור ל-DB
});

// Register BL services (BL depends on DAL internally)
builder.Services.AddScoped<IAddressService, AddressService>();

var app = builder.Build();

// Map default route and controllers
app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();
