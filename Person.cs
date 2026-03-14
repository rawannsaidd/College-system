using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace College_system
{
    public class Person
    {
        protected static int _counter = 1; // بروتيكديت برضو عشان الكلاسات الوارثه بس هي اللي تشوفه 
        public string? ID { get; protected set; } // بروتيكديت سيت بتخلي الكلاسات الوارثه بس هي اللي يغير فيه
        string _nationalId = string.Empty;       

        string? _name ;
        DateOnly _birthDate;
        string? _gender;

        string _phone = string.Empty;
        string _email;
        string _address;

        public Person()
        {

        }
        public Person(string nationalId, string name, DateOnly birthDate, string gender, string phone, string email, string address)
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
                if (value.Length! < 14 || value.Length! > 14)
                    throw new ArgumentException("the national ID most be 14 number");
                else
                   _nationalId = value;
            }
            get { return _nationalId; }
        }
        public string? Name
        {
            set
            {
                if (string.IsNullOrEmpty(value) || value.Any(r=>char.IsDigit(r)))
                    throw new ArgumentException("name is incorrect!");
                else
                    _name = value;
            }
            get { return _name; }
        }
        public DateOnly BirthDate
        {
            set
            {
                int age = DateTime.Now.Year - value.Year;
                if (DateTime.Now.DayOfYear < value.DayOfYear)
                    age--;

                if (value >= DateOnly.FromDateTime(DateTime.Now) || age < 17)
                    throw new ArgumentException("❌ التاريخ غلط!");
                else
                    _birthDate = value;
            }
            get { return _birthDate; }
        }
        public string? Gender
        {
            set
            {
                value = value.Trim().ToLower();// لو فيه مسافات او حروف كبيره
                if (value != "male" && value != "female")
                throw new ArgumentException("gender most be female or male");

                else
                    _gender = value;
            }
            get { return _gender; }
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
                if (!value.Contains('@') || !value.Contains('.'))// لو مفيهوش علامات الemail الاساسيه
                    throw new ArgumentException("email is incorrect!");
                else
                    _email = value;
            }
            get { return _email; }
        }
        public string? Address
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
        public virtual void Display() => Console.WriteLine($"Id: {ID}\nname: {_name}\nnational Id : {_nationalId}\nbirth date : {_birthDate}\ngender: {_gender}\nphone: {_phone}\nemail:{_email}\naddress:{_address}");
    }
}

