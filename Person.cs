using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace College_system
{
    public enum Gender 
    {
        female, male
    }
    public class Person
    {
        protected static int _counter = 1; // بروتيكديت برضو عشان الكلاسات الوارثه بس هي اللي تشوفه 
        public string? ID { get; protected set; } // بروتيكديت سيت بتخلي الكلاسات الوارثه بس هي اللي يغير فيه
        public Gender Gender { get; set; }
        string _nationalId = string.Empty;       

        string _name = string.Empty;
        DateOnly _birthDate;

        string _phone = string.Empty;
        string _email = string.Empty;
        string _address = string.Empty;
        public Person()
        {
            ID = $"{_counter++}";
        }
        public Person(string nationalId, string name, DateOnly birthDate, Gender gender, string phone, string email, string address)
        {
            ID = $"{_counter++}";
            NationalId = nationalId;
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            Phone = phone;
            Email = email;
            Address = address;
          //property = parameter
        }
        public string NationalId
        {
            set
            {
                if (value.Length != 14) // لو الرقم القومي اقل من 14 رقم
                    throw new ArgumentException("the national ID most be 14 number");
                else
                   _nationalId = value;
            }
            get { return _nationalId; }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value) || value.Any(r=>char.IsDigit(r))) // لو الاسم فاضي او فيه ارقام
                    throw new ArgumentException("name is incorrect!");
                else
                    _name = value;
            }
            get { return _name; }
        }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - _birthDate.Year;
                if (DateTime.Now.DayOfYear < _birthDate.DayOfYear)
                    age--;
                return Age;
            }
        }
        public DateOnly BirthDate
        {
            set
            {
                int age = DateTime.Now.Year - value.Year; // لو عيد ميلاده لسه مجاش فعليا بس السنه بتقول انه جه ينقص سنه
                if (DateTime.Now.DayOfYear < value.DayOfYear)
                    age--;

                if (value >= DateOnly.FromDateTime(DateTime.Now) || age < 18) //
                    throw new ArgumentException("Birth Date is incorrect!");
                else
                    _birthDate = value;
            }
            get { return _birthDate; }
        }
        public string Phone
        {
            set
            {
                if (value.Length != 11 || !value.StartsWith("01"))// لو مش مكون من 11 رقم او مش بادئ ب01
                    throw new ArgumentException("phone is incorrect!");
                else
                    _phone = value;
            }
            get { return _phone; }
        }
        public string Email
        {
            set
            {
                if (!value.Contains('@') || !value.Contains('.'))// لو مفيهوش العلامات الاساسيه ف الemail
                    throw new ArgumentException("email is incorrect!");
                else
                    _email = value;
            }
            get { return _email; }
        }
        public string Address
        {
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 10)// لو العنوان فاضي او اقل من 10 حروف
                    throw new ArgumentException("address is incorrect!");
                else
                    _address = value;
            }
            get { return _address; }
        }
        public virtual void Display() => Console.WriteLine($"Id: {ID}\nname: {_name}\nnational Id : {_nationalId}\nbirth date : {_birthDate}\ngender: {Gender}\nphone: {_phone}\nemail:{_email}\naddress:{_address}");
    }
}

