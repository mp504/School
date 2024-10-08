using Microsoft.Data.SqlClient;
using School.people;
using School.People;
using School.RecordManage;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace School
{
    public partial class Form1 : Form
    {

        private int currentStudentId;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String SelectedValue = RoleSelection.SelectedItem.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainPanel.Visible = true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String User_name = UserName.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String Password_input = Password.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string user = UserName.Text;
            string pass = Password.Text;


            var role = RoleSelection?.SelectedItem?.ToString();



            switch (role)
            {

                case "Students ":
                    DataAccess checking = new DataAccess();

                    if (checking.check_student_id(user, pass))
                    {
                        Student student = new Student();
                           student =  student.check_student(user, pass);
                        RecordManagement recordManage = new RecordManagement();
                        DataTable table = recordManage.Retrieve_table(student.StudentID);

                        MainPanel.Visible = false;
                        StudentPanel.Visible = true;
                        SignUp_page.Visible = false;
                        TeacherPanel.Visible = false;
                        ParentPanel.Visible = false;
                        StudentID_stpage.Text = student.StudentID.ToString();
                        StudentCourses.ReadOnly = true;
                        StudentCourses.DataSource = table;

                        if (student.ParentID != null) ParentID_StPage.Text = student.ParentID.ToString();
                        StudentName_StPage.Text = student.FirstName.ToString() + " " + student.LastName.ToString();

                        Enrollement load = new Enrollement();

                        string id = StudentID_stpage.Text;
                        //add courses
                        int sID = int.Parse(id);
                        load.LoadCourses(SelectCourseName_st, sID);


                        //delete courses
                        load.LoadCourses_enrolled(DeleteCourse_st, sID);


                    }
                    else
                    {
                        MessageBox.Show("Invalid login for student.");
                    }
                    break;
                case "Parents":

                    Parent record = new Parent();

                    if (record.check_parent(user, pass))
                    {
                        Parent parent = record.parent(user, pass);
                        MainPanel.Visible = false;
                        StudentPanel.Visible = false;
                        SignUp_page.Visible = false;
                        ParentPanel.Visible = true;
                        TeacherPanel.Visible = false;

                        ParentID.Text = parent.Id.ToString();
                        ParentName.Text = parent.FName.ToString() + " " + parent.LName.ToString();
                        DataTable table = parent.childs(parent.Id);
                        ChildsTable.ReadOnly = true;
                        ChildsTable.DataSource = table;










                    }
                    else
                    {
                        MessageBox.Show("Invalid login for Parent.");
                    }
                    break;
                case "Teachers ":
                    Teacher check = new Teacher();
                    if (check.check_teacher_id(user, pass) != null)
                    {
                        Teacher teacher = check.check_teacher(user, pass);

                        MainPanel.Visible = false;
                        StudentPanel.Visible = false;
                        SignUp_page.Visible = false;
                        TeacherPanel.Visible = true;
                        ParentPanel.Visible = false;
                        TeacherID.Text = teacher.TeacherID.ToString();
                        TeacherName.Text = teacher.FirstName.ToString() + " " + teacher.LastName.ToString();

                        //load enrolled courses for teacher
                        DataTable table = check.enrolledCourese(teacher.TeacherID.ToString());
                        TeacherCourses.ReadOnly = true;
                        TeacherCourses.DataSource = table;

                        check.LoadCourses_enrolled(T_coursesNames, teacher.TeacherID);
                        check.LoadCourses_enrolled(selectCourse, teacher.TeacherID);







                    }
                    else
                    {
                        MessageBox.Show("Invalid login for Teacher.");
                    }
                    break;
                default:
                    MessageBox.Show("Choose a role");
                    break;



            }

        }

        private void SignUp_Click(object sender, EventArgs e)
        {


            String role = RoleSelection.Text;
            DataAccess checking = new DataAccess();


            MainPanel.Visible = false;
            StudentPanel.Visible = false;
            SignUp_page.Visible = true;
            TeacherPanel.Visible = false;
            ParentPanel.Visible = false;
            StudentCourses.DataSource = null;






        }

        private void SignUp_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentSignupPanel.Visible = false;
            string role = SignUp_role.SelectedItem.ToString();


            switch (role)
            {

                case "Students":
                    StudentSignupPanel.Visible = true;

                    break;
                case "Parents":
                    StudentSignupPanel.Visible = true;
                    break;
                case "Teachers":
                    StudentSignupPanel.Visible = true;
                    break;

                default:
                    break;




            }
        }

        private void SignUpStudent_Click(object sender, EventArgs e)
        {


            string role = SignUp_role.SelectedItem.ToString();
            DataAccess inserting = new DataAccess();
            string tablename;
            var data = new Dictionary<string, object>();
            string username;
            string fname;
            string lname;
            string password;

            switch (role)
            {
                case "Students":
                    username = SignUp_username.Text;
                    password = Signup_password.Text;
                    fname = FirstName.Text;
                    lname = LastName.Text;

                    data.Add("Username", username);
                    data.Add("PasswordHash", password);
                    data.Add("FirstName", fname);
                    data.Add("LastName", lname);


                    break;
                case "Parents":
                    username = SignUp_username.Text;
                    password = Signup_password.Text;
                    fname = FirstName.Text;
                    lname = LastName.Text;

                    data.Add("Username", username);
                    data.Add("PasswordHash", password);
                    data.Add("FirstName", fname);
                    data.Add("LastName", lname);

                    break;
                case "Teachers":
                    username = SignUp_username.Text;
                    password = Signup_password.Text;
                    fname = FirstName.Text;
                    lname = LastName.Text;

                    data.Add("Username", username);
                    data.Add("PasswordHash", password);
                    data.Add("FirstName", fname);
                    data.Add("LastName", lname);
                    break;

                default:
                    MessageBox.Show("select a role");
                    break;


            }

            using (SqlConnection cnn = inserting.connect_to_SQL())
            {
                inserting.insert_record(cnn, role, data);

                MessageBox.Show("User added!");
                MainPanel.Visible = true;
            }


        }

        private void SignupParentsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ParentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TeacherPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void StudentPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void SignUp_page_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }




        private void TeacherCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TeacherCourses_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

            string ID = StudentID_stpage.Text;
            int sID = int.Parse(ID);
            Enrollement enroll = new Enrollement();
            enroll.LoadCourses_enrolled(DeleteCourse_st, sID);


        }

        private void DeleteCourse_st_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeleteCourse_st.DataSource != null)
            {
                if (DeleteCourse_st.SelectedValue is DataRowView selectedRow)
                {
                    int selected = Convert.ToInt32(selectedRow["CourseID"]);
                    CourseID_Delete_St.Text = selected.ToString();
                }
                else
                {
                    int selected = (int)DeleteCourse_st.SelectedValue;
                    CourseID_Delete_St.Text = selected.ToString();

                }
            }
        }

        private void SelectCourseName_st_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (SelectCourseName_st.DataSource != null)
            {
                if (SelectCourseName_st.SelectedValue is DataRowView selectedRow)
                {
                    int selected = Convert.ToInt32(selectedRow["CourseID"]);
                    ST_displayCourseID.Text = selected.ToString();
                }
                else
                {
                    int selected = (int)SelectCourseName_st.SelectedValue;
                    ST_displayCourseID.Text = selected.ToString();

                }
            }
        }

        private void ST_displayCourseID_Click(object sender, EventArgs e)
        {

        }

        private void AddCourse_Click_1(object sender, EventArgs e)
        {
            Enrollement enrollement = new Enrollement();
            string id = StudentID_stpage.Text;
            int sID = int.Parse(id);
            string cID_int = ST_displayCourseID.Text;
            int cID = int.Parse(cID_int);

            enrollement.Add_course(sID, cID);
            RecordManagement recordManage = new RecordManagement();
            DataTable table = recordManage.Retrieve_table(sID);
            StudentCourses.ReadOnly = true;
            StudentCourses.DataSource = table;


        }

        private void CourseID_Delete_St_Click(object sender, EventArgs e)
        {

        }

        private void St_deleteCourse_Click(object sender, EventArgs e)
        {
            Enrollement enrollement = new Enrollement();
            string id = StudentID_stpage.Text;
            int sID = int.Parse(id);
            string cID_int = CourseID_Delete_St.Text;
            int cID = int.Parse(cID_int);

            enrollement.deleteCourse(sID, cID);
            RecordManagement recordManage = new RecordManagement();
            DataTable table = recordManage.Retrieve_table(sID);
            StudentCourses.ReadOnly = true;
            StudentCourses.DataSource = table;
        }

        private void AddCourse_T_Click(object sender, EventArgs e)
        {
            if (T_Addcourse.Text != null)
            {
                Teacher add = new Teacher();
                string tID_s = TeacherID.Text;
                int tID = int.Parse(tID_s);
                string cName = T_Addcourse.Text;
                add.add_course(tID, cName);

                DataTable table = add.enrolledCourese(tID_s);
                TeacherCourses.ReadOnly = true;
                TeacherCourses.DataSource = table;
            }
        }

        private void T_coursesNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T_coursesNames.SelectedValue is DataRowView selectedRow)
            {
                int selected = Convert.ToInt32(selectedRow["CourseID"]);
                CourseID.Text = selected.ToString();
            }
            else
            {
                int selected = (int)T_coursesNames.SelectedValue;
                CourseID.Text = selected.ToString();

            }
        }

        private void T_unEnrollButton_Click(object sender, EventArgs e)
        {
            Teacher del = new Teacher();

            string id = TeacherID.Text;
            int tID = int.Parse(id);
            string cID_int = CourseID.Text;
            int cID = int.Parse(cID_int);
            del.deleteCourse(tID, cID);

            del.LoadCourses_enrolled(T_coursesNames, tID);

            DataTable table = del.enrolledCourese(id);
            TeacherCourses.ReadOnly = true;
            TeacherCourses.DataSource = table;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void selectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = 0;
            Teacher check = new Teacher();
            if (selectCourse.SelectedValue is DataRowView selectedRow)
            {
                selected = Convert.ToInt32(selectedRow["CourseID"]);
                //CourseID.Text = selected.ToString();
            }
            else
            {
                selected = (int)selectCourse.SelectedValue;
                //CourseID.Text= selected.ToString();

            }
            DataTable sTable = check.GetStudentsEnrolledInCourse(selected);
            studentTable.ReadOnly = true;
            studentTable.DataSource = sTable;


        }

        private void SSignOut_Click(object sender, EventArgs e)
        {
            ResetApp();

        }

        private void TSignOut_Click(object sender, EventArgs e)
        {
            ResetApp();

        }

        private void ResetApp()
        {
            UserName.Text = string.Empty;
            Password.Text = string.Empty;
            T_coursesNames.DataSource = null;
            selectCourse.DataSource = null;
            T_coursesNames.Items.Clear();
            selectCourse.Items.Clear();
            studentTable.DataSource = null;
            MainPanel.Visible = true;
            ChildsTable.DataSource = null;
            SignUp_username.Text = string.Empty;
            Signup_password.Text = string.Empty;
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            StudentCourses.DataSource = null;
            SelectCourseName_st.DataSource = null;
            SelectCourseName_st.Items.Clear();
            DeleteCourse_st.DataSource = null;
            DeleteCourse_st.Items.Clear();
        }

        private void PSignOut_Click(object sender, EventArgs e)
        {
            ResetApp();
        }

        private void SearchChild_Click(object sender, EventArgs e)
        {
            string id = ChildID.Text;
            int sID = int.Parse(id);
            Student student = new Student();
            Student child = student.checkChild(sID);

            if (child != null)
            {
                ChildName.Text = child.FirstName.ToString() + " " + child.LastName.ToString();

            }

        }

        private void AddChild_Click(object sender, EventArgs e)
        {
            string id = ChildID.Text;
            int sID = int.Parse(id);
            string pID = ParentID.Text;
            int parentID = int.Parse(pID);
            Parent parent = new Parent();
            parent.updateStudent(parentID, sID);

        }
    }
}
