namespace Self_Assessment_Lab
{
    public enum DegreeType
    {
        Bachelor,
        Master
    }
    public class Degree
    {
        private int _numberOfCourses;

        public DegreeType TypeOfDegree { get; set; }
        public Course[] Courses { get; }


        public Degree(DegreeType degreeType)
        {
            Courses= new Course[20];
            _numberOfCourses = 0;
            TypeOfDegree = degreeType;


        }
        public void AddCourse(Course course)
        {
            Courses[_numberOfCourses] = course;
            _numberOfCourses++;
        }

    }
}
