using Bl.Api;
using Bl.DTO;
using Dal;
using Dal.Implement;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Implement
{
    public class CarService : ICarService
    {
        CarRepo cars;
        public CarService(DalManager manager) 
        {
            //this.cars = manager.carRepo;
            throw new NotImplementedException();
        }

        public CarDTO Add(CarDTO t)
        {
            throw new NotImplementedException();
        }

        public CarDTO Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CarDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public CarDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public CarDTO Update(int Id, CarDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
