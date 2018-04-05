using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentContainingCourses
{
    public class Course
    {
        //private fields
        private string _courseName;
        private string _courseNumber;
        private string _instructor;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _credits;
        //static field to hold max number of students
        internal static int _capacity;
        internal static int _enrolled;
        //constructor
        public Course(string courseName, string courseNumber, string instructor,
                        DateTime startDate, DateTime endDate, int credits)
        {
            _courseName = courseName;
            _courseNumber = courseNumber;
            _instructor = instructor;
            _startDate = startDate;
            _endDate = endDate;
            _credits = credits;
        }
        //static constructor
        static Course()
        {
            _capacity = 20;
            _enrolled = 0;
        }
        //properties
        public string CourseName
        { get { return _courseName; } }
        public string CourseNumber
        { get { return _courseNumber; } }
        public string Instructor
        { get { return _instructor; } }
        public DateTime StartDate
        { get { return _startDate; } }
        public DateTime EndDate
        { get { return _endDate; } }
        public int Credits
        { get { return _credits; } }
    }
}
