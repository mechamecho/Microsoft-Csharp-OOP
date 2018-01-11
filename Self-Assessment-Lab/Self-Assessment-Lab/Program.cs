using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Self_Assessment_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new UProgram("Information Technology");
            program.Degree= new Degree(DegreeType.Bachelor);
            program.Degree.AddCourse(new Course("Programming with C#", 4));
            program.Degree.Courses[0].RegisterStudent(new Student("Nafissa Hassan", 2030));
            program.Degree.Courses[0].RegisterStudent(new Student("Louis Caballer", 3040));
            program.Degree.Courses[0].RegisterStudent(new Student("Arnell Millhouse", 2030));

            Console.WriteLine($"The name of the program is {program.ProgramName} " +
                              $"and it contains a {program.Degree.TypeOfDegree} degree");
            Console.WriteLine($"The Course in the {program.ProgramName} is " +
                              $"{program.Degree.Courses[0].CourseName}");
            Console.WriteLine($"The number of students in this course is {program.Degree.Courses[0].NumberOfStudents}");
        }
    }
}
