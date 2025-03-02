using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimStudyGroup.Models;

namespace SimStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> student = new List<Student>
            {
                new Student
                {
                    StudentNo ="21223356",
                    Name = "Sam",
                    Surname = "Ngcobo",
                    Email = "sam.ngcobo@gmail.com"

                },
                  new Student
                {
                    StudentNo ="22387876",
                    Name = "Ben",
                    Surname = "Jason",
                    Email = "ben.jason@gmail.com"

                },
                   new Student
                {
                    StudentNo ="23253756",
                    Name = "John",
                    Surname = "Stones",
                    Email = "john.stones@gmail.com"

                },
                       new Student
                {
                    StudentNo ="24427256",
                    Name = "Cole",
                    Surname = "Palmer",
                    Email = "cole.palmer@gmail.com"

                },
                        new Student
                {
                    StudentNo ="23782537",
                    Name = "Kuzivashe",
                    Surname = "Gwiza",
                    Email = "kuzivashe.gwiza@gmail.com"

                }

            };
            return View(student);
        }
    }
}