using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_system
{
    public class Employee : Person
    {
        public double _salary { get; set; }
        string _jobTitle = null!;
        DateOnly _hireDate;
        public Employee(string nationalId, string name, DateOnly birthDate, string gender, string phone, string email, string address, double salary, string jobTitle, DateOnly hireDate) : base( nationalId, name, birthDate, gender, phone, email, address)
        {
            _salary = salary;
            _jobTitle = jobTitle;
            _hireDate = hireDate;
        }
        public string JobTitle
        {
            get { return _jobTitle; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("The job title is incorrect!");
                else
                    _jobTitle = value;
            }
        }
        public DateOnly HireDate
        {
            get { return _hireDate; }
            set
            {
                if (value > DateOnly.FromDateTime(DateTime.Now))
                    Console.WriteLine("The Hire Date is incorrect!");
                else
                    _hireDate = value;
            }
        }
        public override void Display()
        {
            base.Display(); // بيطبع بيانات Person الأول
            Console.WriteLine($"salary: {Salary}\njobTitle: {_jobTitle}\nHire Date: {_hireDate}");
        }
    }
}
