using System.Collections.Generic;
using System;

namespace University.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<CourseStudent>();
        }
        public string Name { get; set;}
        public int StudentId { get; set; }
        public DateTime DateOfEnroll { get; set;}
        public ICollection<CourseStudent> Courses { get; }
    }
}