namespace schoolmanagementsys.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public long? Mobile { get; set; }
        public string RollNo { get; set; }
        public string Address { get; set; }
        public int ClassId { get; set; }
    }
}
