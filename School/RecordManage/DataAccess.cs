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
using School.people;
using School.RecordManage;
namespace School.RecordManage
{
    public class DataAccess
    {
        private string ConnectionString;

        public DataAccess()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();


            ConnectionString = config.GetSection("constr").Value;
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

        public bool check_student_id(string sID, string password)
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

        




       



    }
}
