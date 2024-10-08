using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using School.People;
namespace School.RecordManage
{
    public class RecordManagement
    {
        public DataTable Retrieve_table(int sID)
        {

            string Connstr = "Server=DESKTOP-OL5DEF3; Database=School; Integrated Security=True; TrustServerCertificate=True";
            DataAccess table = new DataAccess();
            string query = @"SELECT c.CourseID, c.CourseName
                        FROM Courses c
                        JOIN Enrollment e ON c.CourseID = e.CourseID
                        JOIN Students s ON e.StudentID = s.StudentID
                            WHERE s.StudentID = @StudentID";
            DataTable datatable = new DataTable();
            try
            {
                using (SqlConnection cnn = table.connect_to_SQL())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {


                        cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = sID;
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(datatable);

                        }



                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" error in sql" + ex);
            }
            catch (Exception ex2)

            {
                MessageBox.Show("run error " + ex2);
            }

            return datatable;

        }


    }
}
