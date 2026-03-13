namespace College_system
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== College System ===\r\n1. Add Student\r\n2. Add Staff Member\r\n3. View All Students\r\n4. View All Staff Members\r\n5. Log Out");
            int choics;
            bool isConverted = int.TryParse(Console.ReadLine(),out choics);
            switch (choics)
            {
                case 1:
                    Console.Clear();
                    Student s = new Student();
                    Console.WriteLine("enter student National Id :");
                    s.NationalId = Console.ReadLine();
                    Console.WriteLine("enter student name");
                    s.Name = Console.ReadLine();
                    Console.WriteLine("enter student Birth Date(DD/MM/YY) :");
                    Console.Write("enter the day :");
                    int day = int.Parse(Console.ReadLine()!);
                    Console.Write("enter the month :");
                    int month = int.Parse(Console.ReadLine()!);
                    Console.Write("enter the year :");
                    int year = int.Parse(Console.ReadLine()!);

                    s.BirthDate = new DateOnly(year, month, day);
                    s.NationalId = Console.ReadLine();
                    s.NationalId = Console.ReadLine();
                    s.NationalId = Console.ReadLine();
                    s.NationalId = Console.ReadLine();
                    break;
                   
            }
            
            
            //Employee emp1 = new Employee();
            //emp1.NationalId = "33332311356347";
            //emp1.Name = "nana";
            //emp1.BirthDate = new DateOnly(2000,4,4);
            //emp1.Gender = "female";
            //emp1.Phone = "01090909092";
            //emp1.Email = "knkjk@gmail.com";
            //emp1.Address = "9 stwihwurifwirjirjfocjpoiporij";
            //emp1.Display();
        }
    }
}
