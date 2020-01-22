using System.Collections.Generic;

namespace University.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<CourseStudent>();
        }
        public string Name { get; set; }
        public int CourseId { get; set;}
        public virtual ICollection<CourseStudent> Students { get; set; }

    }
}