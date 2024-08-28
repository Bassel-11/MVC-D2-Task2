using Microsoft.AspNetCore.Mvc;
using MVC_D2_Task2.Models;

namespace MVC_D2_Task2.Controllers
{
    public class StudentController : Controller
    {

        static List<Student> _Students = new List<Student>()
        {
            new Student { Id = 1, Name = "ahmed", Address = "cairo", Age = 21 },
            new Student { Id = 2, Name = "hana", Address = "alex", Age = 22 },
            new Student { Id = 3, Name = "ali", Address = "mansoura", Age = 32},
            new Student { Id = 4, Name = "nora", Address = "ismailia", Age = 20},
            new Student { Id = 5, Name = "mohamed", Address = "portsaid", Age = 25},
            new Student { Id = 6, Name = "aya", Address = "bla bla bla", Age = 30}
        };

        public IActionResult GetAll()
        {
            ViewBag.Students = _Students;
            return View();
        }

        public IActionResult ViewDetails(int id)
        {
            var student = _Students.FirstOrDefault(s => s.Id == id);
            ViewBag.SingleStudent = student;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult ActualCreate(int id, string name, string address, int age)
        {
            Student newStudent = new Student { Id = id, Name = name, Address = address, Age = age };
            _Students.Add(newStudent); 
            return RedirectToAction("GetAll");
        }
    }
}
