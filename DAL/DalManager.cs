using Dal.Api;
using Dal.DalImplement;
using Dal.DalImplementations;
using Dal.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalManager
    {
        public UserRepo user { get; }
        public CarRepo car { get; }
        public AddressRepo address { get; }
        public CreditDetailRepo creditDetail { get; }
        public ScheduleRepo schedule { get; }
        public TypeCarRepo typeCar { get; }
        public CarsToUsersRepo carsToUsers { get; }

        public DalManager()
        {
            // באן הגדרנו אוסף של מחלקות שרות
            ServiceCollection services = new();

            // מוסיפים לאוסף אוביקטים
            services.AddDbContext<MagiCarContext>();
            services.AddScoped<IRepository<User>, UserRepo>();
            services.AddScoped<IRepository<Car>, CarRepo>();
            services.AddScoped<IRepository<Address>, AddressRepo>();
            services.AddScoped<IRepository<CreditDetail>, CreditDetailRepo>();
            services.AddScoped<IRepository<Schedule>, ScheduleRepo>();
            services.AddScoped<IRepository<TypeCar>, TypeCarRepo>();
            services.AddScoped<IRepository<CarsToUser>, CarsToUsersRepo>();
            
            // הגדרת מנהל למחלקות השרות שנקרא פרווידר
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            user = serviceProvider.GetRequiredService<UserRepo>();
            car = serviceProvider.GetRequiredService<CarRepo>();
            address = serviceProvider.GetRequiredService<AddressRepo>();
            creditDetail = serviceProvider.GetRequiredService<CreditDetailRepo>();
            schedule = serviceProvider.GetRequiredService<ScheduleRepo>();
            typeCar = serviceProvider.GetRequiredService<TypeCarRepo>();
            carsToUsers = serviceProvider.GetRequiredService<CarsToUsersRepo>();
        }
    }
}
