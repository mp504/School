using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Extensions.Configuration;

namespace School
{
    internal class DataAccess
    {
        private String ConnectionString;

        public DataAccess ( )
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();


            this.ConnectionString = config.GetSection("constr").Value;
        }


        public SqlConnection connect_to_SQL()
        {


            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                connection.Open(); // Open the connection


            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }


            return connection;


        }



        public void insert_record(SqlConnection cnn, string tableName, Dictionary<string, object> columns)
        {
            var columnNames = string.Join(", ", columns.Keys);
            var parameterNames = string.Join(", ", columns.Keys.Select(k => "@" + k));

            string sql = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameterNames})";
            try
            {


                using (SqlCommand command = new SqlCommand(sql, cnn))
                {

                    foreach (var column in columns)
                    {
                        command.Parameters.AddWithValue("@" + column.Key, column.Value);
                    }

                    command.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {

            }


  
        }

        public bool check_student_id(string connectionString, string sID, string password)
        {
            int count = 0;
            DataAccess Checking = new DataAccess();

            string query = "SELECT COUNT(*) FROM Students WHERE Username = @Username AND PasswordHash = @PasswordHash";


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

        public Student check_student(string connectionString, string sID, string password)
        {
           
            DataAccess Checking = new DataAccess();
           
            string query = "SELECT StudentID, FirstName, LastName, Username, ParentID FROM Students WHERE Username = @Username AND PasswordHash = @PasswordHash";
            
            Dictionary<string, object> surveyDict = new Dictionary<string, object>();
            try
            {
                using (SqlConnection cnn = Checking.connect_to_SQL())
                {
                    using (SqlCommand command = new SqlCommand(query, cnn))
                    {
                        command.Parameters.AddWithValue("@Username", sID);
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
                 Student student = new Student
                {
                    StudentID = surveyDict.ContainsKey("StudentID") ? Convert.ToInt32(surveyDict["StudentID"]) : 0,
                    FirstName = surveyDict.ContainsKey("FirstName") ? surveyDict["FirstName"].ToString() : null,
                    LastName = surveyDict.ContainsKey("LastName") ? surveyDict["LastName"].ToString() : null,
                    Username = surveyDict.ContainsKey("Username") ? surveyDict["Username"].ToString() : null,


                     //ParentID = surveyDict.ContainsKey("ParentID") ? (int?)Convert.ToInt32(surveyDict["ParentID"]) : null
                 };
    
            return student;
        }




        public Teacher check_teacher(string connectionString, string sID, string password)
        {
            Teacher teacher = new Teacher();
            DataAccess Checking = new DataAccess();


            string query = "SELECT TeacherID, FirstName, LastName, Username FROM Teachers WHERE Username = @Username AND PasswordHash = @PasswordHash";

            try
            {
                using (SqlConnection cnn = Checking.connect_to_SQL())
                {
                    using (SqlCommand command = new SqlCommand(query, cnn))
                    {
                        command.Parameters.AddWithValue("@Username", sID);
                        command.Parameters.AddWithValue("@PasswordHash", password); // Ensure you hash the password

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Check if a record exists
                            {
                                teacher = new Teacher
                                {
                                    TeacherID = reader.GetInt32("TeacherID"), // Assuming TeacherID is the first column
                                    FirstName = reader.GetString("FirstName"), // Assuming FirstName is the second column
                                    LastName = reader.GetString("LastName"), // Assuming LastName is the third column
                                    Username = reader.GetString("Username") // Assuming Username is the fourth column
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as appropriate
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return teacher; // Returns null if not found, or a Teacher object if found

        }



        public Boolean check_parent(string connectionString, string sID, string password)
        {
            int count = 0;
            DataAccess Checking = new DataAccess();

            string query = "SELECT COUNT(*) FROM Parents WHERE Username = @Username AND PasswordHash = @PasswordHash";



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


            return count > 0;

        }

       



    }
}
