using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApplication.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {

            var student = new List<Student>();

            student.Add(new Student()
            {

                id = 1,
                name = "melan",
                addres = "Banjarsari",
                phonenumber = "1234567890"
            });
            student.Add(new Student()
            {

                id = 2,
                name = "Naily",
                addres = "Banyumas",
                phonenumber = "1234567890"
            });


            return View(student);
        }
    }
}
