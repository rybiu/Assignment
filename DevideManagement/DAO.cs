using DevideManagement.DTO;
using DevideManagement.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevideManagement.DAO
{
    public class AccountDAO
    {
        public bool AddAccount(AccountDTO account)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "INSERT INTO account(username, password, role) VALUES(@username, @password, @role)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("username", account.username);
                cmd.Parameters.AddWithValue("password", account.password);
                cmd.Parameters.AddWithValue("role", account.role.ToString());
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (con != null) con.Close();
            }
        }
        public bool DeleteAccount(int id)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "UPDATE account SET status = 0 WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            } finally
            {
                if (con != null) con.Close();
            }
            return false;
        }
        public bool UpdateAccount(AccountDTO account)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "UPDATE account SET username = @username, password = @password WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", account.id);
                cmd.Parameters.AddWithValue("username", account.username);
                cmd.Parameters.AddWithValue("password", account.password);
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
        public AccountDTO GetAccount(int id)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "SELECT username, password, role, room_id FROM account a WHERE a.id = @id AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", id);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    string username = dr.GetString(0);
                    string password = dr.GetString(1);
                    Enum.TryParse(dr.GetString(2), out AccountDTO.ROLE role);
                    int roomId = -1;
                    if (!dr.IsDBNull(3)) roomId = dr.GetInt32(3);
                    return new AccountDTO
                    {
                        id = id,
                        username = username,
                        password = password,
                        role = role,
                        roomId = roomId
                    };
                }
            }
            finally
            {
                if (con != null) con.Close();
            }
            return null;
        }
        public AccountDTO GetAccount(string username, string password)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "SELECT id, role, room_id FROM account "
                            + "WHERE username = @username AND password = @password AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    Enum.TryParse(dr.GetString(1), out AccountDTO.ROLE role);
                    int roomId = -1;
                    if (!dr.IsDBNull(2))  roomId = dr.GetInt32(2);
                    return new AccountDTO
                    {
                        id = id,
                        username = username,
                        password = password,
                        role = role,
                        roomId = roomId
                    };
                }
            }
            finally
            {
                if (con != null) con.Close();
            }
            return null;
        }
        public List<AccountDTO> GetAccounts(AccountDTO.ROLE role)
        {
            SqlConnection con = null;
            List<AccountDTO> list = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "SELECT id, username FROM account WHERE role = @role AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("role", role.ToString());
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string username = dr.GetString(1);
                    if (list == null) list = new List<AccountDTO>();
                    list.Add(new AccountDTO { id = id, username = username });
                }
            }
            finally
            {
                if (con != null) con.Close();
            }
            return list;
        }
        public List<AccountDTO> GetAccounts(int roomId)
        {
            SqlConnection con = null;
            List<AccountDTO> list = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "SELECT id, username FROM account WHERE room_id = @roomId AND role = 'USER' AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("roomId", roomId);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string username = dr["username"].ToString();
                    if (list == null) list = new List<AccountDTO>();
                    list.Add(new AccountDTO { id = id, username = username });
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
        }
        public List<AccountDTO> GetAccountsNoneRoom()
        {
            SqlConnection con = null;
            List<AccountDTO> list = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "SELECT id, username FROM account WHERE room_id IS NULL AND role = 'USER' AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string username = dr["username"].ToString();
                    if (list == null) list = new List<AccountDTO>();
                    list.Add(new AccountDTO { id = id, username = username });
                }
            }
            finally
            {
                if (con != null) con.Close();
            }
            return list;
        }
        public bool SetRoomId(int id, int roomId)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "UPDATE account SET room_id = @roomId WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (roomId != -1)  cmd.Parameters.AddWithValue("roomId", roomId);
                if (roomId == -1)  cmd.Parameters.AddWithValue("roomId", DBNull.Value);
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
        public int IsExist(string username)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                con.Open();
                string sql = "SELECT id FROM account WHERE username = @username AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("username", username);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return int.Parse(dr["id"].ToString());
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
            return -1;
        }
    }
    
    public class DevideDAO
    {
        public bool AddDevice(DeviceDTO device)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "INSERT INTO device(name, description, type, bought_date, warranty_date, image_url) " +
                             "VALUES(@name, @description, @type, @bought_date, @warranty_date, @image_url)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("name", device.name);
                cmd.Parameters.AddWithValue("description", device.description);
                cmd.Parameters.AddWithValue("type", device.type);
                cmd.Parameters.AddWithValue("bought_date", device.boughtDate);
                cmd.Parameters.AddWithValue("warranty_date", device.warrantyDate);
                cmd.Parameters.AddWithValue("image_url", device.image);
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
        public bool DeleteDevice(int id)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "UPDATE device SET status = 0 WHERE id = @id";
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
        public bool UpdateDevice(DeviceDTO device)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "UPDATE device SET "
                            + "name = @name, "
                            + "description = @description, "
                            + "type = @type, "
                            + "bought_date = @bought_date, "
                            + "warranty_date = @warranty_date, "
                            + "image_url = @image_url"
                            + "WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("name", device.name);
                cmd.Parameters.AddWithValue("description", device.description);
                cmd.Parameters.AddWithValue("type", device.type);
                cmd.Parameters.AddWithValue("bought_date", device.boughtDate);
                cmd.Parameters.AddWithValue("warranty_date", device.warrantyDate);
                cmd.Parameters.AddWithValue("image_url", device.image);
                cmd.Parameters.AddWithValue("id", device.id);
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
        public bool UpdateDevice(int id, string field, object value)
        {
            SqlConnection con = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "UPDATE device SET " + field +  " = @value WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("value", value);
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
        public DeviceDTO GetDevice(int id)
        {
            SqlConnection con = null;
            List<DeviceDTO> list = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "SELECT name, type, description, image_url, bought_date, warranty_date, action "
                            + "FROM device "
                            + "WHERE id = @id AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", id);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    string name = dr["name"].ToString();
                    string type = dr["type"].ToString();
                    string description = dr["description"].ToString();
                    string image = dr["image_url"].ToString();
                    DateTime boughtDate = DateTime.Parse(dr["bought_date"].ToString());
                    DateTime warrantyDate = DateTime.Parse(dr["warranty_date"].ToString());
                    bool action = bool.Parse(dr["action"].ToString());
                    if (list == null) list = new List<DeviceDTO>();
                    return new DeviceDTO { name = name, type = type, description = description, image = image, boughtDate = boughtDate, warrantyDate = warrantyDate };
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
            return null;
        }
        public List<DeviceDTO> GetDevices()
        {
            SqlConnection con = null;
            List<DeviceDTO> list = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "SELECT id, name, action FROM device WHERE status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string name = dr["name"].ToString();
                    bool action = bool.Parse(dr["action"].ToString());
                    if (list == null) list = new List<DeviceDTO>();
                    list.Add(new DeviceDTO { id = id, name = name, action = action });
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
        }
        public List<DeviceDTO> GetDevices(int roomId, string searchValue)
        {
            SqlConnection con = null;
            List<DeviceDTO> list = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "SELECT id, name, action FROM device "
                            + "WHERE room_id = @roomId AND status = 1 AND name LIKE @name";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("roomId", roomId);
                cmd.Parameters.AddWithValue("name", "%" + searchValue + "%");
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string name = dr["name"].ToString();
                    bool action = bool.Parse(dr["action"].ToString());
                    if (list == null) list = new List<DeviceDTO>();
                    list.Add(new DeviceDTO { id = id, name = name, action = action });
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
        }
        public List<DeviceDTO> GetDevices(string searchValue)
        {
            SqlConnection con = null;
            List<DeviceDTO> list = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "SELECT id, name, action FROM device "
                            + "WHERE status = 1 AND name LIKE @name";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("name", "%" + searchValue + "%");
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string name = dr["name"].ToString();
                    bool action = bool.Parse(dr["action"].ToString());
                    if (list == null) list = new List<DeviceDTO>();
                    list.Add(new DeviceDTO { id = id, name = name, action = action });
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
        }
        public List<DeviceDTO> GetDevices(int roomId)
        {
            SqlConnection con = null;
            List<DeviceDTO> list = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "SELECT id, name FROM device WHERE room_id = @roomId AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("roomId", roomId);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string name = dr["name"].ToString();
                    bool action = bool.Parse(dr["action"].ToString());
                    if (list == null) list = new List<DeviceDTO>();
                    list.Add(new DeviceDTO { id = id, name = name, action = action });
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
        }
        public List<DeviceDTO> GetDevicesNoneRoom()
        {
            SqlConnection con = null;
            List<DeviceDTO> list = null;
            try
            {
                con = DBHelper.GetConnectionInstance();
                string sql = "SELECT id, name FROM device WHERE room_id IS NULL AND status = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string name = dr["name"].ToString();
                    bool action = bool.Parse(dr["action"].ToString());
                    if (list == null) list = new List<DeviceDTO>();
                    list.Add(new DeviceDTO { id = id, name = name, action = action });
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
