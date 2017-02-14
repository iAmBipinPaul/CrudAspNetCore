using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CURD_OPERATION.Models;
using Microsoft.AspNetCore.Http;

namespace CURD_OPERATION.Controllers
{
    public class HomeController : Controller
    {
        private StudentDBContext _context;

        public HomeController(StudentDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {

            if(ModelState.IsValid)
            {
                _context.Add(newStudent);
                _context.SaveChanges();
                ModelState.Clear();
            }

            return RedirectToAction("ViewStudent");
        }

        public IActionResult ViewStudent()
        {
            var a = _context.Students;
            return View(a);
        }

        [HttpGet]
        public IActionResult EditStudent(long id)
        {
            Student student = _context.Set<Student>().SingleOrDefault(c => c.ID == id);

            return View(student);

        }
        [HttpPost]
        public IActionResult EditStudent(long id,Student newStudent)
        {
            Student student = _context.Set<Student>().SingleOrDefault(c => c.ID == id);
            _context.Set<Student>().SingleOrDefault(s => s.ID == id);
            student.Name = newStudent.Name;
            student.RegistrationNumber = newStudent.RegistrationNumber;
            _context.SaveChanges();
            return RedirectToAction("ViewStudent");
        }
        [HttpGet]
        public IActionResult DeleteStudent(long id)
        {
            Student student = _context.Set<Student>().SingleOrDefault(c => c.ID == id);
            return View(student);

        }
        [HttpPost]
        public IActionResult DeleteStudent(long id, FormCollection form)
        {

            Student student = _context.Set<Student>().SingleOrDefault(c => c.ID == id);
            _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("ViewStudent");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
