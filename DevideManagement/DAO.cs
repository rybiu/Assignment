using DeviceManagement.DTO;
using DeviceManagement.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagement.DAO
{
    public class AccountDAO
    {
        public bool AddAccount(AccountDTO account)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "INSERT INTO account(username, password, role) VALUES(@username, @password, @role)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("username", account.username);
            cmd.Parameters.AddWithValue("password", account.password);
            cmd.Parameters.AddWithValue("role", account.role.ToString());
            bool result =  cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public bool DeleteAccount(int id)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE account SET status = 0 WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public bool UpdateAccount(AccountDTO account)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE account SET username = @username, password = @password WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", account.id);
            cmd.Parameters.AddWithValue("username", account.username);
            cmd.Parameters.AddWithValue("password", account.password);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public AccountDTO GetAccount(int id)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT username, password, role, room_id FROM account a WHERE a.id = @id AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            AccountDTO result = null;
            if (dr.Read())
            {
                string username = dr.GetString(0);
                string password = dr.GetString(1);
                Enum.TryParse(dr.GetString(2), out AccountDTO.ROLE role);
                int roomId = -1;
                if (!dr.IsDBNull(3)) roomId = dr.GetInt32(3);
                result = new AccountDTO
                {
                    id = id,
                    username = username,
                    password = password,
                    role = role,
                    roomId = roomId
                };
            }
            con.Close();
            return result;
        }
        public AccountDTO GetAccount(string username, string password)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id, role, room_id FROM account "
                        + "WHERE username = @username AND password = @password AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            AccountDTO result = null;
            if (dr.Read())
            {
                int id = dr.GetInt32(0);
                Enum.TryParse(dr.GetString(1), out AccountDTO.ROLE role);
                int roomId = -1;
                if (!dr.IsDBNull(2))  roomId = dr.GetInt32(2);
                result = new AccountDTO
                {
                    id = id,
                    username = username,
                    password = password,
                    role = role,
                    roomId = roomId
                };
            }
            con.Close();
            return result;
        }
        public int GetLastAccountId()
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT MAX(id) AS id FROM account";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            int id = -1;
            if (dr.Read()) id = dr.GetInt32(0);
            con.Close();
            return id;
        }
        public DataTable GetAccounts(AccountDTO.ROLE role)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id, username, password, room_id FROM account WHERE role = @role AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("role", role.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable list = new DataTable();
            da.Fill(list);
            con.Close();
            return list;
        }
        public List<AccountDTO> GetAccounts(int roomId)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id, username FROM account WHERE room_id = @roomId AND role = 'USER' AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("roomId", roomId);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            List<AccountDTO> list = null;
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string username = dr.GetString(1);
                if (list == null) list = new List<AccountDTO>();
                list.Add(new AccountDTO { id = id, username = username });
            }
            con.Close();
            return list;
        }
        public List<AccountDTO> GetAccountsNoneRoom()
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id, username FROM account WHERE room_id IS NULL AND role = 'USER' AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            List<AccountDTO> list = null;
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string username = dr.GetString(1);
                if (list == null) list = new List<AccountDTO>();
                list.Add(new AccountDTO { id = id, username = username });
            }
            con.Close();
            return list;
        }
        public bool SetRoomId(int id, int roomId)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE account SET room_id = @roomId WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            if (roomId != -1)  cmd.Parameters.AddWithValue("roomId", roomId);
            if (roomId == -1)  cmd.Parameters.AddWithValue("roomId", DBNull.Value);
            cmd.Parameters.AddWithValue("id", id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public int IsExist(string username)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id FROM account WHERE username = @username AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("username", username);
            SqlDataReader dr = cmd.ExecuteReader();
            int id = -1;
            if (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            con.Close();
            return id;
        }
    }
    
    public class DeviceDAO
    {

        public bool AddDevice(DeviceDTO device)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "INSERT INTO device(name, description, type, bought_date, warranty_date, image) " +
                            "VALUES(@name, @description, @type, @bought_date, @warranty_date, @image)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("name", device.name);
            cmd.Parameters.AddWithValue("description", device.description);
            cmd.Parameters.AddWithValue("type", device.type);
            if (device.boughtDate != null)
            {
                cmd.Parameters.AddWithValue("bought_date", device.boughtDate);
            } else
            {
                cmd.Parameters.Add("bought_date", SqlDbType.Date).Value = DBNull.Value;

            }
            if (device.warrantyDate != null)
            {
                cmd.Parameters.AddWithValue("warranty_date", device.warrantyDate);
            }
            else
            {
                cmd.Parameters.Add("warranty_date", SqlDbType.Date).Value = DBNull.Value;

            }
            if (device.image != null)
            {
                cmd.Parameters.AddWithValue("image", device.image);
            } else
            {
                cmd.Parameters.Add("image", SqlDbType.Image).Value = DBNull.Value;
            }
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public bool DeleteDevice(int id)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE device SET status = 0 WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public bool UpdateDevice(DeviceDTO device)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE device SET "
                        + "name = @name, "
                        + "description = @description, "
                        + "type = @type, "
                        + "bought_date = @bought_date, "
                        + "warranty_date = @warranty_date "
                        + "WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("name", device.name);
            cmd.Parameters.AddWithValue("description", device.description);
            cmd.Parameters.AddWithValue("type", device.type);
            cmd.Parameters.AddWithValue("bought_date", device.boughtDate);
            cmd.Parameters.AddWithValue("warranty_date", device.warrantyDate);
            cmd.Parameters.AddWithValue("id", device.id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public bool UpdateDeviceImage(int id, byte[] image)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE device SET image = @image WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            if (image != null)
            {
                cmd.Parameters.AddWithValue("image", image);
            }
            else 
            {
                cmd.Parameters.Add("image", SqlDbType.Image).Value = DBNull.Value;
            }
            cmd.Parameters.AddWithValue("id", id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public DeviceDTO GetDevice(int id)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT name, type, description, image, bought_date, warranty_date, action "
                        + "FROM device "
                        + "WHERE id = @id AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DeviceDTO result = null;
            if (dr.Read())
            {
                string name = dr["name"].ToString();
                string type = dr["type"].ToString();
                string description = dr["description"].ToString();
                DateTime boughtDate = dr.GetDateTime(4);
                DateTime warrantyDate = dr.GetDateTime(5);
                bool action = bool.Parse(dr["action"].ToString());
                result = new DeviceDTO { name = name, type = type, description = description, boughtDate = boughtDate, warrantyDate = warrantyDate, action = action };
            }
            con.Close();
            return result;
        }
        public DataTable GetDevices()
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id, name, type, description, image, bought_date, warranty_date, action FROM device WHERE status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable list = new DataTable();
            da.Fill(list);
            con.Close();
            return list;
        }
        public List<DeviceDTO> GetDevices(int roomId, string searchValue)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Close();
            string sql = "SELECT id, name, action FROM device "
                        + "WHERE room_id = @roomId AND status = 1 AND name LIKE @name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("roomId", roomId);
            cmd.Parameters.AddWithValue("name", "%" + searchValue + "%");
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            List<DeviceDTO> list = null;
            while (dr.Read())
            {
                int id = int.Parse(dr["id"].ToString());
                string name = dr["name"].ToString();
                bool action = bool.Parse(dr["action"].ToString());
                if (list == null) list = new List<DeviceDTO>();
                list.Add(new DeviceDTO { id = id, name = name, action = action });
            }
            con.Close();
            return list;
        }
        public List<DeviceDTO> GetDevices(string searchValue)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id, name, action FROM device "
                        + "WHERE status = 1 AND name LIKE @name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("name", "%" + searchValue + "%");
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            List<DeviceDTO> list = null;
            while (dr.Read())
            {
                int id = int.Parse(dr["id"].ToString());
                string name = dr["name"].ToString();
                bool action = bool.Parse(dr["action"].ToString());
                if (list == null) list = new List<DeviceDTO>();
                list.Add(new DeviceDTO { id = id, name = name, action = action });
            }
            con.Close();
            return list;
        }
        public List<DeviceDTO> GetDevices(int roomId)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id, name FROM device WHERE room_id = @roomId AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("roomId", roomId);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            List<DeviceDTO> list = null;
            while (dr.Read())
            {
                int id = int.Parse(dr["id"].ToString());
                string name = dr["name"].ToString();
                bool action = bool.Parse(dr["action"].ToString());
                if (list == null) list = new List<DeviceDTO>();
                list.Add(new DeviceDTO { id = id, name = name, action = action });
            }
            con.Close();
            return list;
        }
        public List<DeviceDTO> GetDevicesNoneRoom()
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id, name FROM device WHERE room_id IS NULL AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            List<DeviceDTO> list = null;
            while (dr.Read())
            {
                int id = int.Parse(dr["id"].ToString());
                string name = dr["name"].ToString();
                bool action = bool.Parse(dr["action"].ToString());
                if (list == null) list = new List<DeviceDTO>();
                list.Add(new DeviceDTO { id = id, name = name, action = action });
            }
            con.Close();
            return list;
        }
        public int GetLastId()
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT MAX(id) FROM device";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            int id = -1;
            if (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            con.Close();
            return id;
        }


        /*public Map<Device, Integer> getDevicesByFixedTime(int min, int max)
        {
            SqlConnection con = null;
            List<DeviceDTO> list = null;
            try
            {
                con = DBHelper.getConnection();
                string sql = "SELECT id, name FROM device WHERE room_id IS NULL AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string name = dr["name"].ToString();
                    bool action = bool.Parse(dr["action"].ToString());
                    if (list == null) list = new List<DeviceDTO>();
                    list.Add(new DeviceDTO(id, name, action));
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return list;
        }*/
    }
}

    public class RoomDAO
    {
        public bool AddRoom(string roomName)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "INSERT INTO room(name) VALUES (@roomName)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("roomName", roomName);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return false;
        }
        public bool DeleteRoom(int id)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "DELETE FROM room WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return false;
        }
        public bool UpdateRoom(int id, string roomName)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "UPDATE room SET name = @roomName WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("roomName", roomName);
                cmd.Parameters.AddWithValue("id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return false;
        }
    /*public List<RoomDAO> GetRooms()
    {
        SqlConnection con = null;
        try
        {
            con = DBHelper.GetConnectionInstance();
            string sql = "UPDATE room SET name = @roomName WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("roomName", roomName);
            cmd.Parameters.AddWithValue("id", id);
            return cmd.ExecuteNonQuery() > 0;
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            if (con != null) con.Close();
        }
        return false;
    }
}*/

}
