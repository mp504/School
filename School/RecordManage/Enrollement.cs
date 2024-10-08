using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.RecordManage;
using School.People;
namespace School.RecordManage
{
    public class Enrollement
    {



        // loading  not enrolled courses 
        public void LoadCourses(ComboBox comboBox, int sID)
        {

            string connectionString = "Server=DESKTOP-OL5DEF3; Database=School; Integrated Security=True; TrustServerCertificate=True";

            // SQL query to get course names
            string query = @"SELECT CourseID, CourseName 
                                   FROM Courses 
                                WHERE CourseID NOT IN (
                                 SELECT CourseID 
                                FROM Enrollment 
                                WHERE StudentID = @StudentID)"; // Adjust the table and column names as needed
            DataAccess access = new DataAccess();

            using (SqlConnection cnn = access.connect_to_SQL())
            {
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.AddWithValue("@StudentID", sID);

                try
                {

                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing items
                    comboBox.Items.Clear();

                    // Use a DataTable to store results
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Set DataSource, DisplayMember, and ValueMember
                    comboBox.DataSource = dataTable;
                    comboBox.DisplayMember = "CourseName"; // Column to display
                    comboBox.ValueMember = "CourseID";     // Column to use as value
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public void Add_course(int sID, int cID)
        {
            string connectionString = "Server=DESKTOP-OL5DEF3; Database=School; Integrated Security=True; TrustServerCertificate=True";
            DataAccess add = new DataAccess();
            string query = "INSERT INTO Enrollment (StudentID, CourseID) VALUES (@StudentID, @CourseID)";



            using (SqlConnection cnn = add.connect_to_SQL())
            {

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {

                    cmd.Parameters.AddWithValue("@StudentID", sID);
                    cmd.Parameters.AddWithValue("@CourseID", cID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Course Added!");

                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(" Error " + ex);
                    }
                }
            }
        }

        // load enrolled courses
        public void LoadCourses_enrolled(ComboBox comboBox, int sID)
        {

            string connectionString = "Server=DESKTOP-OL5DEF3; Database=School; Integrated Security=True; TrustServerCertificate=True";

            // SQL query to get course names
            string query = @"SELECT c.CourseID, c.CourseName
                                FROM Courses c
                            JOIN Enrollment e ON c.CourseID = e.CourseID
                            WHERE e.StudentID = @StudentID;";
            DataAccess access = new DataAccess();

            using (SqlConnection cnn = access.connect_to_SQL())
            {
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.AddWithValue("@StudentID", sID);

                try
                {

                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing items
                    comboBox.Items.Clear();

                    // Use a DataTable to store results
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Set DataSource, DisplayMember, and ValueMember
                    comboBox.DataSource = dataTable;
                    comboBox.DisplayMember = "CourseName"; // Column to display
                    comboBox.ValueMember = "CourseID";     // Column to use as value
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public void deleteCourse(int sID, int cID)
        {
            string connectionString = "Server=DESKTOP-OL5DEF3; Database=School; Integrated Security=True; TrustServerCertificate=True";

            DataAccess del = new DataAccess();
            string query = @"DELETE FROM Enrollment
                            WHERE StudentID = @StudentID AND CourseID = @CourseID; ";

            using (SqlConnection cnn = del.connect_to_SQL())
            {

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", sID);
                    cmd.Parameters.AddWithValue("@CourseID", cID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Course Deleted!");

                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(" Error " + ex);
                    }

                }

            }
        }


    }



}
