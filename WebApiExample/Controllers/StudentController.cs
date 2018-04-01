using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExample.Context;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/student/getstudents")]
        public IHttpActionResult GetAllStudents(bool includeAddress = false)
        {
            IList<StudentViewModel> students = null;
            using (var ctx = new SchoolDbContext())
            {
                students = ctx.Students.Include("StudentAddress")
                            .Select(s => new StudentViewModel()
                            {
                                Id = s.StudentId,
                                FirstName = s.FirstName,
                                LastName = s.LastName
                            }).ToList();
            }

            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);
        }

        //public IHttpActionResult GetAllStudentsWithAddress()
        //{
        //    IList<StudentViewModel> students = null;

        //    using (var ctx = new SchoolDbContext())
        //    {
        //        students = ctx.Students.Include("StudentAddress").Select(s => new StudentViewModel()
        //        {
        //            Id = s.StudentId,
        //            FirstName = s.FirstName,
        //            LastName = s.LastName,
        //            Address = s.StudentAddress == null ? null : new AddressViewModel()
        //            {
        //                StudentId = s.StudentAddress.StudentId,
        //                Address1 = s.StudentAddress.Address1,
        //                Address2 = s.StudentAddress.Address2,
        //                City = s.StudentAddress.City,
        //                State = s.StudentAddress.State
        //            }
        //        }).ToList<StudentViewModel>();
        //    }


        //    if (students.Count == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(students);
        //}

        [Route("api/student/getstudent")]
        public IHttpActionResult GetStudentById(int id)
        {
            StudentViewModel student = null;

            using (var ctx = new SchoolDbContext())
            {
                student = ctx.Students.Include("StudentAddress")
                    .Where(s => s.StudentId == id)
                    .Select(s => new StudentViewModel()
                    {
                        Id = s.StudentId,
                        FirstName = s.FirstName,
                        LastName = s.LastName
                    }).FirstOrDefault<StudentViewModel>();
            }

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        //public IHttpActionResult GetAllStudents(string name)
        //{
        //    IList<StudentViewModel> students = null;

        //    using (var ctx = new SchoolDbContext())
        //    {
        //        students = ctx.Students.Include("StudentAddress")
        //            .Where(s => s.FirstName.ToLower() == name.ToLower())
        //            .Select(s => new StudentViewModel()
        //            {
        //                Id = s.StudentId,
        //                FirstName = s.FirstName,
        //                LastName = s.LastName,
        //                Address = s.StudentAddress == null ? null : new AddressViewModel()
        //                {
        //                    StudentId = s.StudentAddress.StudentId,
        //                    Address1 = s.StudentAddress.Address1,
        //                    Address2 = s.StudentAddress.Address2,
        //                    City = s.StudentAddress.City,
        //                    State = s.StudentAddress.State
        //                }
        //            }).ToList<StudentViewModel>();
        //    }


        //    if (students.Count == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(students);

        //}

        //public IHttpActionResult GetAllStudentsInSameStandard(int standardId)
        //{
        //    IList<StudentViewModel> students = null;

        //    using (var ctx = new SchoolDbContext())
        //    {
        //        students = ctx.Students.Include("StudentAddress").Include("Standard").Where(s => s.StandardId == standardId)
        //                    .Select(s => new StudentViewModel()
        //                    {
        //                        Id = s.StudentId,
        //                        FirstName = s.FirstName,
        //                        LastName = s.LastName,
        //                        Address = s.StudentAddress == null ? null : new AddressViewModel()
        //                        {
        //                            StudentId = s.StudentAddress.StudentId,
        //                            Address1 = s.StudentAddress.Address1,
        //                            Address2 = s.StudentAddress.Address2,
        //                            City = s.StudentAddress.City,
        //                            State = s.StudentAddress.State
        //                        },
        //                        Standard = new StandardViewModel()
        //                        {
        //                            StandardId = s.Standard.StandardId,
        //                            Name = s.Standard.StandardName
        //                        }
        //                    }).ToList<StudentViewModel>();
        //    }


        //    if (students.Count == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(students);
        //}
    }
}
