using System.Net;
using System.Numerics;
using System.Reflection;

namespace College_system
{
    internal class Program
    {
        static void Main()
        {

            //Student st = new Student();
            //Console.WriteLine(st.ID);
            bool stayInProgram = true;
            while (stayInProgram)
            {
                Console.WriteLine("=== College System ===\r\n1. Add Student\r\n2. Add Staff Member\r\n3. View All Students\r\n4. View All Staff Members\r\n5. Log Out");
                bool isConverted = int.TryParse(Console.ReadLine(), out int choose);
                while (isConverted == false)
                {
                    Console.WriteLine("pleas try again");
                    continue;
                }
                List<Student> stu = [];            
                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        while (true)
                        {
                            Student s = new ();
                            Console.WriteLine("enter student National Id :");
                            s.NationalId = Console.ReadLine()!;
                            Console.WriteLine("enter student name");
                            s.Name = Console.ReadLine()!;
                            Console.WriteLine("enter student Birth :");
                            Console.Write("enter the day :");
                            int day = int.Parse(Console.ReadLine()!);
                            Console.Write("enter the month :");
                            int month = int.Parse(Console.ReadLine()!);
                            Console.Write("enter the year :");
                            int year = int.Parse(Console.ReadLine()!);
                            s.BirthDate = new DateOnly(year, month, day);
                            Console.WriteLine("enter student Gender :");
                            s.Gender = Console.ReadLine()!;
                            Console.WriteLine("enter student Phone :");
                            s.Phone = Console.ReadLine()!;
                            Console.WriteLine("enter student Email :");
                            s.Email = Console.ReadLine()!;
                            Console.WriteLine("enter student Address :");
                            s.Address = Console.ReadLine()!;
                            stu.Add(s);
                            break;
                        }
                    break;

                }

            }
        
        }
    }
}
