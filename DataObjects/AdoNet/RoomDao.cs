using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataObjects.AdoNet
{
    // Data access object for Room
    // ** DAO Pattern

    public class RoomDao : IRoomDao
    {
        static Db db = new Db();

        public int AddRoom(Room room)
        {
            string sql =
            @"INSERT INTO tblRoom (name, statusId) VALUES (@name, @statusId)";

            object[] parms = Take(room);

            return db.Insert(sql, parms);
        }

        public bool UpdateRoom(Room room)
        {
            string sql =
            @"UPDATE tblRoom SET name = @name WHERE id = @id";

            object[] parms = Take(room);

            return db.Update(sql, parms) > 0;
        }

        public bool DeleteRoom(int roomId, int statusRoomInactiveId)
        {
            string sql =
            @"UPDATE tblRoom SET statusId = @statusId WHERE id = @id";

            object[] parms = Take(new Room { Id = roomId, StatusId = statusRoomInactiveId });

            return db.Delete(sql, parms) > 0;
        }

        public List<Room> GetRooms(string searchValue, int statusRoomActiveId, 
            int statusUserActiveId, int statusDeviceInactiveId, int startRow, int pageSize)
        {
            string sql =
            @"SELECT id, name, ISNULL(numberUser, 0) AS numberUser, 
                ISNULL(numberDevice, 0) AS numberDevice, statusId
                FROM tblRoom r 
                LEFT JOIN ( 
                    SELECT roomId, COUNT(*) AS numberUser 
                    FROM tblUser 
                    WHERE statusId = @statusUserActiveId 
                    GROUP BY roomId 
                ) a ON r.id = a.roomId 
                LEFT JOIN ( 
                    SELECT roomId, COUNT(*) as numberDevice 
                    FROM tblDevice 
                    WHERE statusId <> @statusDeviceInactiveId  
                    GROUP BY roomId 
                ) d on r.id = d.roomId 
                WHERE r.statusId = @statusId AND name LIKE @searchValue
                ORDER BY id
                OFFSET @startRow ROWS
                FETCH NEXT @pageSize ROWS ONLY";

            object[] parms = 
            { 
                "@statusUserActiveId", statusUserActiveId,
                "@statusDeviceInactiveId", statusDeviceInactiveId,
                "@statusId", statusRoomActiveId,
                "searchValue", "%" + searchValue + "%",
                "@startRow", startRow,
                "@pageSize", pageSize
            };

            return db.Read(sql, Make, parms).ToList();
        }

        public int GetRoomsCount(string searchValue, int statusRoomActiveId, 
            int statusUserActiveId, int statusDeviceInactiveId)
        {
            string sql =
            @"SELECT COUNT(*) AS count
                FROM tblRoom r 
                LEFT JOIN ( 
                    SELECT roomId, COUNT(*) AS numberUser 
                    FROM tblUser 
                    WHERE statusId = @statusUserActiveId 
                    GROUP BY roomId 
                ) a ON r.id = a.roomId 
                LEFT JOIN ( 
                    SELECT roomId, COUNT(*) as numberDevice 
                    FROM tblDevice 
                    WHERE statusId <> @statusDeviceInactiveId  
                    GROUP BY roomId 
                ) d on r.id = d.roomId 
                WHERE r.statusId = @statusId AND name LIKE @searchValue";

            object[] parms =
            {
                "@statusUserActiveId", statusUserActiveId,
                "@statusDeviceInactiveId", statusDeviceInactiveId,
                "@statusId", statusRoomActiveId,
                "searchValue", "%" + searchValue + "%"
            };

            Func<IDataReader, int> Make = reader => reader["count"].AsInt();

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        static Func<IDataReader, Room> Make = reader =>
           new Room
           {
               Id = reader["id"].AsId(),
               Name = reader["name"].AsString(),
               NumberUser = reader["numberUser"].AsInt(),
               NumberDevice = reader["numberDevice"].AsInt(),
               StatusId = reader["statusId"].AsId()
           };

        object[] Take(Room room)
        {
            return new object[]  
            {
                "@id", room.Id,
                "@name", room.Name,
                "@statusId", room.StatusId
            };
        }

    }
}
