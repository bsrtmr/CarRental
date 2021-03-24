using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.BrandName);
            }
        }
    }
}
