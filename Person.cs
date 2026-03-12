using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_system
{
    public class Person
    {

        static int _counter = 1; // كاونتر لل ID
        public int ID { get; } // من غير سيت عشان الكونستراكتور هو بس اللي يحطه
        string _nationalId = string.Empty;

        string _name = string.Empty;
        DateOnly _birthDate;
        string _gender = string.Empty;

        string _phone = string.Empty;
        string _email = string.Empty;
        string _address = string.Empty;

        public Person()
        {

        }
        public Person(string nationalId, string name, DateOnly birthDate, string gender, string phone, string email, string address)
        {
            ID = _counter++;
            NationalId = nationalId;
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            Phone = phone;
            Email = email;
            Address = address;
        }
        public string NationalId
        {
            set
            {
                if (value.Length != 14)
                    Console.WriteLine("the national ID most be 11 number");
                else
                    _nationalId = value;
            }
            get { return _nationalId; }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("name is not correct");
                else
                    _name = value;
            }
            get { return _name; }
        }
        public DateOnly BirthDate
        {
            set
            {
                if (value >= DateOnly.FromDateTime(DateTime.Now))// حولنا الديت تايم دوت ناو ل ديت اونلي عشان نعرف نقارنهم ببعض
                    Console.WriteLine("birthDate is not correct");
                else
                {
                    int age = DateTime.Now.Year - value.Year; // حساب العمر 
                    if (DateTime.Now.DayOfYear < value.DayOfYear)
                        age--;

                    if (age <= 18)
                        Console.WriteLine("the age most be over 18");
                    else
                        _birthDate = value;
                }
            }
            get { return _birthDate; }
        }
        public string Gender
        {
            set
            {
                value = value.Trim().ToLower();// لو فيه مسافات او حروف كبيره
                if (value != "male" && value != "female")
                    Console.WriteLine("gender most be female or male ");
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
                    Console.WriteLine("phone is not correct");
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
                    Console.WriteLine("email is not correct");
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
                    Console.WriteLine("address is not correct");
                else
                    _address = value;
            }
            get { return _address; }
        }
        public virtual void Display() => Console.WriteLine($"Id: {ID}\nname: {_name}\nnational Id : {_nationalId}\nbirth date : {_birthDate}\ngender: {_gender}\nphone: {_phone}\nemail: {_email}address: {_address}");






























    }
}

