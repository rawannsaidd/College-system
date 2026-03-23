
namespace College_system
{
    public enum EnrollmentStatus { Active, Dropped, Banned }
    public enum Semester { Fall, Spring, Summer }
    internal class Enrollment
    {
        static int _counter = 1;
        public string? ID { get;  set; }
        public string? StudentId { get; set; } 
        public string? CourseId { get; set; }
        public int Year { get; set; }
        public Semester Semester{ get; set; }
        public EnrollmentStatus Status { get; set; }
        public double Grade { get; set; }
        public Enrollment()
        {
            ID = $"ENR{_counter++}";
            StudentId = string.Empty;
            CourseId = string.Empty;
            Year = DateTime.Now.Year;
            Semester = Semester.Fall;
        }
        public Enrollment(string studentId, string courseId, int year, Semester semester)
        {
            ID = $"ENR{_counter++}";
            StudentId = studentId;
            CourseId = courseId;
            Year = year;
            Semester = semester;
            Status = EnrollmentStatus.Active;
            Grade = 0.0;
        }
        public void DisplayInfo() =>  Console.WriteLine($"Enrollment ID: {ID}\nStudent ID: {StudentId}\nCourse ID: {CourseId}\nYear: {Year}\nSemester: {Semester}\nStatus: {Status}\nGrade: {Grade}");
    }
}
