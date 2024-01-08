using System.Data.SqlClient;

namespace CR_RBD_Ulchenko
{
    public class DataBase
    {
        static SqlConnection sqlConnection = new(@"Data Source=DESKTOP-KBQVOJR; Initial Catalog=drivingDB;Integrated Security=true; Encrypt=false");

        public  void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection() => sqlConnection;
    }
}
