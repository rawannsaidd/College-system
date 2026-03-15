using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_system
{
    public enum EnrollmentStatus
    {
        Active, Dropped, Banned
    }
    public enum Semester 
    {
        Fall, Spring, Summer
    }
    internal class Enrollment
    {
        static int _counter = 0;
        public string? StudentId { get; set; } 
        public string? CourseId { get; set; }
        public int Year { get; set; }
        public Semester Semester{ get; set; }
        public EnrollmentStatus Status { get; set; }
        public double Grade { get; set; }




    }
}
