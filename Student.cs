using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace College_system
{
    internal class Student : Person
    {
        public string? Major {  get; set; }
        public bool IsPaid { get; set; }
        public string? DepartmentID { get; set; }
        int _level;
        double _gpa;
        public List <Course>? Course { get; set; }
        public Student()
        {
            ID = $"S{_level}{DepartmentID}{_counter++}";
        }
        public Student (string nationalId, string name, DateOnly birthDate, string gender, string phone, string email, string address, string major, int level, double gpa ,bool isPaid, string departmentId) : base(nationalId, name, birthDate, gender, phone, email, address)
        {
            //      level 1 dept 2 (code)
            ID = $"S{level}{DepartmentID}{_counter++}";  // 
            Major = major; // بنعرف ان الفيلدس الي بره هي هي اللي هتتبعت في الميثود 
            Level = level;
            Gpa = gpa;
            IsPaid = isPaid;
            DepartmentID = departmentId;
            Course = [];
        }
        public int Level
        {
            set
            {
                if (value < 1 || value > 4)
                    throw new AggregateException("the level is incorrect!");
            }
            get { return _level; }
        }
        public double Gpa
        {
            set
            {
                if (value < 0 || value > 4)
                    throw new AggregateException("the level is incorrect!");
            }
            get { return _gpa; }
        }
        public override void Display()
        {
            base.Display();
            Console.Write($"Major : {Major}\nLevel : {Level}\nGpa : {Gpa}\nIsPaid : {IsPaid}");
        }
        public void ShowCourses() => Course?.ForEach(s => Console.WriteLine(s.Name));
        

    }
}
