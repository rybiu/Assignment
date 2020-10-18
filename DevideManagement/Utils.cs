using System.Data.SqlClient;

namespace DevideManagement.Utils
{
    class DBHelper
    {
        const string DATA_SOURCE = "SE141150";
        const string DATABASE_NAME = "management";

        public static SqlConnection connection;

        public static SqlConnection GetConnectionInstance()
        {
            if (connection == null)
            {
                string connetionString = @"Data Source=" + DATA_SOURCE + ";Initial Catalog=" + DATABASE_NAME + ";Integrated Security=True";
                connection = new SqlConnection(connetionString);
            }
            return connection;
        }

    }
}
