using Microsoft.AspNetCore.Mvc;
using StudentManagementWebApp.Models;
using System;

namespace StudentManagementWebApp.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DoLogin(Teacher teacher)
        {
            if (teacher.Name == "Hai" && teacher.Password == "12345") {
                return RedirectToAction("TeacherClass");
            } 
            else {
                return View("Login");
            }
        }

        [Route("/Teacher/AttendanceCheck/{t}")]
        public IActionResult AttendanceCheck(string t)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            return View("AttendanceCheck",t);
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult TeacherClass()
        {
            return View("TeacherClass");
        }
    }
}
