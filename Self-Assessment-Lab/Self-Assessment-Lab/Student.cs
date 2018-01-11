namespace Self_Assessment_Lab
{
    public class Student
    {
        public string Major { get; }
        public string Fullname { get; }
        public int StudentId { get; }

        public Student(string fullname, int studentId)
        {
            Fullname = fullname;
            StudentId = studentId;
        }

        public Student(string fullname, int studentId, string major)
            :this(fullname, studentId)
        {
            Major = major;
        }
    }
}
