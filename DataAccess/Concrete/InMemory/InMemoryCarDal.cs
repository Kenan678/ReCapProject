using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=150, Description="BMW", ModelYear=2013 },
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=110, Description="Mercedes", ModelYear=2015 },
                new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=120, Description="Mustang", ModelYear=2014 },
                new Car{Id=4, BrandId=4, ColorId=4, DailyPrice=320, Description="RangeRover", ModelYear=2022 },
                new Car{Id=5, BrandId=5, ColorId=5, DailyPrice=65, Description="Elantra", ModelYear=2022 },



         };
        }


        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(CarToDelete);
        }


        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
        }

        public List<Car> GetByModelYear(int ModelYear)
        {
            throw new NotImplementedException();
        }
    }
}
