using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            BrandTest();

            //ColorTest();

            //CarTest_Add();
        }

        private static void CarTest_Add()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 2, ColorId = 4, DailyPrice = 2095000, Description = "BMW 320i M Sport", ModelYear = 2022 });
            carManager.Add(new Car { BrandId = 6, ColorId = 2, DailyPrice = 1724950, Description = "Volvo XC40", ModelYear = 2021 });

            var result = carManager.GetCarsByColorId(4);
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " ---> " + car.ColorName + "---> " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
          
        }
    }
}
