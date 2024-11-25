﻿using Dal.Api;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarRepo carRepo;
        public CarsController(ICarRepo carRepo)
        {
            this.carRepo = carRepo;
        }

        [HttpGet]
        public ActionResult<List<Car>> GetAll()
        {
            var cars = carRepo.GetAll();
            if (cars == null)
            {
                return NotFound();
            }
            return cars;
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetById(int id)
        {
            Car car = carRepo.GetById(id);
            if (car == null)
            {
                return NotFound();
            }
            return car;
        }

        [HttpPost]
        public ActionResult<Car> Post([FromBody] Car car)
        {
            if (car == null)
            {
                return NotFound();
            }
            return carRepo.Add(car);
        }

        [HttpDelete("{id}")]
        public ActionResult<Car> Delete(int id)
        {
            var delete = carRepo.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return delete;
        }

        [HttpPut]
        public ActionResult<Car> Update([FromBody] Car car, int id)
        {
            if (car == null)
            {
                return NotFound();
            }
            return carRepo.Update(car, id);
        }
    }
}
