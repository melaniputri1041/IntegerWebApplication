using System.Runtime.CompilerServices;
using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApplication.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            var cars = new List<Car>();
            cars.Add(new Car()
            {
                IDRegistration = 001,
                Type = "sedan",
                Merek = "Toyota",
                varian = "FT86"

            });
            cars.Add(new Car()
            {
                IDRegistration = 002,
                Type = "SUV",
                Merek = " Toyota",
                varian = "RAV4"

            });
            cars.Add(new Car()
            {
                IDRegistration = 003,
                Type = "sedan",
                Merek = "Honda",
                varian = "Accord"
            });
            cars.Add(new Car()
            {
                IDRegistration = 004,
                Type = "SUV",
                Merek = "Honda",
                varian = "CRV"
            });
            cars.Add(new Car()
            {
                IDRegistration = 005,
                Type = "sedan",
                Merek = "Honda",
                varian = "City"
            });

            //ViewBag.Cars = cars;

            /*var cars = new Car[]
            {
                new Car{IDRegistration = 001, Type = "Sedan",Merek = "Toyota",varian = "FT86"},
                new Car{IDRegistration = 002, Type = "SUV", Merek = "Toyota",varian = "RAV4"},
                new Car{IDRegistration = 003, Type = "Sedan",Merek = "Honda",varian = "Accord"},
                new Car{IDRegistration = 004, Type = "SUV",Merek = "Honda", varian = "CRV"},
                new Car{IDRegistration = 005, Type = "Sedan",Merek = "Honda", varian = "City"},
            };*/

            /*var cari = cars.Single(x => x.IDRegistration == 2);
            cars.Remove(cari);*/


            /*ViewBag.Cars = cars;*/

            /*var car1 = cars.Where(x => x.Type == "Sedan");
            ViewBag.Cars = car1;*/

            /*var car = cars.Where(x => x.Type == "sedan").FirstOrDefault();
            ViewBag.Cars = new List<Car>() { car };*/

            //soal1
            /*var car = cars.Where(x => x.Merek == "Honda").FirstOrDefault();
            ViewBag.cars = new List<Car>() { car };*/

            //soal2
            /*var car = cars.Where(x => x.Merek == "Honda" && x.Type == "sedan");
            ViewBag.cars = car;*/

            //soal3
            /*var car = cars.Where(x => x.Merek == "Honda" && x.varian == "City").FirstOrDefault();
            ViewBag.cars = new List<Car>() { car };*/

            //soal4
            /*var car = cars.Where(x => x.Merek == "Toyota");
            ViewBag.cars = car;*/

            //soal5
            /*var car = cars.Where(x => x.varian == "City");
            ViewBag.cars = car;*/

            //soal6
            var car = cars.Where(x => x.Type == "sedan");
            ViewBag.cars = car;

            return View();

        }
    }
}
