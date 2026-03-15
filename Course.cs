using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_system
{
    internal class Course
    {
        static int _counter = 1;
        public string ID { get; set; } 
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int Hours { get; set; }
        public Doctor? Doctor { get; set; }
        public Department? Department { get; set; }
        public Course()
        {
            ID = $"COR{_counter++}";
        }
        public Course(string code, string name, int hours, Doctor doctor,Department department)
        {
            ID = $"COR{_counter++}";
            Code = code;
            Name = name;
            Hours = hours;
            Doctor = doctor;
            Department = department;
        }
        public void Display()
        {
            Console.Write($"Course ID : {ID}\nCourse Code : {Code}\nCourse Name : {Name}\nCourse Hours : {Hours}\nCourse Doctor : {Doctor?.Name}\nCourse Department : {Department?.Name}");
        }
    }
}
