
namespace College_system
{
    internal class Doctor : Employee
    {
        public List<Course>? Courses { get; set; }
        public List<Department>? Departments { get; set; }
        public string? Specialty { get; set; }
        public Doctor()
        {
            ID = $"DR{_counter++}";
        }
        public Doctor(string nationalId, string name, DateOnly birthDate, Gender gender, string phone, string email, string address, double salary, string jobTitle, DateOnly hireDate, string specialty) : base(nationalId, name, birthDate, gender, phone, email, address,salary, jobTitle, hireDate)
        {
            Specialty = specialty;
            Courses = [];     
            Departments = []; 
            ID = $"DR{_counter++}";
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Specialty: {Specialty}");

            if (Departments != null && Departments.Any()) // لو القسم موجود وفيه مواد
            {
                Console.WriteLine("Departments:");
                foreach (var dept in Departments)
                {
                    Console.WriteLine($"- {dept.Name}"); // المواد اللي الدكتور بيدرسها في القسم ده بس
                    var deptCourses = Courses?
                        .Where(c => c.Department?.Name == dept.Name)
                        .ToList();
                    if (deptCourses != null && deptCourses.Any())
                    {
                        Console.WriteLine("-- Courses:");
                        deptCourses.ForEach(c => Console.WriteLine($"   * {c.Name}"));
                    }
                }
            }
        }
    }
}
