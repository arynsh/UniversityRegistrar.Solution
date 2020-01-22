using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace University.Controllers
{
    public class StudentsController : Controller
    {
        private readonly UniversityContext _db;
        public StudentsController(UniversityContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Students.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student, int CourseId)
        {   
            _db.Students.Add(student);
            if (CourseId != 0)
            {
                _db.CourseStudent.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId});
            }
            
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Student thisStudent = _db.Students
            .Include(student => student.Courses)
            .ThenInclude(join => join.Course)
            .FirstOrDefault(student => student.StudentId == id);
            return View(thisStudent);
        } 

        public ActionResult AddCourse(int id)
        {
            var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
            ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
            return View(thisStudent);
        }
        [HttpPost]
        public ActionResult AddCourse(Student student, int CourseId)
        {
            CourseStudent join = _db.CourseStudent.FirstOrDefault(coursestudent => coursestudent.CourseId == CourseId && coursestudent.StudentId == student.StudentId);
            if (CourseId != 0 && join == null)
            {
                _db.CourseStudent.Add(new CourseStudent() {CourseId = CourseId, StudentId= student.StudentId});
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}