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
            RoleSelection = new ComboBox();
            label1 = new Label();
            MainPanel = new Panel();
            LabelError = new Label();
            label4 = new Label();
            SignUp = new Button();
            Login = new Button();
            label3 = new Label();
            label2 = new Label();
            Password = new TextBox();
            UserName = new TextBox();
            SignUp_page = new Panel();
            label5 = new Label();
            SignUp_role = new ComboBox();
            signupLabel = new Label();
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
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            MainPanel.SuspendLayout();
            SignUp_page.SuspendLayout();
            StudentSignupPanel.SuspendLayout();
            Parent_Signup_panel.SuspendLayout();
            StudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RoleSelection
            // 
            RoleSelection.AccessibleName = "RoleSelect";
            RoleSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleSelection.FormattingEnabled = true;
            RoleSelection.Items.AddRange(new object[] { "Teacher ", "Student ", "Parent" });
            RoleSelection.Location = new Point(59, 12);
            RoleSelection.Margin = new Padding(3, 2, 3, 2);
            RoleSelection.Name = "RoleSelection";
            RoleSelection.Size = new Size(133, 23);
            RoleSelection.TabIndex = 0;
            RoleSelection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Role";
            label1.Click += label1_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ActiveBorder;
            MainPanel.Controls.Add(LabelError);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(SignUp);
            MainPanel.Controls.Add(Login);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(Password);
            MainPanel.Controls.Add(UserName);
            MainPanel.Controls.Add(RoleSelection);
            MainPanel.Controls.Add(label1);
            MainPanel.Location = new Point(10, 9);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(219, 320);
            MainPanel.TabIndex = 3;
            MainPanel.Paint += panel2_Paint;
            // 
            // LabelError
            // 
            LabelError.AutoSize = true;
            LabelError.ForeColor = Color.Red;
            LabelError.Location = new Point(15, 184);
            LabelError.Name = "LabelError";
            LabelError.Size = new Size(167, 15);
            LabelError.TabIndex = 9;
            LabelError.Text = "Invalid username or password!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 226);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 8;
            label4.Text = "If you don't have account";
            label4.Click += label4_Click;
            // 
            // SignUp
            // 
            SignUp.Location = new Point(59, 262);
            SignUp.Margin = new Padding(3, 2, 3, 2);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(82, 22);
            SignUp.TabIndex = 7;
            SignUp.Text = "Sign Up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // Login
            // 
            Login.Location = new Point(59, 155);
            Login.Margin = new Padding(3, 2, 3, 2);
            Login.Name = "Login";
            Login.Size = new Size(82, 22);
            Login.TabIndex = 6;
            Login.Text = "Log in";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 119);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 80);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "User name";
            label2.Click += label2_Click;
            // 
            // Password
            // 
            Password.Location = new Point(86, 119);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.Size = new Size(110, 23);
            Password.TabIndex = 3;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += textBox2_TextChanged;
            // 
            // UserName
            // 
            UserName.Location = new Point(86, 80);
            UserName.Margin = new Padding(3, 2, 3, 2);
            UserName.Name = "UserName";
            UserName.Size = new Size(110, 23);
            UserName.TabIndex = 2;
            UserName.TextChanged += textBox1_TextChanged;
            // 
            // SignUp_page
            // 
            SignUp_page.Controls.Add(label5);
            SignUp_page.Controls.Add(SignUp_role);
            SignUp_page.Controls.Add(signupLabel);
            SignUp_page.Controls.Add(StudentSignupPanel);
            SignUp_page.Controls.Add(Parent_Signup_panel);
            SignUp_page.Location = new Point(10, 9);
            SignUp_page.Margin = new Padding(3, 2, 3, 2);
            SignUp_page.Name = "SignUp_page";
            SignUp_page.Size = new Size(679, 320);
            SignUp_page.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 59);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 3;
            label5.Text = "Role";
            label5.Click += label5_Click_1;
            // 
            // SignUp_role
            // 
            SignUp_role.FormattingEnabled = true;
            SignUp_role.Items.AddRange(new object[] { "Student", "Parent", "Teacher" });
            SignUp_role.Location = new Point(239, 56);
            SignUp_role.Margin = new Padding(3, 2, 3, 2);
            SignUp_role.Name = "SignUp_role";
            SignUp_role.Size = new Size(133, 23);
            SignUp_role.TabIndex = 1;
            SignUp_role.SelectedIndexChanged += SignUp_role_SelectedIndexChanged;
            // 
            // signupLabel
            // 
            signupLabel.AutoSize = true;
            signupLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupLabel.Location = new Point(224, 12);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(158, 30);
            signupLabel.TabIndex = 0;
            signupLabel.Text = "SIGN UP Page";
            signupLabel.Click += label5_Click;
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
            StudentSignupPanel.Location = new Point(11, 97);
            StudentSignupPanel.Margin = new Padding(3, 2, 3, 2);
            StudentSignupPanel.Name = "StudentSignupPanel";
            StudentSignupPanel.Size = new Size(654, 209);
            StudentSignupPanel.TabIndex = 2;
            StudentSignupPanel.Visible = false;
            // 
            // SignUpStudent
            // 
            SignUpStudent.Location = new Point(352, 87);
            SignUpStudent.Name = "SignUpStudent";
            SignUpStudent.Size = new Size(75, 23);
            SignUpStudent.TabIndex = 8;
            SignUpStudent.Text = "Sign UP";
            SignUpStudent.UseVisualStyleBackColor = true;
            SignUpStudent.Click += SignUpStudent_Click;
            // 
            // LastName
            // 
            LastName.Location = new Point(142, 139);
            LastName.Margin = new Padding(3, 2, 3, 2);
            LastName.Name = "LastName";
            LastName.Size = new Size(110, 23);
            LastName.TabIndex = 7;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(142, 100);
            FirstName.Margin = new Padding(3, 2, 3, 2);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(110, 23);
            FirstName.TabIndex = 6;
            // 
            // Signup_password
            // 
            Signup_password.Location = new Point(142, 65);
            Signup_password.Margin = new Padding(3, 2, 3, 2);
            Signup_password.Name = "Signup_password";
            Signup_password.Size = new Size(110, 23);
            Signup_password.TabIndex = 5;
            Signup_password.Text = "Enter Password";
            Signup_password.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 144);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 4;
            label9.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 103);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 3;
            label8.Text = "First Name";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 68);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 2;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 34);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 1;
            label6.Text = "User Name";
            // 
            // SignUp_username
            // 
            SignUp_username.Location = new Point(142, 29);
            SignUp_username.Margin = new Padding(3, 2, 3, 2);
            SignUp_username.Name = "SignUp_username";
            SignUp_username.Size = new Size(110, 23);
            SignUp_username.TabIndex = 0;
            SignUp_username.Text = "Enter UserName";
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
            Parent_Signup_panel.Location = new Point(11, 97);
            Parent_Signup_panel.Margin = new Padding(3, 2, 3, 2);
            Parent_Signup_panel.Name = "Parent_Signup_panel";
            Parent_Signup_panel.Size = new Size(654, 209);
            Parent_Signup_panel.TabIndex = 8;
            Parent_Signup_panel.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 139);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 100);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 65);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 5;
            textBox3.Text = "Enter Password";
            textBox3.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(48, 144);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 4;
            label10.Text = "Last Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(47, 103);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 3;
            label11.Text = "First Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(47, 68);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 2;
            label12.Text = "Password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 34);
            label13.Name = "label13";
            label13.Size = new Size(65, 15);
            label13.TabIndex = 1;
            label13.Text = "User Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(142, 29);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 0;
            textBox4.Text = "Enter UserName";
            // 
            // StudentPanel
            // 
            StudentPanel.BackColor = SystemColors.ButtonFace;
            StudentPanel.Controls.Add(label17);
            StudentPanel.Controls.Add(label16);
            StudentPanel.Controls.Add(label15);
            StudentPanel.Controls.Add(label14);
            StudentPanel.Controls.Add(dataGridView1);
            StudentPanel.Location = new Point(10, 7);
            StudentPanel.Margin = new Padding(3, 2, 3, 2);
            StudentPanel.Name = "StudentPanel";
            StudentPanel.Size = new Size(676, 320);
            StudentPanel.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(22, 244);
            label17.Name = "label17";
            label17.Size = new Size(41, 15);
            label17.TabIndex = 5;
            label17.Text = "Parent";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(14, 146);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 4;
            label16.Text = "Student name:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 88);
            label15.Name = "label15";
            label15.Size = new Size(65, 15);
            label15.TabIndex = 3;
            label15.Text = "Student ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(286, 8);
            label14.Name = "label14";
            label14.Size = new Size(261, 25);
            label14.TabIndex = 2;
            label14.Text = "Enrolled Courses by student";
            label14.Click += label14_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(146, 38);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(508, 268);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(SignUp_page);
            Controls.Add(StudentPanel);
            Controls.Add(MainPanel);
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label17;
        private Label label16;
        private Label LabelError;
        private Button SignUpStudent;
    }
}
