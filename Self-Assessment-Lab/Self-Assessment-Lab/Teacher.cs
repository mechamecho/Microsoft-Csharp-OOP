using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab
{
    public class Teacher
    {
        private string _fullName;
        private int _numberOfCourses;

        public Course[] Courses { get; }

        public string FullName
        {
            get => _fullName;
            set
            {
                if(value!=null)
                _fullName = value;
            }

        }

        public Teacher(string fullName)
        {
            FullName = fullName;
            Courses= new Course[5];
            _numberOfCourses = 0;
        }

        public void AssignToCourse(Course course)
        {
            Courses[_numberOfCourses] = course;
            _numberOfCourses++;
        }
    }
}
