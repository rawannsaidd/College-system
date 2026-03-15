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
        DateOnly _hiredate;
        public Employee()
        { 
            //     Admin ID
            ID = $"A{_counter}";
        }
        public Employee(string nationalId, string name, DateOnly birthDate, string gender, string phone, string email, string address, double salary, string jobTitle, DateOnly hiredate) : base( nationalId, name, birthDate, gender, phone, email, address)
        {
            ID = $"A{_counter}";
            Salary = salary;
            JobTitle = jobTitle;
            HireDate = hiredate;
        }
        public string JobTitle
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new AggregateException("The job title is incorrect!");
                else
                    _jobTitle = value;
            }
            get { return _jobTitle; }
        }
        public DateOnly HireDate
        {
            set
            {
                if (value > DateOnly.FromDateTime(DateTime.Now))
                    throw new ArgumentException("❌ تاريخ التعيين مش صح!");
                else
                    _hiredate = value;
            }
            get { return _hiredate; }
        }
        public override void Display()
        {
            base.Display(); 
            Console.Write($"salary: {Salary}\njobTitle: {_jobTitle}\nHire Date: {HireDate}");
        }
    }
}
