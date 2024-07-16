//using Bl.Api;
//using Bl.Implement;
//using Dal;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bl
//{
//        public class BlManager
//        {
//            public AddressService addressService { get; }
//            //public CarService carService { get; }
//            //public TypeCarService typeCarService { get; }
//            //public UserService userService { get; }


//            public BlManager(string connString)
//            {
//                ServiceCollection services = new();

//                services.AddScoped(d => new DalManager(connString));
//                services.AddScoped<IAddressService, AddressService>();
//                //services.AddScoped<ICarService, CarService>();
//                //services.AddScoped<ITypeCarService, TypeCarService>();
//                //services.AddScoped<IUserService, UserService>();

//                ServiceProvider serviceProvider = services.BuildServiceProvider();
//                addressService = (AddressService)serviceProvider.GetRequiredService<IAddressService>();
//                //carService = (CarService)serviceProvider.GetRequiredService<ICarService>();
//                //typeCarService = (TypeCarService)serviceProvider.GetRequiredService<ITypeCarService>();
//            }


//    }
//}

using Bl.Api;
using Bl.Implement;
using Dal;
using Microsoft.Extensions.DependencyInjection;

namespace Bl
{
    public class BlManager
    {
        public AddressService addressService { get; }

        public BlManager(string connString)
        {
            ServiceCollection services = new();
            
            services.AddScoped(d => new DalManager(connString));
            services.AddScoped<IAddressService, AddressService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            addressService = (AddressService)serviceProvider.GetRequiredService<IAddressService>();
        }
    }
}
