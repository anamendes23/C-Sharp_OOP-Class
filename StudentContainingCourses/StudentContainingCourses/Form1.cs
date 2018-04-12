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
    public partial class Form1 : Form
    {
        //************************GLOBAL VARIABLES*******************************
        internal static List<Student> students = new List<Student>();
        internal static List<Course> courses = new List<Course>();
        internal static int index = 0;
        internal static bool eventControler = false;
        //*****************************FORM1()***********************************
        public Form1()
        {
            InitializeComponent();
            PrePopulateStudentList();
            DisplayStudentList();
        }
        //*****************************FORM1_LOAD********************************
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCourses();
        }
        //*****************************METHODS***********************************
        private void PrePopulateStudentList()
        {
            //courses
            Course c1 = new Course("Visual C#", "CSI-154", "Lhoucine",
                                    new DateTime(2018, 04, 03), new DateTime(2018, 06, 23),
                                    7);
            Course c2 = new Course("DataBase", "CSI-156", "Tim",
                                    new DateTime(2018, 04, 03), new DateTime(2018, 06, 23),
                                    7);
            Course c3 = new Course("Web Graphics", "CSI-144", "Christy",
                                    new DateTime(2018, 04, 03), new DateTime(2018, 06, 23),
                                    7);
            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);
            //create few students and add few courses to each student
            Student s1 = new Student("Ana", "Banana", "809258083");
            Student s2 = new Student("Cornell", "AwesomeSauce", "809258082");
            Student s3 = new Student("Rob", "Bolt", "809258081");
            Student s4 = new Student("Kris", "Robinson", "809258080");
            Student s5 = new Student("Eric", "Lion", "809258079");

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            //Add courses to students
            foreach (Student s in students)
            {
                foreach (Course c in courses)
                {
                    s.AddCourse(c);
                }
            }
        }
        private void DisplayStudentList()
        {
            //clear the ListView
            listView1.Items.Clear();

            foreach (Student s in students)
            {
                //a ListView is a collection of rows
                //each row is considered a ListViewItem object
                //create a ListViewItem object and fill in all the values you
                //want in each column for that particular row
                Course[] c = s.CourseList;
                string[] items = { s.ID, s.FirstName, s.LastName, c[0].CourseName};
                ListViewItem lvi = new ListViewItem(items);
                //add this row to the ListView1
                listView1.Items.Add(lvi);
            }
        }
        private void PopulateCourses()
        {
            //courses
            Course c1 = new Course("Intro to Programming", "CSI-152", "Mohammed",
                                    new DateTime(2018, 04, 03), new DateTime(2018, 06, 23),
                                    7);
            Course c2 = new Course("Microsoft Office", "CSI-130", "Glenda",
                                    new DateTime(2018, 04, 03), new DateTime(2018, 06, 23),
                                    7);
            Course c3 = new Course("Web Design", "CSI-142", "Christy",
                                    new DateTime(2018, 04, 03), new DateTime(2018, 06, 23),
                                    7);
            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);
        }
        //*****************************EVENTS************************************
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            if (listView1.SelectedItems.Count > 0)
            {
                eventControler = false;
                //get index from selected item
                index = listView1.SelectedIndices[0];
                //create new form
                StudentsCourses _formCourses = new StudentsCourses();                
                _formCourses.ShowDialog();
                _formCourses.Dispose();
            }                 
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //create student
            Student s = new Student(txtFName.Text, txtLName.Text,
                                    txtID.Text);
            students.Add(s);
            //add courses to this student
            eventControler = true;
            //get index from last student in list
            index = students.Count - 1;
            //create new form
            StudentsCourses _formCourses = new StudentsCourses();
            _formCourses.ShowDialog();
            _formCourses.Dispose();
            //refresh student list
            DisplayStudentList();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //get index from selected item
                index = listView1.SelectedIndices[0];
                //remove student
                students.RemoveAt(index);
                //refresh student list
                DisplayStudentList();
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                eventControler = true;
                //get index from selected item
                index = listView1.SelectedIndices[0];
                //create new form
                StudentsCourses _formCourses = new StudentsCourses();
                _formCourses.ShowDialog();
                _formCourses.Dispose();
            }
            else
                MessageBox.Show("Select a student");
        }
    }
}
///create new student
///add new course to a student
///remove a course by student
///display all the students
///display courses of a student
///
///Complete:
///Add 4 more students with courses to the list
///Add a second ListView to display courses
///(courseName, courseNumber, instructor, credits, startDate, endDate)
