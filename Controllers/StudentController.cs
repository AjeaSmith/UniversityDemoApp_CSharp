using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityDemo.DAL;
using UniversityDemo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversityDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolContext _context;
        public StudentController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students;

            return View(students);
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var students = _context.Students.Include(s => s.Enrollments).ThenInclude(c => c.Course).FirstOrDefault(m => m.StudentId == id);
            if(students == null)
            {
                return NotFound();
            }
            
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent([Bind("LastName, FirstName, EnrollmentDate")] StudentModel student)
        {
            if(!ModelState.IsValid)
            {
                RedirectToAction("Create", "Student");
            }

            _context.Students.AddRange(student);
            _context.SaveChanges();

            return RedirectToAction("Index", "Student");
        }
    }
}


















