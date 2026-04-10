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
            Console.Write("Gender (M/F): ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine() ?? string.Empty, true);
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine() ?? string.Empty;
            Console.Write("Email: ");
            string email = Console.ReadLine() ?? string.Empty;
            Console.Write("Address: ");
            string address = Console.ReadLine() ?? string.Empty;
            Console.Write("Enrollment Date (yyyy-MM-dd): ");
            DateOnly enrollmentDate = DateOnly.Parse(Console.ReadLine() ?? string.Empty);
            return new Student();
         
        }

        static void Main()
        {
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
                                case 1:
                         

                                break;
                            }

                        }


                    break;
                }

            }                           
        }  
    
    }
}
