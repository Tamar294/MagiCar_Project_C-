using Dal.DalApi;
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


builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<ICarRepo, CarRepo>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
