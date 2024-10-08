using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.RecordManage;
namespace School.people
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }



        public bool check_teacher_id(string sID, string password)
        {
            int count = 0;
            DataAccess Checking = new DataAccess();

            string query = "SELECT COUNT(*) FROM Teachers WHERE Username = @Username AND PasswordHash = @PasswordHash";


            try
            {
                using (SqlConnection cnn = Checking.connect_to_SQL())
                {

                    using (SqlCommand command = new SqlCommand(query, cnn))
                    {


                        command.Parameters.AddWithValue("@Username", sID);
                        command.Parameters.AddWithValue("@PasswordHash", password); // Ensure you hash the password



                        count = (int)command.ExecuteScalar();
                        cnn.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("not Conn");
            }



            return count > 0;
        }



        public Teacher check_teacher(string tID, string password)
        {

            DataAccess Checking = new DataAccess();

            string query = "SELECT TeacherID, FirstName, LastName, Username FROM Teachers WHERE Username = @Username AND PasswordHash = @PasswordHash";

            Dictionary<string, object> surveyDict = new Dictionary<string, object>();
            try
            {
                using (SqlConnection cnn = Checking.connect_to_SQL())
                {
                    using (SqlCommand command = new SqlCommand(query, cnn))
                    {
                        command.Parameters.AddWithValue("@Username", tID);
                        command.Parameters.AddWithValue("@PasswordHash", password); // Ensure you hash the password

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Check if a record exists
                            {
                                surveyDict = Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue);



                            }
                        }
                    }

                }

            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as appropriate

                MessageBox.Show("An error occurred: " + ex.Message);

            }
            Teacher teacher = new Teacher
            {
                TeacherID = surveyDict.ContainsKey("TeacherID") ? Convert.ToInt32(surveyDict["TeacherID"]) : 0,
                FirstName = surveyDict.ContainsKey("FirstName") ? surveyDict["FirstName"].ToString() : null,
                LastName = surveyDict.ContainsKey("LastName") ? surveyDict["LastName"].ToString() : null,
                Username = surveyDict.ContainsKey("Username") ? surveyDict["Username"].ToString() : null,


                //ParentID = surveyDict.ContainsKey("ParentID") ? (int?)Convert.ToInt32(surveyDict["ParentID"]) : null
            };

            return teacher;
        }


        public DataTable enrolledCourese(string sID)
        {

            string constr = "Server=DESKTOP-OL5DEF3; Database=School; Integrated Security=True; TrustServerCertificate=True";
            string query = @"SELECT c.CourseID, c.CourseName
                                FROM TeacherCourseEnrollment tce
                                JOIN Courses c ON tce.CourseID = c.CourseID
                                WHERE tce.TeacherID = @TeacherID;";
            DataTable table = new DataTable();

            DataAccess retrieve = new DataAccess();

            using (SqlConnection cnn = retrieve.connect_to_SQL())
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.Add("@TeacherID", SqlDbType.Int).Value = sID;
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);

                    }

                }
                cnn.Close();

            }
            return table;
        }

        public void add_course(int tID, string courseName)
        {
            string connectionString = "Server=DESKTOP-OL5DEF3;Database=School;Integrated Security=True;TrustServerCertificate=True";
            DataAccess add = new DataAccess();
            using (SqlConnection connection = add.connect_to_SQL())
            {
                // Step 1: Insert the new course
                string insertCourseQuery = "INSERT INTO Courses (CourseName) OUTPUT INSERTED.CourseID VALUES (@CourseName)";

                using (SqlCommand command = new SqlCommand(insertCourseQuery, connection))
                {
                    command.Parameters.AddWithValue("@CourseName", courseName);

                    try
                    {
                        int newCourseId = (int)command.ExecuteScalar(); // Get the newly inserted CourseID

                        // Step 2: Enroll the teacher in the new course
                        string enrollTeacherQuery = "INSERT INTO TeacherCourseEnrollment (TeacherID, CourseID) VALUES (@TeacherID, @CourseID)";

                        using (SqlCommand enrollCommand = new SqlCommand(enrollTeacherQuery, connection))
                        {
                            enrollCommand.Parameters.AddWithValue("@TeacherID", tID);
                            enrollCommand.Parameters.AddWithValue("@CourseID", newCourseId);

                            enrollCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Course added and teacher enrolled successfully.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }




        public void LoadCourses_enrolled(ComboBox comboBox, int sID)
        {

            string connectionString = "Server=DESKTOP-OL5DEF3; Database=School; Integrated Security=True; TrustServerCertificate=True";

            // SQL query to get course names
            string query = @"SELECT c.CourseID, c.CourseName
                                FROM Courses c
                            JOIN TeacherCourseEnrollment e ON c.CourseID = e.CourseID
                            WHERE e.TeacherID = @TeacherID;";
            DataAccess access = new DataAccess();

            using (SqlConnection cnn = access.connect_to_SQL())
            {
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.AddWithValue("@TeacherID", sID);

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
            string query = @"DELETE FROM TeacherCourseEnrollment
                            WHERE TeacherID = @TeacherID AND CourseID = @CourseID; ";

            using (SqlConnection cnn = del.connect_to_SQL())
            {

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@TeacherID", sID);
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


        public DataTable GetStudentsEnrolledInCourse(int courseId)
        {
            string connectionString = "Server=DESKTOP-OL5DEF3; Database=School; Integrated Security=True; TrustServerCertificate=True";

            DataTable studentsTable = new DataTable();
            DataAccess retrieve = new DataAccess();
            string query = @"
                SELECT s.StudentID, s.FirstName, s.LastName
                FROM Students s
                JOIN Enrollment e ON s.StudentID = e.StudentID
                WHERE e.CourseID = @CourseID";

            using (SqlConnection cnn = retrieve.connect_to_SQL())
            {


                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.Parameters.AddWithValue("@CourseID", courseId);

                    try
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(studentsTable);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("GetStudentsEnrolledInCourse method SQL error ");
                    }
                }
            }

            return studentsTable;
        }


    }
}
