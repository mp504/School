using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.RecordManage;
using School.People;

namespace School.People

{
    public class Student
    {

        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public int? ParentID { get; set; }
        // Add other properties as necessary


        public Student checkChild(int sID)
        {

            DataAccess Checking = new DataAccess();

            string query = "SELECT StudentID, FirstName, LastName, Username, ParentID FROM Students WHERE StudentID = @StudentID ";

            Dictionary<string, object> surveyDict = new Dictionary<string, object>();
            try
            {
                using (SqlConnection cnn = Checking.connect_to_SQL())
                {
                    using (SqlCommand command = new SqlCommand(query, cnn))
                    {
                        command.Parameters.AddWithValue("@StudentID", sID);


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


        public Student check_student(string sID, string password)
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

                ParentID = surveyDict.ContainsKey("ParentID") && surveyDict["ParentID"] != DBNull.Value ? Convert.ToInt32(surveyDict["ParentID"]) : null
                //ParentID = surveyDict.ContainsKey("ParentID") ? (int?)Convert.ToInt32(surveyDict["ParentID"]) : null
            };

            return student;
        }


        public bool check_student_id(int sID)
        {
            int count = 0;
            DataAccess Checking = new DataAccess();

            string query = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID ";


            try
            {
                using (SqlConnection cnn = Checking.connect_to_SQL())
                {

                    using (SqlCommand command = new SqlCommand(query, cnn))
                    {


                        command.Parameters.AddWithValue("@StudentID", sID);



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



    }
}
