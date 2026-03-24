using System.Security.Cryptography.X509Certificates;

namespace College_system
{
    internal class Grade
    {
            public string EnrollmentId { get; set; }
            double _midterm;
            double _final;
            double _practical;

            public Grade(string enrollmentId, double midterm, double final, double practical)
            {
                EnrollmentId = enrollmentId;
                Midterm = midterm;
                Final = final;
                Practical = practical;
            }
            public double Midterm
            {
                get { return _midterm; }
                set
                {
                    if (value < 0 || value > 30)
                        throw new ArgumentException("Midterm grade is incorrect!");
                    _midterm = value;
                }
            }
            public double Final
            {
                get { return _final; }
                set
                {
                    if (value < 0 || value > 50)
                        throw new ArgumentException("final grade is incorrect!");
                    _final = value;
                }
            }
            public double Practical
            {
                get { return _practical; }
                set
                {
                    if (value < 0 || value > 20)
                        throw new ArgumentException("Practical grade is incorrect!");
                    _practical = value;
                }
            }
            public double Total => Midterm + Final + Practical;
            public string LetterGrade => Total switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
            public void Display()
            {
                Console.WriteLine($"Enrollment ID : {EnrollmentId}\nMidterm : {Midterm}\nFinal : {Final}\nPractical : {Practical}\nTotal : {Total}\nGrade : {LetterGrade}");
            }
        }
    }



