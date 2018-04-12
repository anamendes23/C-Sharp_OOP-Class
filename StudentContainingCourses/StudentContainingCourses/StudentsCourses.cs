using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentContainingCourses
{
    public partial class StudentsCourses : Form
    {
        //************************GLOBAL VARIABLES*******************************
        int index = 0;
        //array control (maximum number of courses possible)
        Course[] control = new Course[Form1.courses.Count];
        //position control
        int position = 0;
        //*****************************FORM1()***********************************
        public StudentsCourses()
        {
            InitializeComponent();            
        }
        //*****************************FORM1_LOAD********************************
        private void StudentsCourses_Load(object sender, EventArgs e)
        {
            index = Form1.index;
            if (Form1.eventControler)
            {
                DisplayListOfCouses();
                btnGeneric.Text = "Add Course to Selected Student";
            }
            else
            {
                DisplayCourses(index);
                btnGeneric.Text = "Remove Selected Course";
            }            
        }
        //*****************************METHODS***********************************
        private void DisplayCourses(int index)
        {
            //clear listview
            listView1.Items.Clear();
            //string to hold items in row
            string[] items;
            //get courseList from selected student
            Course[] courseList = Form1.students[index].CourseList;
            ListViewItem lvi;
            foreach (Course c in courseList)
            {
                items = new string[]{ c.CourseName, c.CourseNumber, c.Instructor, c.Credits.ToString(),
                          c.StartDate.ToShortDateString(), c.EndDate.ToShortDateString()};
                lvi = new ListViewItem(items);
                listView1.Items.Add(lvi);
            }
        }
        private void DisplayListOfCouses()
        {
            //clear listview
            listView1.Items.Clear();
            //string to hold items in row
            string[] items;
            Course[] studentCourses = Form1.students[index].CourseList;
            ListViewItem lvi;
            foreach (Course c in Form1.courses)
            {
                //counter control
                int counter = 0;
                foreach (Course sc in studentCourses)
                {
                    //check if student is already enrolled in course
                    //if true, course is not displayed on list
                    if (c.CourseNumber == sc.CourseNumber)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    control[position] = c;
                    position++;
                    items = new string[]{ c.CourseName, c.CourseNumber, c.Instructor, c.Credits.ToString(),
                          c.StartDate.ToShortDateString(), c.EndDate.ToShortDateString()};
                    lvi = new ListViewItem(items);
                    listView1.Items.Add(lvi);
                }
            }                
        }
        //*****************************EVENTS************************************
        private void btnGeneric_Click(object sender, EventArgs e)
        {
            //index for selected course
            int cIndex = listView1.SelectedIndices[0];
            //add course to student
            if (Form1.eventControler)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    //add selected course to selected student
                    Form1.students[index].AddCourse(control[cIndex]);
                    //close form
                    Close();
                }
            }
            //remove course from student
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    //get string course
                    Course[] courses = Form1.students[index].CourseList;
                    //get course number
                    string courseNumber = courses[cIndex].CourseNumber;
                    //call method to remove course from student
                    Form1.students[index].DropCourse(courseNumber);
                    //refresh course list
                    DisplayCourses(index);
                }
            }
        }
    }
}
