using System.Numerics;
using System.Reflection.Emit;

namespace College_system
{
    internal class Program
    {
        static int ReadInt() // check int input  
        {
            int checkNum;
            while (!int.TryParse(Console.ReadLine(), out checkNum))
                Console.WriteLine("Invalid input, try again:");
            return checkNum;
        }
        static double ReadDouble() // check double input  
        {
            double checkNum;
            while (!double.TryParse(Console.ReadLine(), out checkNum))
                Console.WriteLine("Invalid input, try again:");
            return checkNum;
        }
        static DateOnly ReadDate() // check date input  
        {
            DateOnly checkDate;
            while (!DateOnly.TryParse(Console.ReadLine(), out checkDate))
                Console.WriteLine("Invalid input, try again:");
            return checkDate;
        }
        static Student ReadStudent() // add student
        {
            Console.WriteLine("Enter student information:");

            Console.Write("National ID: ");
            string nationalId = Console.ReadLine() ?? string.Empty;

            Console.Write("Name: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write("Birth Date (yyyy-MM-dd): ");
            DateOnly birthDate = ReadDate();

            Console.WriteLine("Gender:");
            Console.WriteLine("1. Male");
            Console.WriteLine("2. Female");
            int genderChoice = int.Parse(Console.ReadLine()!);
            Gender gender = genderChoice == 1 ? Gender.male : Gender.female;

            Console.Write("Phone Number: ");
            string Phone = Console.ReadLine() ?? string.Empty;

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? string.Empty;

            Console.Write("Address: ");
            string address = Console.ReadLine() ?? string.Empty;

            Console.Write("Major: ");
            string major = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("level: ");
            int level = ReadInt();

            Console.WriteLine("GPA: \nIs the student a transfer student? (y/n): ");
            string transfer = Console.ReadLine()!;
            double gpa = 0;
            if (transfer == "y")
            {
                Console.Write("Enter your previous GPA: ");
                gpa = ReadDouble();
            }

            Console.WriteLine("Department ID: ");
            string departmentId = Console.ReadLine() ?? string.Empty;

            return new Student( nationalId,  name,  birthDate, gender,  Phone,  email,  address, major,  level, gpa,  false,  departmentId);
        }

        static void Main()
        {
            // ============ Lists ============
            List<Student> students = new List<Student>();
            List<Employee> employees = new List<Employee>();
            List<Doctor> doctors = new List<Doctor>();
            List<Course> courses = new List<Course>();
            List<Department> departments = new List<Department>();
            List<Enrollment> enrollments = new List<Enrollment>();
            List<Payment> payments = new List<Payment>();
            List<Grade> grades = new List<Grade>();

            Console.WriteLine("(1) Student Management\n(2) Staff Management\n(3) Department Management\n(4) Enrollment and Grades\n(5) Payments\n(0) Logout");
            int Choise = ReadInt();
            while (Choise != 0)
            {
                switch (Choise)
                {
                    case 1:
                        Console.WriteLine("(1) Add student\n(2) Edit student information \n(3) Search for student\n(4) View all students\n(5) Delete student\n(0) Back");
                        int studentChoise = ReadInt();
                        while (studentChoise != 0)
                        {
                            switch (studentChoise)
                            { 
                                case 1: // add student
                                    Student newStudent = ReadStudent();
                                    students.Add(newStudent);
                                    Console.WriteLine("Student added successfully!");

                                    break;
                            }

                        }

                    break;
                }

            }                           
        }  
    
    }
}
