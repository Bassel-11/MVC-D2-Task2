using Microsoft.AspNetCore.Mvc;
using MVC_D2_Task2.Models;

namespace MVC_D2_Task2.Controllers
{
    public class DepartmentController : Controller
    {
        static List<Department> _Departments = new List<Department>()
        {
            new Department { Id = 1, Name = "Front" },
            new Department { Id = 2, Name = "Back" },
            new Department { Id = 3, Name = "Android" },
            new Department { Id = 4, Name = "Reactjs" },
        };

        // URL: http://localhost:5298/Department/GetAll
        public IActionResult GetAll()
        {
            return View(_Departments);
        }

        public IActionResult ViewDetails(int id)
        {
            var department = _Departments.FirstOrDefault(d => d.Id == id);
            return View(department);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult ActualCreate(Department newDepartment)
        {
            _Departments.Add(newDepartment); 
            return RedirectToAction("GetAll");
        }
    }
}
