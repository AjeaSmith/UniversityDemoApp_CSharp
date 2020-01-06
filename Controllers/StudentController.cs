using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
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
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var student = _context.Students.Include(s => s.Enrollments).ThenInclude(c => c.Course)
                .FirstOrDefault(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent([Bind("LastName, FirstName, EnrollmentDate")] StudentModel student)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create", "Student");
            }

            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction("Index", "Student");
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return BadRequest();
            }
            var student = _context.Students.Find(id);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var studentToUpdate = _context.Students.Find(id);
            if (await TryUpdateModelAsync(studentToUpdate, "", s => s.FirstName, s => s.LastName, s => s.EnrollmentDate))
            {
                try
                {
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                catch (RetryLimitExceededException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(studentToUpdate);
        }
    }
        
}























