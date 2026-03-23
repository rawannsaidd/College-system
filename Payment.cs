
namespace College_system
{
    public enum PaymentStatus { Pending, Paid, Refunded } // لسه مدفعش \ دفع \ مسترد
    internal class Payment
    {
        static int _counter = 1;
        public string? PaymentID {  get; private set; }
        public string? StudentID { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; private set; }
        public string? CoursID { get; set; }
        public PaymentStatus Status { get; set; }
        public Payment(string studentId, double amount, string? coursId = null)
        {
            PaymentID = $"PAY{_counter++}";
            StudentID = studentId;
            Amount = amount;
            PaymentDate = DateTime.Now;
            CoursID = coursId;
            Status = PaymentStatus.Pending;
        }
        public void Display()
        {
            Console.Write($"Payment ID : {PaymentID}\nStudent ID : {StudentID}\n Amount : {Amount}\n Payment Date : {PaymentDate}\nCourse ID : {CoursID}\nStatus : {Status}");
        }
    }
}
