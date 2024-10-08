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
    internal class Parent
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string userName { get; set; }




        public bool check_parent(string sID, string password)
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


        public Parent parent(string pID, string password)
        {

            DataAccess Checking = new DataAccess();

            string query = "SELECT ParentID, FirstName, LastName, Username FROM Parents WHERE Username = @Username AND PasswordHash = @PasswordHash";

            Dictionary<string, object> surveyDict = new Dictionary<string, object>();
            try
            {
                using (SqlConnection cnn = Checking.connect_to_SQL())
                {
                    using (SqlCommand command = new SqlCommand(query, cnn))
                    {
                        command.Parameters.AddWithValue("@Username", pID);
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
            Parent parent = new Parent
            {
                Id = surveyDict.ContainsKey("ParentID") ? Convert.ToInt32(surveyDict["ParentID"]) : 0,
                FName = surveyDict.ContainsKey("FirstName") ? surveyDict["FirstName"].ToString() : null,
                LName = surveyDict.ContainsKey("LastName") ? surveyDict["LastName"].ToString() : null,
                userName = surveyDict.ContainsKey("Username") ? surveyDict["Username"].ToString() : null,



            };

            return parent;
        }


        public DataTable childs(int parentID)
        {

            DataAccess dt = new DataAccess();
            DataTable table = new DataTable();
            string query = @"
                SELECT s.StudentID, s.FirstName, s.LastName
                FROM Students s
                WHERE s.ParentID = @ParentID";


            using (SqlConnection cnn = dt.connect_to_SQL())
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@ParentID", parentID);

                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("childs Method; error");
                    }

                }
            }
            return table;
        }

        public void updateStudent(int parentID, int sID)
        {
            DataAccess update = new DataAccess();

            string query = "UPDATE Students SET ParentID = @ParentID WHERE StudentID = @StudentID";

            try
            {


                using (SqlConnection cnn = update.connect_to_SQL())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ParentID", parentID);
                        cmd.Parameters.AddWithValue("@StudentID", sID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Child added.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" update Student error");
            }

        }
    }
}
