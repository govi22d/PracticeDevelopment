using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiExample.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StandardId { get; set; }
        public virtual Standard Standard { get; set; }
        //public int AddressId { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }
        public virtual  List<Course> Courses { get; set; }

    }

    public class Standard
    {
        [Key]
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }

        public virtual  List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }

    public class StudentAddress
    {
        //[Key]
        //public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [ForeignKey("Student")]
        public int StudentAddressId { get; set; }
        public Student Student { get; set; }
    }

    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Location { get; set; }
        
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual List<Student> Students { get; set; }
    }

    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int StandardId { get; set; }
        public virtual Standard Standard { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}