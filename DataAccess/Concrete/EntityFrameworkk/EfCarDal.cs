﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameworkk
{
    /* public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
  {
   public List<CarDetailDto> GetCarDetails()
      {
          using (ReCapContext context = new ReCapContext)
          {
              var result from c in context.Cars
                         join b in context.Brands on c.BrandId equals b.Id
                         join co in context.Colors on c.ColorId equals co.Id
                         select new CarDetailDto
                         orderby c.CarId
                         {
                             CarId = c.Id,
                             BrandId = b.BrandId,
                             ColorId = co.ColorId,
                             ColorName=


                         }
  

}
        }
    }
    */
}
