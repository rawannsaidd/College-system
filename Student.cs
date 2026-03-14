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
        static int _studentCounter = 1;
        string Major {  get; set; }
        bool IsPaid { get; set; }
        string DepartmentID { get; set; }
        int _level;
        double _gpa;
        public Student()
        {

        }
        public Student (string nationalId, string name, DateOnly birthDate, string gender, string phone, string email, string address, string major, int level, double gpa ,bool isPaid, string departmentId) : base(nationalId, name, birthDate, gender, phone, email, address)
        {
            //     ex level 1 dept 2 (code)
            ID = $"S{level}{DepartmentID}{_studentCounter++}";  // 
            Major = major; // بنعرف ان الفيلدس الي بره هي هي اللي هتتبعت في الميثود 
            Level = level;
            Gpa = gpa;
            IsPaid = isPaid;
            DepartmentID = departmentId;
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
     
    }
}
