using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join c in context.Colors
                             on car.ColorId equals c.Id
                             select new CarDetailDto { CarId = car.Id, BrandId = b.Id, ColorId = c.Id, BrandName = b.BrandName, ModelYear = car.ModelYear, ColorName = c.ColorName, DailyPrice = car.DailyPrice, Description = car.Description };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
