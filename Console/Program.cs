using Business.Concrete;
using DataAccess.Concrete.EntityFrameworkk;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Id);

}

