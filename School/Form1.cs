namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelError.Visible = false;
            String SelectedValue = RoleSelection.SelectedItem.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            MainPanel.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentSignupPanel.Visible = false;

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
            LabelError.Visible = false;
            string connectionString =  "Server=desktop-ol5def3; Database=School; Integrated Security=True; TrustServerCertificate=True;";
            ;
            DataAccess checking = new DataAccess(connectionString);
            if (checking.check_student(connectionString, user, pass))
            {
                
               StudentPanel.Visible = true;



            }else
            {
                LabelError.Visible = true;
            }
        }
    }
}
