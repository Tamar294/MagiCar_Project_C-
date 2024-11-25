﻿//using Dal.Api;
//using Dal.Implement;
//using Dal.Models;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dal
//{
//    public class DalManager
//    {
//        public AddressRepo addressRepo;
//        //public CarRepo carRepo;
//        //public CarRentalRepo carRentalRepo;
//        //public PayDetailRepo payDetailRepo;
//        //public RentalHistoryRepo rentalHistoryRepo;
//        //public TypeCarRepo typeCarRepo;
//        //public UserRepo userRepo;

//        //public UserRepo user { get; }
//        //public CarRepo car { get; }
//        public AddressRepo address { get; }
//        //public PayDetailRepo payDetail { get; }
//        //public CarRentalRepo carRental { get; }
//        //public TypeCarRepo typeCar { get; }
//        //public RentalHistoryRepo rentalHistory { get; }

//        public DalManager(string connString)
//        {
//            // באן הגדרנו אוסף של מחלקות שרות
//            ServiceCollection services = new();

//            // מוסיפים לאוסף אוביקטים
//            services.AddDbContext<MagiCarContext>();
//            //services.AddScoped<IRepository<User>, UserRepo>();
//            //services.AddScoped<IRepository<Car>, CarRepo>();
//            services.AddScoped<IRepository<Address>, AddressRepo>();
//            //services.AddScoped<IRepository<PayDetail>, PayDetailRepo>();
//            //services.AddScoped<IRepository<CarsRental>, CarRentalRepo>();
//            //services.AddScoped<IRepository<TypeCar>, TypeCarRepo>();
//            //services.AddScoped<IRepository<RentalHistory>, RentalHistoryRepo>();

//            // הגדרת מנהל למחלקות השרות שנקרא פרווידר
//            ServiceProvider serviceProvider = services.BuildServiceProvider();

//            //user = serviceProvider.GetRequiredService<UserRepo>();
//            //car = serviceProvider.GetRequiredService<CarRepo>();
//            address = serviceProvider.GetRequiredService<AddressRepo>();
//            //payDetail = serviceProvider.GetRequiredService<PayDetailRepo>();
//            //carRental = serviceProvider.GetRequiredService<CarRentalRepo>();
//            //typeCar = serviceProvider.GetRequiredService<TypeCarRepo>();
//            //rentalHistory = serviceProvider.GetRequiredService<RentalHistoryRepo>();

//        }
//    }
//}


//using Dal.Api;
//using Dal.Implement;
//using Dal.Models;
//using Microsoft.Extensions.DependencyInjection;

//namespace Dal
//{
//    public class DalManager
//    {
//        public AddressRepo address;

//        public DalManager(string connString)
//        {
//            ServiceCollection services = new();

//            // Register DbContext and other repositories
//            services.AddDbContext<MagiCarContext>();
//            services.AddScoped<IRepository<Address>, AddressRepo>(); // Ensure this line is present

//            ServiceProvider serviceProvider = services.BuildServiceProvider();
//            address = serviceProvider.GetRequiredService<AddressRepo>();
//        }
//    }
//}




using Dal.Api;
using Dal.Implement;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dal
{
    public class DalManager
    {
        public IAddressRepo AddressRepo { get; private set; }

        public DalManager(string connString)
        {
            ServiceCollection services = new();

            // Register DbContext with connection string
            services.AddDbContext<MagiCarContext>(options =>
                options.UseSqlServer(connString)); // התאמת `UseSqlServer` או המתודה המתאימה

            // Register repositories
            services.AddScoped<IAddressRepo, AddressRepo>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            AddressRepo = serviceProvider.GetRequiredService<IAddressRepo>();
        }
    }
}

