using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataObjects.AdoNet
{
    // Data access object for Device
    // ** DAO Pattern

    public class DeviceDao : IDeviceDao
    {
        static Db db = new Db();

        public int AddDevice(Device device)
        {
            string sql =
            @"INSERT INTO tblDevice (name, description, categoryId, boughtDate, warrantyDate, image, statusId) 
                VALUES(@name, @description, @categoryId, @boughtDate, @warrantyDate, @image, @statusId)";

            object[] parms = Take(device);

            return db.Insert(sql, parms);
        }

        public bool UpdateDevice(Device device)
        {
            string sql =
            @"UPDATE tblDevice 
                SET name = @Name, 
                description = @Description, 
                categoryId = @CategoryId, 
                boughtDate = @BoughtDate, 
                warrantyDate = @WarrantyDate 
                WHERE id = @Id";

            object[] parms = Take(device);

            return db.Update(sql, parms) > 0;
        }

        public bool UpdateDeviceImage(int deviceId, byte[] image)
        {
            string sql =
            @"UPDATE tblDevice SET image = @image WHERE id = @id";

            object[] parms = new object[] { "@image", image, "@id", deviceId };

            return db.Update(sql, parms) > 0;
        }

        public bool UpdateRoomId(int deviceId, int roomId)
        {
            string sql =
            @"UPDATE tblDevice SET roomId = @roomId WHERE id = @id";

            object[] parms = new object[] { "@roomId", roomId, "@id", deviceId };

            return db.Update(sql, parms) > 0;
        }

        public bool UpdateDeviceStatusId(int deviceId, int statusId)
        {
            string sql =
            @"UPDATE tblDevice SET statusId = @statusId WHERE id = @id";

            object[] parms = new object[] { "@statusId", statusId, "@id", deviceId };

            return db.Update(sql, parms) > 0;
        }

        public bool RemoveRoomId(int roomId)
        {
            string sql =
            @"UPDATE tblDevice SET roomId = @newRoomId WHERE roomId = @roomId";

            object[] parms = new object[] { "@newRoomId", -1, "@roomId", roomId };

            return db.Update(sql, parms) > 0;
        }

        public bool DeleteDevice(int deviceId, int statusInactiveId)
        {
            string sql =
            @"UPDATE tblDevice SET statusId = @statusInactiveId WHERE id = @id";

            object[] parms = new object[] { "@statusInactiveId", statusInactiveId, "@id", deviceId };

            return db.Update(sql, parms) > 0;
        }

        public Device GetDevice(int deviceId, int statusInactiveId)
        {
            string sql =
            @"SELECT id, name, categoryId, description, image, boughtDate, warrantyDate, roomId, statusId 
                FROM tblDevice 
                WHERE id = @id AND statusId <> @statusInactiveId";

            object[] parms = new object[] { "@id", deviceId, "@statusInactiveId", statusInactiveId };

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<Device> GetDevices(int statusInactiveId, int startRow, int pageSize)
        {
            string sql =
            @"SELECT id, name, categoryId, description, image, boughtDate, warrantyDate, roomId, statusId 
                FROM tblDevice 
                WHERE statusId <> @statusInactiveId
                ORDER BY id
                OFFSET @startRow ROWS
                FETCH NEXT @pageSize ROWS ONLY";

            object[] parms = new object[] { "@statusInactiveId", statusInactiveId, "@startRow", startRow, "@pageSize", pageSize };

            return db.Read(sql, Make, parms).ToList();
        }

        public List<Device> GetDevices(int roomId, string searchValue, int statusInactiveId, int startRow, int pageSize)
        {
            string sql =
            @"SELECT id, name, categoryId, description, image, boughtDate, warrantyDate, roomId, statusId
                FROM tblDevice 
                WHERE roomId = @roomId AND statusId <> @statusInactiveId AND name LIKE @name
                ORDER BY id
                OFFSET @startRow ROWS
                FETCH NEXT @pageSize ROWS ONLY";

            object[] parms = new object[] 
            { 
                "@roomId", roomId,
                "@statusInactiveId", statusInactiveId, 
                "@name", "%" + searchValue + "%",
                "@startRow", startRow,
                "@pageSize", pageSize
            };

            return db.Read(sql, Make, parms).ToList();
        }

        public List<Device> GetDevices(string searchValue, int statusInactiveId, int startRow, int pageSize)
        {
            string sql =
            @"SELECT id, name, categoryId, description, image, boughtDate, warrantyDate, roomId, statusId  
                FROM tblDevice 
                WHERE statusId <> @statusInactiveId AND name LIKE @name
                ORDER BY id
                OFFSET @startRow ROWS
                FETCH NEXT @pageSize ROWS ONLY";

            object[] parms = new object[]
            {
                "@statusInactiveId", statusInactiveId,
                "@name", "%" + searchValue + "%",
                "@startRow", startRow,
                "@pageSize", pageSize
            };

            return db.Read(sql, Make, parms).ToList();
        }

        public List<Device> GetDevices(int roomId, int statusInactiveId)
        {
            string sql =
            @"SELECT id, name 
                FROM tblDevice 
                WHERE roomId = @roomId AND statusId <> @statusInactiveId";

            object[] parms = new object[]
            {
                "@roomId", roomId,
                "@statusInactiveId", statusInactiveId
            };

            Func<IDataReader, Device> Make = reader =>
            new Device
            {
                Id = reader["id"].AsId(),
                Name = reader["name"].AsString()
            };

            return db.Read(sql, Make, parms).ToList();
        }

        public List<Device> GetDevicesNoneRoom(int statusInactiveId)
        {
            string sql =
            @"SELECT id, name 
                FROM tblDevice 
                WHERE roomId IS NULL AND statusId <> @statusInactiveId";

            object[] parms = new object[] { "@statusInactiveId", statusInactiveId };

            Func<IDataReader, Device> Make = reader =>
            new Device
            {
                Id = reader["id"].AsId(),
                Name = reader["name"].AsString()
            };

            return db.Read(sql, Make, parms).ToList();
        }

        public int GetDevicesCount(int statusInactiveId)
        {
            string sql =
            @"SELECT COUNT(*) AS count 
                FROM tblDevice 
                WHERE statusId <> @statusInactiveId";

            object[] parms = new object[] { "@statusInactiveId", statusInactiveId };

            Func<IDataReader, int> Make = reader => reader["count"].AsInt();

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public int GetDevicesCount(int roomId, string searchValue, int statusInactiveId)
        {
            string sql =
            @"SELECT COUNT(*) AS count
                FROM tblDevice 
                WHERE roomId = @roomId AND statusId <> @statusInactiveId AND name LIKE @name";

            object[] parms = new object[]
            {
                "@roomId", roomId,
                "@statusInactiveId", statusInactiveId,
                "@name", "%" + searchValue + "%"
            };

            Func<IDataReader, int> Make = reader => reader["count"].AsInt();

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public int GetDevicesCount(string searchValue, int statusInactiveId)
        {
            string sql =
            @"SELECT COUNT(*) AS count
                FROM tblDevice 
                WHERE statusId <> @statusInactiveId AND name LIKE @name";

            object[] parms = new object[] { "@statusInactiveId", statusInactiveId, "@name", "%" + searchValue + "%" };

            Func<IDataReader, int> Make = reader => reader["count"].AsInt();

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<dynamic> GetDevicesByFixedTime(int min, int max, int statusInactiveId)
        {
            string sql =
            @"SELECT d.id, d.name, r.times 
                FROM (
                    SELECT deviceId, COUNT(*) AS times
                    FROM tblRequest
                    GROUP BY deviceId
                    HAVING COUNT(*) >= @min AND COUNT(*) <= @max
                ) r JOIN tblDevice d ON r.deviceId = d.id AND d.statusId <> @statusInactiveId";

            object[] parms = new object[] { "@min", min, "@max", max, "@statusInactiveId", statusInactiveId };

            Func<IDataReader, dynamic> Make = reader =>
            new
            {
                DeviceId = reader["id"].AsId(),
                DeviceName = reader["name"].AsString(),
                FixedTimes = reader["times"].AsInt()
            };

            return db.Read(sql, Make, parms).ToList();
        }

        public List<dynamic> GetDevicesByStatus(bool isActive, string startDate, string finishDate, int statusInactiveId)
        {
            string temp = isActive ? "NOT" : "";

            string sql =
            @"SELECT id, name "
                + "FROM tblDevice "
                + "WHERE id " + temp + " IN ("
                + "    SELECT deviceId "
                + "    FROM tblRequest "
                + "    WHERE (requestDate >= @startDate AND requestDate <= @finishDate) "
                + "    OR (finishDate >= @startDate AND finishDate <= @finishDate) "
                + "    OR (requestDate <= @startDate AND finishDate >= @finishDate)"
                + ") AND statusId <> @statusInactiveId";

            object[] parms = new object[] { "@startDate", startDate, "@finishDate", finishDate, "@statusInactiveId", statusInactiveId };

            Func<IDataReader, dynamic> Make = reader =>
            new
            {
                DeviceId = reader["id"].AsId(),
                DeviceName = reader["name"].AsString(),
            };

            return db.Read(sql, Make, parms).ToList();
        }

        static Func<IDataReader, Device> Make = reader =>
           new Device
           {
               Id = reader["id"].AsId(),
               Name = reader["name"].AsString(),
               Description = reader["description"].AsString(),
               CategoryId = reader["categoryId"].AsInt(),
               Image = reader["image"].AsByteArray(),
               BoughtDate = reader["boughtDate"].AsDateTime(),
               WarrantyDate = reader["warrantyDate"].AsDateTime(),
               RoomId = reader["roomId"].AsInt(),
               StatusId = reader["statusId"].AsInt()
           };

        object[] Take(Device device)
        {
            return new object[]  
            {
                "@Id", device.Id,
                "@Name", device.Name,
                "@Description", device.Description,
                "@CategoryId", device.CategoryId,
                "@Image", device.Image,
                "@BoughtDate", device.BoughtDate,
                "@WarrantyDate", device.WarrantyDate,
                "@RoomId", device.RoomId,
                "@StatusId", device.StatusId
            };
        }

    }
}
