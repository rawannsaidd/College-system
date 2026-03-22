using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace College_system
{
    internal class Payment
    {
        static int _counter = 1;
        public string? PaymentID {  get; set; }
        public string? StudentID { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? CoursID { get; set; }
        public Payment (string studentid, double amount, DateTime paymentDatedate)
        {
            PaymentID = $"PAY{_counter++}";
            StudentID = studentid;
            Amount = amount;
            PaymentDate = paymentDatedate;
        }
        public Payment(string studentid, double amount, DateTime paymentDatedate, string coursid)
        {
            PaymentID = $"{_counter}";
            StudentID = studentid ;
            Amount = amount;
            PaymentDate = paymentDatedate;
            CoursID = coursid;
        }
        public void Display()
        {
            Console.Write($"Payment ID : {PaymentID}\nStudent ID : {StudentID}\n Amount : {Amount}\n Payment Date : {PaymentDate}\n");
        }
        public void DisplayCours()
        {
            Console.Write($"Payment ID : {PaymentID}\nStudent ID : {StudentID}\n Amount : {Amount}\n Payment Date : {PaymentDate}\nCourse ID : {CoursID}\n");
        }

    }
}
