using System.Data.SqlClient;

namespace DevideManagement.Utils
{
    class DBHelper
    {
        const string DATA_SOURCE = "SE141150";
        const string DATABASE_NAME = "management";

        public static SqlConnection getConnection()
        {

            string connetionString = @"Data Source=" + DATA_SOURCE + ";Initial Catalog=" + DATABASE_NAME + ";Integrated Security=True";
            SqlConnection con = new SqlConnection(connetionString);
            return con;
        }
    }
}
