using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace College_system
{
    internal class Doctor : Employee
    {
        public List<Course>? Courses { get; set; }
        public List<Department>? Departments { get; set; }
        public string? Specialty { get; set; }

        public Doctor()
        {
            ID = $"DR{_counter++}";
        }
        public Doctor(string nationalId, string name, DateOnly birthDate, string gender, string phone, string email, string address, double salary, string jobTitle, DateOnly hireDate, string specialty) : base(nationalId, name, birthDate, gender, phone, email, address,salary, jobTitle, hireDate)
        {
            Specialty = specialty;
            Courses = [];     
            Departments = []; 
            ID = $"DR{_counter++}";
        }
    }
}
