using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice >= 0)
            {
                _carDal.Add(car);
                Console.WriteLine("New Car Added succesfuly");
            }
        }
        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetById(int Id)
        {
            return _carDal.GetAll(c => c.Id == Id);
        }

        public List<Car> GetByModelYear(int ModelYear)
        {
            return _carDal.GetAll(c => c.ModelYear == ModelYear);
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);

        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
