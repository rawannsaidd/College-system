using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_system
{
    internal class Student : Person
    {
         string _major = string.Empty;
         int _level;
         double _gpa;
         bool _isPaid;

        public Student (string nationalId, string name, DateOnly birthDate, string gender, string phone, string email, string address, string major, int level, double gpa ,bool isPaid) : base(nationalId, name, birthDate, gender, phone, email, address)
        {
            _major = major; // بنعرف ان الفيلدس الي بره هي هي اللي هتتبعت في الميثود 
            _level = level;
            _gpa = gpa;
            _isPaid = isPaid;
        }
        public string Major
        {

        }

    }
}
