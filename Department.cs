using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace College_system
{
    internal class Department
    {
        static int _counter = 1;
        public string? Name { get; set; }
        public string? ID { get; set; } 
        public List<Course>? Courses { get; set; }
        public List<Doctor>? Doctors { get; set; }
        public Doctor? HeadOfDepartment { get; set; }
        public Department()
        {
            ID = $"DEP{_counter++}";
        }
        //                               optional ممكن يكون فيه رئيس قسم او لا
        public Department(string name, Doctor? headOfDepartment = null)
        {
            ID = $"DEP{_counter++}";
            Name = name;
            Courses = new List<Course>();
            Doctors = new List<Doctor>();
            HeadOfDepartment = headOfDepartment;
        }
        public void Display()
        {
            Console.Write($"Department Name : {Name}\nDepartment ID : {ID}\nHead Of Department : {HeadOfDepartment?.Name}");
            Console.WriteLine("departnent courses");
            Courses?.ForEach(c => Console.WriteLine($"  - {c.Name}"));
            Console.WriteLine("departnent doctors");
            Doctors?.ForEach(d => Console.WriteLine($"  - {d.Name}"));
        }
    }
}
