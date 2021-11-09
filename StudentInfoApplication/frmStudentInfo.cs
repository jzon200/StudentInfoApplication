using System;
using System.Windows.Forms;
using System.Collections;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        ArrayList studentInfos = new ArrayList();
        public frmStudentInfo()
        {
            InitializeComponent();
            studentInfos.Add(new StudentInfo("200091005", "Jack", "Paul"));
            studentInfos.Add(new StudentInfo("20190035", "Rico", "Reyes"));
            studentInfos.Add(new StudentInfo("20181002", "Cristina", "Cruz"));
            studentInfos.Add(new StudentInfo("20191302", "Katherine", "Castro"));
            foreach (StudentInfo studentInfo in studentInfos)
            {
                lbxStudentIDList.Items.Add(studentInfo.StudentId);
                lbxFnameList.Items.Add(studentInfo.FirstName);
                lbxLnameList.Items.Add(studentInfo.LastName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo(txtbxStudentID.Text, txtbxFname.Text, txtbxLname.Text);
            lbxStudentIDList.Items.Add(studentInfo.StudentId);
            lbxFnameList.Items.Add(studentInfo.FirstName);
            lbxLnameList.Items.Add(studentInfo.LastName);
            studentInfos.Add(studentInfo);
        }
    }
    class StudentInfo
    {
        private string studentId, lastName, firstName;
        public StudentInfo()
        {
            this.studentId = "";
            this.firstName = "";
            this.lastName = "";
        }
        public StudentInfo(string studentId, string firstName, string lastName)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public String StudentId
        {
            get
            {
                return this.studentId;
            }
            set
            {
                this.studentId = value;
            }
        }
        public String LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public String FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
    }
}
