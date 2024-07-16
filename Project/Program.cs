using Bl;
using Bl.Api;
using Bl.Implement;
using Dal.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();

builder.Services.AddDbContext<MagiCarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MagiCarDB"))
);

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("CORSPolicy", builder =>
//    {
//        builder.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
//    });
//});

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("MagiCarDB");
builder.Services.AddDbContext<MagiCarContext>((options) => options.UseSqlServer(connString));

builder.Services.AddScoped(b => new BlManager(connString));

//builder.Services.AddScoped<IAddressService, AddressService>();


var app = builder.Build();
//app.UseCors("CORSPolicy");
app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();




