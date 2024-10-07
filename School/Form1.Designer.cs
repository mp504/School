namespace School
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            RoleSelection = new ComboBox();
            label1 = new Label();
            MainPanel = new Panel();
            label4 = new Label();
            SignUp = new Button();
            Login = new Button();
            label3 = new Label();
            label2 = new Label();
            Password = new TextBox();
            UserName = new TextBox();
            SignUp_page = new Panel();
            StudentSignupPanel = new Panel();
            SignUpStudent = new Button();
            LastName = new TextBox();
            FirstName = new TextBox();
            Signup_password = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            SignUp_username = new TextBox();
            label5 = new Label();
            SignUp_role = new ComboBox();
            signupLabel = new Label();
            Parent_Signup_panel = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox4 = new TextBox();
            StudentPanel = new Panel();
            St_AddCourse = new TabControl();
            tabPage3 = new TabPage();
            AddCourse = new Button();
            label20 = new Label();
            ST_displayCourseID = new Label();
            label19 = new Label();
            label18 = new Label();
            SelectCourseName_st = new ComboBox();
            tabPage4 = new TabPage();
            CourseID_Delete_St = new Label();
            label24 = new Label();
            label23 = new Label();
            DeleteCourse_st = new ComboBox();
            St_deleteCourse = new Button();
            StudentCourses = new DataGridView();
            ParentID_StPage = new Label();
            StudentName_StPage = new Label();
            StudentID_stpage = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            recordManageBindingSource = new BindingSource(components);
            ParentPanel = new Panel();
            TeacherPanel = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label28 = new Label();
            T_unEnrollButton = new Button();
            CourseID = new Label();
            label29 = new Label();
            label27 = new Label();
            T_coursesNames = new ComboBox();
            AddCourse_T = new Button();
            T_Addcourse = new TextBox();
            label26 = new Label();
            label25 = new Label();
            TeacherCourses = new DataGridView();
            tabPage2 = new TabPage();
            studentTable = new DataGridView();
            label30 = new Label();
            selectCourse = new ComboBox();
            TeacherName = new Label();
            label22 = new Label();
            TeacherID = new Label();
            label21 = new Label();
            MainPanel.SuspendLayout();
            SignUp_page.SuspendLayout();
            StudentSignupPanel.SuspendLayout();
            Parent_Signup_panel.SuspendLayout();
            StudentPanel.SuspendLayout();
            St_AddCourse.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recordManageBindingSource).BeginInit();
            TeacherPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherCourses).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentTable).BeginInit();
            SuspendLayout();
            // 
            // RoleSelection
            // 
            RoleSelection.AccessibleName = "RoleSelect";
            RoleSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleSelection.FormattingEnabled = true;
            RoleSelection.Items.AddRange(new object[] { "Teachers ", "Students ", "Parents" });
            RoleSelection.Location = new Point(67, 16);
            RoleSelection.Name = "RoleSelection";
            RoleSelection.Size = new Size(151, 28);
            RoleSelection.TabIndex = 0;
            RoleSelection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Role";
            label1.Click += label1_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ActiveBorder;
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(SignUp);
            MainPanel.Controls.Add(Login);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(Password);
            MainPanel.Controls.Add(UserName);
            MainPanel.Controls.Add(RoleSelection);
            MainPanel.Controls.Add(label1);
            MainPanel.Location = new Point(11, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(770, 427);
            MainPanel.TabIndex = 3;
            MainPanel.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 301);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 8;
            label4.Text = "If you don't have account";
            label4.Click += label4_Click;
            // 
            // SignUp
            // 
            SignUp.Location = new Point(67, 349);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(94, 29);
            SignUp.TabIndex = 7;
            SignUp.Text = "Sign Up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // Login
            // 
            Login.Location = new Point(67, 207);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 6;
            Login.Text = "Log in";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 159);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 107);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "User name";
            label2.Click += label2_Click;
            // 
            // Password
            // 
            Password.Location = new Point(98, 159);
            Password.Name = "Password";
            Password.Size = new Size(125, 27);
            Password.TabIndex = 3;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += textBox2_TextChanged;
            // 
            // UserName
            // 
            UserName.Location = new Point(98, 107);
            UserName.Name = "UserName";
            UserName.Size = new Size(125, 27);
            UserName.TabIndex = 2;
            UserName.TextChanged += textBox1_TextChanged;
            // 
            // SignUp_page
            // 
            SignUp_page.Controls.Add(StudentSignupPanel);
            SignUp_page.Controls.Add(label5);
            SignUp_page.Controls.Add(SignUp_role);
            SignUp_page.Controls.Add(signupLabel);
            SignUp_page.Controls.Add(Parent_Signup_panel);
            SignUp_page.Location = new Point(11, 12);
            SignUp_page.Name = "SignUp_page";
            SignUp_page.Size = new Size(776, 427);
            SignUp_page.TabIndex = 4;
            SignUp_page.Paint += SignUp_page_Paint;
            // 
            // StudentSignupPanel
            // 
            StudentSignupPanel.BackColor = SystemColors.ActiveCaption;
            StudentSignupPanel.Controls.Add(SignUpStudent);
            StudentSignupPanel.Controls.Add(LastName);
            StudentSignupPanel.Controls.Add(FirstName);
            StudentSignupPanel.Controls.Add(Signup_password);
            StudentSignupPanel.Controls.Add(label9);
            StudentSignupPanel.Controls.Add(label8);
            StudentSignupPanel.Controls.Add(label7);
            StudentSignupPanel.Controls.Add(label6);
            StudentSignupPanel.Controls.Add(SignUp_username);
            StudentSignupPanel.Location = new Point(13, 129);
            StudentSignupPanel.Name = "StudentSignupPanel";
            StudentSignupPanel.Size = new Size(747, 279);
            StudentSignupPanel.TabIndex = 2;
            StudentSignupPanel.Visible = false;
            // 
            // SignUpStudent
            // 
            SignUpStudent.Location = new Point(402, 116);
            SignUpStudent.Margin = new Padding(3, 4, 3, 4);
            SignUpStudent.Name = "SignUpStudent";
            SignUpStudent.Size = new Size(86, 31);
            SignUpStudent.TabIndex = 8;
            SignUpStudent.Text = "Sign UP";
            SignUpStudent.UseVisualStyleBackColor = true;
            SignUpStudent.Click += SignUpStudent_Click;
            // 
            // LastName
            // 
            LastName.Location = new Point(162, 185);
            LastName.Name = "LastName";
            LastName.Size = new Size(125, 27);
            LastName.TabIndex = 7;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(162, 133);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(125, 27);
            FirstName.TabIndex = 6;
            // 
            // Signup_password
            // 
            Signup_password.Location = new Point(162, 87);
            Signup_password.Name = "Signup_password";
            Signup_password.Size = new Size(125, 27);
            Signup_password.TabIndex = 5;
            Signup_password.Text = "Enter Password";
            Signup_password.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 192);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 4;
            label9.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 137);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 3;
            label8.Text = "First Name";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 91);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 2;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 45);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 1;
            label6.Text = "User Name";
            // 
            // SignUp_username
            // 
            SignUp_username.Location = new Point(162, 39);
            SignUp_username.Name = "SignUp_username";
            SignUp_username.Size = new Size(125, 27);
            SignUp_username.TabIndex = 0;
            SignUp_username.Text = "Enter UserName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 79);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 3;
            label5.Text = "Role";
            label5.Click += label5_Click_1;
            // 
            // SignUp_role
            // 
            SignUp_role.FormattingEnabled = true;
            SignUp_role.Items.AddRange(new object[] { "Students", "Parents", "Teachers" });
            SignUp_role.Location = new Point(273, 77);
            SignUp_role.Name = "SignUp_role";
            SignUp_role.Size = new Size(151, 28);
            SignUp_role.TabIndex = 1;
            SignUp_role.SelectedIndexChanged += SignUp_role_SelectedIndexChanged;
            // 
            // signupLabel
            // 
            signupLabel.AutoSize = true;
            signupLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupLabel.Location = new Point(256, 16);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(200, 38);
            signupLabel.TabIndex = 0;
            signupLabel.Text = "SIGN UP Page";
            signupLabel.Click += label5_Click;
            // 
            // Parent_Signup_panel
            // 
            Parent_Signup_panel.BackColor = SystemColors.ActiveCaption;
            Parent_Signup_panel.Controls.Add(textBox1);
            Parent_Signup_panel.Controls.Add(textBox2);
            Parent_Signup_panel.Controls.Add(textBox3);
            Parent_Signup_panel.Controls.Add(label10);
            Parent_Signup_panel.Controls.Add(label11);
            Parent_Signup_panel.Controls.Add(label12);
            Parent_Signup_panel.Controls.Add(label13);
            Parent_Signup_panel.Controls.Add(textBox4);
            Parent_Signup_panel.Location = new Point(13, 129);
            Parent_Signup_panel.Name = "Parent_Signup_panel";
            Parent_Signup_panel.Size = new Size(747, 279);
            Parent_Signup_panel.TabIndex = 8;
            Parent_Signup_panel.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(162, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            textBox3.Text = "Enter Password";
            textBox3.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 192);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 4;
            label10.Text = "Last Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(54, 137);
            label11.Name = "label11";
            label11.Size = new Size(80, 20);
            label11.TabIndex = 3;
            label11.Text = "First Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 91);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 2;
            label12.Text = "Password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(53, 45);
            label13.Name = "label13";
            label13.Size = new Size(82, 20);
            label13.TabIndex = 1;
            label13.Text = "User Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 0;
            textBox4.Text = "Enter UserName";
            // 
            // StudentPanel
            // 
            StudentPanel.BackColor = SystemColors.ButtonFace;
            StudentPanel.Controls.Add(St_AddCourse);
            StudentPanel.Controls.Add(StudentCourses);
            StudentPanel.Controls.Add(ParentID_StPage);
            StudentPanel.Controls.Add(StudentName_StPage);
            StudentPanel.Controls.Add(StudentID_stpage);
            StudentPanel.Controls.Add(label17);
            StudentPanel.Controls.Add(label16);
            StudentPanel.Controls.Add(label15);
            StudentPanel.Controls.Add(label14);
            StudentPanel.Location = new Point(11, 9);
            StudentPanel.Name = "StudentPanel";
            StudentPanel.Size = new Size(773, 427);
            StudentPanel.TabIndex = 9;
            StudentPanel.Paint += StudentPanel_Paint;
            // 
            // St_AddCourse
            // 
            St_AddCourse.Controls.Add(tabPage3);
            St_AddCourse.Controls.Add(tabPage4);
            St_AddCourse.Location = new Point(66, 252);
            St_AddCourse.Name = "St_AddCourse";
            St_AddCourse.SelectedIndex = 0;
            St_AddCourse.Size = new Size(672, 152);
            St_AddCourse.TabIndex = 11;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(AddCourse);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(ST_displayCourseID);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(SelectCourseName_st);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(664, 119);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Add";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(457, 80);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(94, 29);
            AddCourse.TabIndex = 22;
            AddCourse.Text = "Add";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click_1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(332, 59);
            label20.Name = "label20";
            label20.Size = new Size(73, 20);
            label20.TabIndex = 21;
            label20.Text = "Course ID";
            // 
            // ST_displayCourseID
            // 
            ST_displayCourseID.AutoSize = true;
            ST_displayCourseID.Location = new Point(351, 89);
            ST_displayCourseID.Name = "ST_displayCourseID";
            ST_displayCourseID.Size = new Size(17, 20);
            ST_displayCourseID.TabIndex = 20;
            ST_displayCourseID.Text = "0";
            ST_displayCourseID.Click += ST_displayCourseID_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(113, 4);
            label19.Name = "label19";
            label19.Size = new Size(219, 31);
            label19.TabIndex = 19;
            label19.Text = "Adding new course";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(138, 56);
            label18.Name = "label18";
            label18.Size = new Size(98, 20);
            label18.TabIndex = 18;
            label18.Text = "Course Name";
            // 
            // SelectCourseName_st
            // 
            SelectCourseName_st.FormattingEnabled = true;
            SelectCourseName_st.Location = new Point(113, 86);
            SelectCourseName_st.Name = "SelectCourseName_st";
            SelectCourseName_st.Size = new Size(151, 28);
            SelectCourseName_st.TabIndex = 17;
            SelectCourseName_st.SelectedIndexChanged += SelectCourseName_st_SelectedIndexChanged_1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(CourseID_Delete_St);
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(DeleteCourse_st);
            tabPage4.Controls.Add(St_deleteCourse);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(664, 119);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Delete";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // CourseID_Delete_St
            // 
            CourseID_Delete_St.AutoSize = true;
            CourseID_Delete_St.Location = new Point(310, 69);
            CourseID_Delete_St.Name = "CourseID_Delete_St";
            CourseID_Delete_St.Size = new Size(17, 20);
            CourseID_Delete_St.TabIndex = 4;
            CourseID_Delete_St.Text = "0";
            CourseID_Delete_St.Click += CourseID_Delete_St_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(292, 39);
            label24.Name = "label24";
            label24.Size = new Size(73, 20);
            label24.TabIndex = 3;
            label24.Text = "Course ID";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(55, 36);
            label23.Name = "label23";
            label23.Size = new Size(98, 20);
            label23.TabIndex = 2;
            label23.Text = "Course Name";
            // 
            // DeleteCourse_st
            // 
            DeleteCourse_st.FormattingEnabled = true;
            DeleteCourse_st.Location = new Point(41, 61);
            DeleteCourse_st.Name = "DeleteCourse_st";
            DeleteCourse_st.Size = new Size(151, 28);
            DeleteCourse_st.TabIndex = 1;
            DeleteCourse_st.SelectedIndexChanged += DeleteCourse_st_SelectedIndexChanged;
            // 
            // St_deleteCourse
            // 
            St_deleteCourse.Location = new Point(442, 60);
            St_deleteCourse.Name = "St_deleteCourse";
            St_deleteCourse.Size = new Size(94, 29);
            St_deleteCourse.TabIndex = 0;
            St_deleteCourse.Text = "Delete";
            St_deleteCourse.UseVisualStyleBackColor = true;
            St_deleteCourse.Click += St_deleteCourse_Click;
            // 
            // StudentCourses
            // 
            StudentCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentCourses.Location = new Point(256, 61);
            StudentCourses.Name = "StudentCourses";
            StudentCourses.RowHeadersWidth = 51;
            StudentCourses.Size = new Size(449, 185);
            StudentCourses.TabIndex = 10;
            // 
            // ParentID_StPage
            // 
            ParentID_StPage.AutoSize = true;
            ParentID_StPage.Location = new Point(30, 210);
            ParentID_StPage.Name = "ParentID_StPage";
            ParentID_StPage.Size = new Size(16, 20);
            ParentID_StPage.TabIndex = 9;
            ParentID_StPage.Text = "?";
            // 
            // StudentName_StPage
            // 
            StudentName_StPage.AutoSize = true;
            StudentName_StPage.Location = new Point(25, 130);
            StudentName_StPage.Name = "StudentName_StPage";
            StudentName_StPage.Size = new Size(16, 20);
            StudentName_StPage.TabIndex = 8;
            StudentName_StPage.Text = "?";
            // 
            // StudentID_stpage
            // 
            StudentID_stpage.AutoSize = true;
            StudentID_stpage.Location = new Point(30, 61);
            StudentID_stpage.Name = "StudentID_stpage";
            StudentID_stpage.Size = new Size(17, 20);
            StudentID_stpage.TabIndex = 7;
            StudentID_stpage.Text = "0";
            StudentID_stpage.Click += label26_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 162);
            label17.Name = "label17";
            label17.Size = new Size(50, 20);
            label17.TabIndex = 5;
            label17.Text = "Parent";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(13, 90);
            label16.Name = "label16";
            label16.Size = new Size(104, 20);
            label16.TabIndex = 4;
            label16.Text = "Student name:";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 19);
            label15.Name = "label15";
            label15.Size = new Size(82, 20);
            label15.TabIndex = 3;
            label15.Text = "Student ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(327, 11);
            label14.Name = "label14";
            label14.Size = new Size(312, 31);
            label14.TabIndex = 2;
            label14.Text = "Enrolled Courses by student";
            label14.Click += label14_Click;
            // 
            // recordManageBindingSource
            // 
            recordManageBindingSource.DataSource = typeof(RecordManage);
            // 
            // ParentPanel
            // 
            ParentPanel.BackColor = SystemColors.ActiveCaption;
            ParentPanel.Location = new Point(11, 9);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(777, 430);
            ParentPanel.TabIndex = 10;
            // 
            // TeacherPanel
            // 
            TeacherPanel.Controls.Add(tabControl1);
            TeacherPanel.Controls.Add(TeacherName);
            TeacherPanel.Controls.Add(label22);
            TeacherPanel.Controls.Add(TeacherID);
            TeacherPanel.Controls.Add(label21);
            TeacherPanel.Location = new Point(11, 9);
            TeacherPanel.Name = "TeacherPanel";
            TeacherPanel.Size = new Size(777, 430);
            TeacherPanel.TabIndex = 11;
            TeacherPanel.Paint += TeacherPanel_Paint;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(195, 13);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(572, 398);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label28);
            tabPage1.Controls.Add(T_unEnrollButton);
            tabPage1.Controls.Add(CourseID);
            tabPage1.Controls.Add(label29);
            tabPage1.Controls.Add(label27);
            tabPage1.Controls.Add(T_coursesNames);
            tabPage1.Controls.Add(AddCourse_T);
            tabPage1.Controls.Add(T_Addcourse);
            tabPage1.Controls.Add(label26);
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(TeacherCourses);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(564, 365);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Courses";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(46, 239);
            label28.Name = "label28";
            label28.Size = new Size(256, 31);
            label28.TabIndex = 15;
            label28.Text = "Disenroll from courses";
            // 
            // T_unEnrollButton
            // 
            T_unEnrollButton.Location = new Point(371, 317);
            T_unEnrollButton.Name = "T_unEnrollButton";
            T_unEnrollButton.Size = new Size(94, 29);
            T_unEnrollButton.TabIndex = 14;
            T_unEnrollButton.Text = "Rule out";
            T_unEnrollButton.UseVisualStyleBackColor = true;
            T_unEnrollButton.Click += T_unEnrollButton_Click;
            // 
            // CourseID
            // 
            CourseID.AutoSize = true;
            CourseID.Location = new Point(255, 326);
            CourseID.Name = "CourseID";
            CourseID.Size = new Size(16, 20);
            CourseID.TabIndex = 13;
            CourseID.Text = "?";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(229, 295);
            label29.Name = "label29";
            label29.Size = new Size(73, 20);
            label29.TabIndex = 12;
            label29.Text = "Course ID";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(37, 295);
            label27.Name = "label27";
            label27.Size = new Size(98, 20);
            label27.TabIndex = 11;
            label27.Text = "Course Name";
            // 
            // T_coursesNames
            // 
            T_coursesNames.FormattingEnabled = true;
            T_coursesNames.Location = new Point(37, 320);
            T_coursesNames.Name = "T_coursesNames";
            T_coursesNames.Size = new Size(151, 28);
            T_coursesNames.TabIndex = 10;
            T_coursesNames.SelectedIndexChanged += T_coursesNames_SelectedIndexChanged;
            // 
            // AddCourse_T
            // 
            AddCourse_T.Location = new Point(400, 159);
            AddCourse_T.Name = "AddCourse_T";
            AddCourse_T.Size = new Size(94, 29);
            AddCourse_T.TabIndex = 9;
            AddCourse_T.Text = "Add Course";
            AddCourse_T.UseVisualStyleBackColor = true;
            AddCourse_T.Click += AddCourse_T_Click;
            // 
            // T_Addcourse
            // 
            T_Addcourse.Location = new Point(381, 113);
            T_Addcourse.Name = "T_Addcourse";
            T_Addcourse.Size = new Size(125, 27);
            T_Addcourse.TabIndex = 8;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(386, 32);
            label26.Name = "label26";
            label26.Size = new Size(137, 31);
            label26.TabIndex = 7;
            label26.Text = "Add Course";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(396, 90);
            label25.Name = "label25";
            label25.Size = new Size(98, 20);
            label25.TabIndex = 6;
            label25.Text = "Course Name";
            // 
            // TeacherCourses
            // 
            TeacherCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherCourses.Location = new Point(15, 14);
            TeacherCourses.Name = "TeacherCourses";
            TeacherCourses.RowHeadersWidth = 51;
            TeacherCourses.Size = new Size(300, 188);
            TeacherCourses.TabIndex = 5;
            TeacherCourses.CellContentClick += TeacherCourses_CellContentClick_1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(studentTable);
            tabPage2.Controls.Add(label30);
            tabPage2.Controls.Add(selectCourse);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(564, 365);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Students";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // studentTable
            // 
            studentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentTable.Location = new Point(9, 93);
            studentTable.Name = "studentTable";
            studentTable.RowHeadersWidth = 51;
            studentTable.Size = new Size(453, 188);
            studentTable.TabIndex = 2;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(9, 19);
            label30.Name = "label30";
            label30.Size = new Size(98, 20);
            label30.TabIndex = 1;
            label30.Text = "Select Course";
            // 
            // selectCourse
            // 
            selectCourse.FormattingEnabled = true;
            selectCourse.Location = new Point(6, 45);
            selectCourse.Name = "selectCourse";
            selectCourse.Size = new Size(151, 28);
            selectCourse.TabIndex = 0;
            selectCourse.SelectedIndexChanged += selectCourse_SelectedIndexChanged;
            // 
            // TeacherName
            // 
            TeacherName.AutoSize = true;
            TeacherName.Location = new Point(25, 130);
            TeacherName.Name = "TeacherName";
            TeacherName.Size = new Size(16, 20);
            TeacherName.TabIndex = 3;
            TeacherName.Text = "?";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(13, 90);
            label22.Name = "label22";
            label22.Size = new Size(104, 20);
            label22.TabIndex = 2;
            label22.Text = "Teacher Name";
            // 
            // TeacherID
            // 
            TeacherID.AutoSize = true;
            TeacherID.Location = new Point(50, 56);
            TeacherID.Name = "TeacherID";
            TeacherID.Size = new Size(16, 20);
            TeacherID.TabIndex = 1;
            TeacherID.Text = "?";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(28, 20);
            label21.Name = "label21";
            label21.Size = new Size(79, 20);
            label21.TabIndex = 0;
            label21.Text = "Teacher ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(MainPanel);
            Controls.Add(TeacherPanel);
            Controls.Add(ParentPanel);
            Controls.Add(SignUp_page);
            Controls.Add(StudentPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            SignUp_page.ResumeLayout(false);
            SignUp_page.PerformLayout();
            StudentSignupPanel.ResumeLayout(false);
            StudentSignupPanel.PerformLayout();
            Parent_Signup_panel.ResumeLayout(false);
            Parent_Signup_panel.PerformLayout();
            StudentPanel.ResumeLayout(false);
            StudentPanel.PerformLayout();
            St_AddCourse.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)recordManageBindingSource).EndInit();
            TeacherPanel.ResumeLayout(false);
            TeacherPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherCourses).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox RoleSelection;
        private Label label1;
        private Panel MainPanel;
        private Label label2;
        private TextBox Password;
        private TextBox UserName;
        private Label label3;
        private Button SignUp;
        private Button Login;
        private Label label4;
        private Panel SignUp_page;
        private Label signupLabel;
        private Panel StudentSignupPanel;
        private ComboBox SignUp_role;
        private Label label5;
        private Label label6;
        private TextBox SignUp_username;
        private TextBox FirstName;
        private TextBox Signup_password;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox LastName;
        private Panel Parent_Signup_panel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox4;
        private Panel StudentPanel;
        private Label label15;
        private Label label14;
        private Label label17;
        private Label label16;
        private Button SignUpStudent;
        private Panel ParentPanel;
        private Panel TeacherPanel;
        private Label StudentID_stpage;
        private Label ParentID_StPage;
        private Label StudentName_StPage;
        private BindingSource recordManageBindingSource;
        private DataGridView StudentCourses;
        private Label TeacherName;
        private Label label22;
        private Label TeacherID;
        private Label label21;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView TeacherCourses;
        private TabControl St_AddCourse;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button AddCourse;
        private Label label20;
        private Label ST_displayCourseID;
        private Label label19;
        private Label label18;
        private ComboBox SelectCourseName_st;
        private Button St_deleteCourse;
        private Label CourseID_Delete_St;
        private Label label24;
        private Label label23;
        private ComboBox DeleteCourse_st;
        private TextBox T_Addcourse;
        private Label label26;
        private Label label25;
        private Button AddCourse_T;
        private Label CourseID;
        private Label label29;
        private Label label27;
        private ComboBox T_coursesNames;
        private Button T_unEnrollButton;
        private Label label28;
        private DataGridView studentTable;
        private Label label30;
        private ComboBox selectCourse;
    }
}
