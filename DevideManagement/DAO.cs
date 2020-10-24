using DeviceManagement.DAO;
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
                if (list == null) list = new List<DeviceDTO>();
                list.Add(new DeviceDTO { id = id, name = name });
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
                if (list == null) list = new List<DeviceDTO>();
                list.Add(new DeviceDTO { id = id, name = name });
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

        public bool SetRoomId(int id, int roomId)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE device SET room_id = @roomId WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            if (roomId != -1) cmd.Parameters.AddWithValue("roomId", roomId);
            if (roomId == -1) cmd.Parameters.AddWithValue("roomId", DBNull.Value);
            cmd.Parameters.AddWithValue("id", id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }


        public List<dynamic> GetDevicesByFixedTime(int min, int max)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT d.id, d.name, r.times " +
                    "FROM (" +
                    "	SELECT device_id, COUNT(*) AS times" +
                    "	FROM request" +
                    "	GROUP BY device_id" +
                    "	HAVING COUNT(*) >= @min AND COUNT(*) <= @max" +
                    ") r JOIN device d ON r.device_id = d.id AND d.status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("min", min);
            cmd.Parameters.AddWithValue("max", max);
            SqlDataReader dr = cmd.ExecuteReader();
            List<dynamic> result = null;
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string name = dr.GetString(1);
                int time = dr.GetInt32(2);
                if (result == null) result = new List<dynamic>();
                result.Add(new { id = id, name = name, fixedTime = time });
            }
            con.Close();
            return result;
        }
        public List<dynamic> GetDevicesByStatus(bool status, string startDate, string endDate)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string temp = status ? "NOT" : "";
            string sql = "SELECT id, name "
                    + "FROM device "
                    + "WHERE id " + temp + " IN ("
                    + "    SELECT device_id "
                    + "    FROM request "
                    + "    WHERE (request_date >= @startDate AND request_date <= @endDate) "
                    + "    OR (end_date >= @startDate AND end_date <= @endDate) "
                    + "    OR (request_date <= @startDate AND end_date >= @endDate)"
                    + ") AND status = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("startDate", startDate);
            cmd.Parameters.AddWithValue("endDate", endDate);
            SqlDataReader dr = cmd.ExecuteReader();
            List<dynamic> result = null;
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string name = dr.GetString(1);
                if (result == null) result = new List<dynamic>();
                result.Add(new { id = id, name = name });
            }
            con.Close();
            return result;
        }
    }


    public class RoomDAO
    {
        public bool AddRoom(string roomName)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "INSERT INTO room(name) VALUES (@roomName)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("roomName", roomName);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public bool DeleteRoom(int id)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "DELETE FROM room WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
        public bool UpdateRoom(int id, string roomName)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE room SET name = @roomName WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("roomName", roomName);
            cmd.Parameters.AddWithValue("id", id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
    public List<RoomDTO> GetRooms()
    {
        SqlConnection con = DBHelper.GetConnectionInstance();
        if (con.State == ConnectionState.Closed) con.Open();
        string sql = "select id, name, ISNULL(num_user, 0), ISNULL(num_device, 0) from room r " +
                    "left join( "+
                    "select room_id, count(*) as num_user "+
                    "from account " +
                    "where status = 1 " +
                    "group by room_id " +
                    ") a on r.id = a.room_id " +
                    "left join( " +
                    "select room_id, count(*) as num_device "+
                    "from device "+
                    "where status = 1 " +
                    "group by room_id " +
                    ") d on r.id = d.room_id";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr = cmd.ExecuteReader();
        List<RoomDTO> result = null;
        while (dr.Read())
        {
            int id = dr.GetInt32(0);
            string name = dr.GetString(1);
            int numberAccount = dr.GetInt32(2);
            int numberDevide = dr.GetInt32(3);
            if (result == null) result = new List<RoomDTO>();
            result.Add(new RoomDTO() { id = id, name = name, numberAccount = numberAccount, numberDevide = numberDevide });
        }
        con.Close();
        return result;
    }

}

    public class RequestDAO
    {
        public bool AddRequest(int userId, string reqDes, int deviceId)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "INSERT INTO request (user_id, request_date, request_description, request_status, device_id) " +
                "VALUES (@userId, @reqDate, @reqDes, 'SENT', @deviceId)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("userId", userId);
            cmd.Parameters.AddWithValue("reqDate", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("reqDes", reqDes);
            cmd.Parameters.AddWithValue("deviceId", deviceId);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }

        public DataTable GetRequests(int deviceId)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "SELECT id, user_id, worker_id, request_status, request_date, request_description, start_date, end_date, takeover_description FROM request WHERE device_id = @deviceId";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("deviceId", deviceId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable result = new DataTable();
            da.Fill(result);
            con.Close();
            return result;
        }
    
        public bool UpdateStart(int id, int workerId)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE request SET "
                + "request_status = 'STARTED', "
                + "start_date = @start_date, "
                + "worker_id = @worker_id "
                + "WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("start_date", DateTime.Now);
            cmd.Parameters.AddWithValue("worker_id", workerId);
            cmd.Parameters.AddWithValue("id", id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
    
        public bool UpdateEnd(int id, string takeDes)
        {
            SqlConnection con = DBHelper.GetConnectionInstance();
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "UPDATE request SET "
                + "request_status = 'FINISHED', "
                + "end_date = @end_date, "
                + "takeover_description = @takeover_description "
                + "WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("end_date", DateTime.Now);
            cmd.Parameters.AddWithValue("takeover_description", takeDes);
            cmd.Parameters.AddWithValue("id", id);
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return result;
        }
    }

}
