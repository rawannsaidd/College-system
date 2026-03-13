using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_system
{
    public class Employee : Person
    {
        public double Salary { get; set; }
        string _jobTitle = null!;
        DateOnly HireDate;
        public Employee() 
        {
        
        }
        public Employee(string nationalId, string name, DateOnly birthDate, string gender, string phone, string email, string address, double salary, string jobTitle, DateOnly hireDate) : base( nationalId, name, birthDate, gender, phone, email, address)
        {
            ID = $"A{_counter}";
            Salary = salary;
            JobTitle = jobTitle;
            HireDate = hireDate;
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
        public override void Display()
        {
            base.Display(); // بيطبع بيانات Person الأول
            Console.Write($"salary: {Salary}\njobTitle: {_jobTitle}\nHire Date: {HireDate}");
        }
    }
}
