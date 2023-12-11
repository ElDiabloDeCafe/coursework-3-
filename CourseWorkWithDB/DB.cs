using MySql.Data.MySqlClient;

namespace CourseWorkWithDB
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=users");

        public void openCon()
        {
            if(connection.State==System.Data.ConnectionState.Closed) connection.Open();
        }
        public void closeCon()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }

        public MySqlConnection getCon()
        {
            return connection;
        }
    }

   
}
