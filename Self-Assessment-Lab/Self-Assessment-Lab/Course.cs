namespace Self_Assessment_Lab
{
    public class Course
    {
        //fields
        private string _courseName;
        private int _credits;
        private Student[] _students;

        //Properties
        public string CourseName
        {
            get => _courseName;
            set
            {
                if (value != null)
                    _courseName = value;
            }
        }

        public int Credits
        {
            get => _credits;
            set
            {
                if (value != 0)
                    _credits = value;
            }
        }

        public Student[] Students
        {
            get { return _students; }
        }

        public int NumberOfStudents { get; set; }


        public Course(string courseName, int credits)
        {
            _students = new Student[30];
            CourseName = courseName;
            Credits = credits;
        }

        public void RegisterStudent(Student student)
        {
            _students[NumberOfStudents] = student;
            NumberOfStudents++;

        }


    }
}
