using Microsoft.AspNetCore.Mvc;
using StudentManagementWebApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List(string Major)
        {
            //hien thi ds Student hoc Major. Neu Major=All -> hien thi ds tat ca student.
            List<Student> students = new List<Student>();
            List<String> majors = new List<String>();
            //using (var context = new DemoDBPRN211Context())
            //{
            //    if (Major.ToLower().Equals("all"))
            //        students = context.Students.ToList(); 
            //    else
            //        students = context.Students.Where(x => x.Major.ToLower().Equals(Major.ToLower())).ToList();
            //    majors = context.Students.Select(x => x.Major).Distinct().ToList();
            //}
            ViewBag.Majors = majors;
            ViewBag.CurMajor = Major;
            return View(students);
        }

        //public IActionResult ListType2(string Major)
        //{
        //    //hien thi ds Student hoc Major. Neu Major=All -> hien thi ds tat ca student.
        //    List<Student> students;
        //    List<String> majors;
        //    using (var context = new DemoDBPRN211Context())
        //    {
        //        if (Major.ToLower().Equals("all"))
        //            students = context.Students.ToList();
        //        else
        //            students = context.Students.Where(x => x.Major.ToLower().Equals(Major.ToLower())).ToList();
        //        majors = context.Students.Select(x => x.Major).Distinct().ToList();
        //    }
        //    ViewBag.Majors = majors;
        //    ViewBag.CurMajor = Major;
        //    return View(students);
        //}

        public IActionResult Create()
        {
            return View();
        }

    //    public IActionResult DoCreate(Student student)
    //    {
    //        //lay dc du lieu tu form -> insert vao csdl
    //        if (student.ForeignStudent is null) student.ForeignStudent = false;
    //        using (var context = new DemoDBPRN211Context())
    //        {
    //            context.Students.Add(student);
    //            context.SaveChanges();
    //        }

    //            //chuyen trang quay lai trang List.
    //            return RedirectToAction("List");
    //    }

    //    public IActionResult Edit(int Major)
    //    {
    //        Student s;
    //        using (var context = new DemoDBPRN211Context())
    //        {
    //            s = context.Students.FirstOrDefault(x => x.StudentId == Major);
    //        }
    //        return View(s);
    //    }

    //    public IActionResult DoEdit(Student student)
    //    {
    //        //lay dc du lieu tu form -> insert vao csdl
    //        if (student.ForeignStudent is null) student.ForeignStudent = false;
    //        using (var context = new DemoDBPRN211Context())
    //        {
    //            Student s = context.Students.FirstOrDefault(x => x.StudentId == student.StudentId);
    //            if (s != null)
    //            {
    //                s.Name = student.Name;
    //                s.Major = student.Major;
    //                s.Male = student.Male;
    //                s.Dob = student.Dob;
    //                s.ForeignStudent = student.ForeignStudent;
    //                context.SaveChanges();
    //            }
                
    //        }

    //        //chuyen trang quay lai trang List.
    //        return RedirectToAction("List");
    //    }

    //    public IActionResult DoDelete(int Major)
    //    {
    //        Student s;
    //        using (var context = new DemoDBPRN211Context())
    //        {
    //            s = context.Students.FirstOrDefault(x => x.StudentId == Major);
    //            if (s != null)
    //            {
    //                context.Students.Remove(s);
    //                context.SaveChanges();
    //            }
                    
    //        }
    //        return RedirectToAction("List");
    //    }
    }
}
