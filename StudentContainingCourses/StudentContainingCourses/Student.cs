using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentContainingCourses
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private List<Course> _courseList = new List<Course>();

        //constructor
        public Student(string firstname, string lastName, string id)
        {
            _firstName = firstname;
            _lastName = lastName;
            _id = id;
        }
        //properties
        public string FirstName
        { get { return _firstName; } }
        public string LastName
        { get { return _lastName; } }
        public string ID
        { get { return _id; } }
        //return a copy (as an array) of the _courseList
        public Course[] CourseList
        { get { return _courseList.ToArray(); } }
        //methods
        public bool AddCourse(Course course)
        {
            //before adding this course, make sure there are enough seats
            //to access static fields, you have to call the class instead of the object
            if (course != null && Course._enrolled < Course._capacity)
            {
                //add course
                _courseList.Add(course);
                //increment _enrolled
                Course._enrolled++;
                return true;
            }
            else
                return false;
        }
        public void DropCourse(string courseNumber)
        {
            //get the course with the given courseNumber
            Course course = GetCourse(courseNumber);
            //remove from the _courseList, but check that it is not null
            if (course != null)
            {
                //remove from list
                _courseList.Remove(course);
                //decrement
                Course._enrolled--;
            }
        }
        //helper method
        private Course GetCourse(string courseNumber)
        {
            foreach (Course course in _courseList)
            {
                if(course.CourseNumber == courseNumber)
                {
                    return course;
                }
            }
            //not found
            return null;
        }
    }
}
