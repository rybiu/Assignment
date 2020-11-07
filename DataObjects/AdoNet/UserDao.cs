using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataObjects.AdoNet
{
    // Data access object for User
    // ** DAO Pattern

    public class UserDao : IUserDao
    {
        static Db db = new Db();

        public int AddUser(User user)
        {
            string sql = 
            @"INSERT INTO tblUser (username, password, roleId, statusId) 
              VALUES(@username, @password, @roleId, @statusId)";
            
            object[] parms = Take(user);

            return db.Insert(sql, parms);
        }

        public bool UpdateUser(User user)
        {
            string sql =
            @"UPDATE tblUser SET username = @username, password = @password WHERE id = @id";

            object[] parms = Take(user);

            return db.Update(sql, parms) > 0;
        }

        public bool UpdateRoomId(int userId, int roomId)
        {
            string sql =
            @"UPDATE tblUser SET roomId = @roomId WHERE id = @id";

            object[] parms = new object[] { "@roomId", roomId, "@id", userId };

            return db.Update(sql, parms) > 0;
        }

        public bool RemoveRoomId(int roomId)
        {
            string sql =
            @"UPDATE tblUser SET roomId = @newRoomId WHERE roomId = @roomId";

            object[] parms = new object[] { "@newRoomId", -1, "@roomId", roomId };

            return db.Update(sql, parms) > 0;
        }

        public bool DeleteUser(int userId, int statusId)
        {
            string sql =
            @"UPDATE tblUser SET statusId = @statusId WHERE id = @id";

            object[] parms = new object[] { "@statusId", statusId, "@id", userId };

            return db.Delete(sql, parms) > 0;
        }

        public User GetUser(int userId, int statusId)
        {
            string sql =
            @"SELECT id, username, password, roleId, roomId, statusId 
                FROM tblUser WHERE id = @id AND statusId = @statusId";

            object[] parms = { "@id", userId, "@statusId", statusId };

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public User GetUser(string username, string password, int statusId)
        {
            string sql =
            @"SELECT id, username, password, roleId, roomId, statusId
                FROM tblUser
                WHERE username = @username AND password = @password AND statusId = @statusId";

            object[] parms = { "@username", username, "@password", password, "@statusId", statusId };

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<User> GetUsers(string searchValue, int roleId, int statusId, int startRow, int pageSize)
        {
            string sql =
            @"SELECT id, username, password, roleId, roomId, statusId
                FROM tblUser 
                WHERE roleId = @roleId AND statusId = @statusId AND username LIKE @searchValue
                ORDER BY id
                OFFSET @startRow ROWS
                FETCH NEXT @pageSize ROWS ONLY";

            object[] parms = 
            { 
                "@roleId", roleId, 
                "@statusId", statusId,
                "searchValue", "%" + searchValue + "%",
                "@startRow", startRow, 
                "@pageSize", pageSize 
            };

            return db.Read(sql, Make, parms).ToList();
        }

        public int GetUsersCount(string searchValue, int roleId, int statusId)
        {
            string sql =
            @"SELECT COUNT(*) AS count
                FROM tblUser 
                WHERE roleId = @roleId AND statusId = @statusId AND username LIKE @searchValue";

            object[] parms = { "@roleId", roleId, "@statusId", statusId, "searchValue", "%" + searchValue + "%" };

            Func<IDataReader, int> Make = reader => reader["count"].AsInt();

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<User> GetUsers(int roomId, int roleId, int statusId)
        {
            string sql =
            @"SELECT id, username 
                FROM tblUser 
                WHERE roomId = @roomId AND roleId = @roleId AND statusId = @statusId";

            object[] parms = 
            { 
                "@roomId", roomId, 
                "@roleId", roleId, 
                "@statusId", statusId
            };

            Func<IDataReader, User> Make = reader =>
               new User
               {
                   Id = reader["id"].AsId(),
                   Username = reader["username"].AsString(),
               };

            return db.Read(sql, Make, parms).ToList();
        }

        public List<User> GetUsersNoneRoom(int roleId, int statusId)
        {
            string sql =
            @"SELECT id, username 
                FROM tblUser 
                WHERE roomId IS NULL AND roleId = @roleId AND statusId = @statusId";

            object[] parms = { "@roleId", roleId, "@statusId", statusId };

            Func<IDataReader, User> Make = reader =>
               new User
               {
                   Id = reader["id"].AsId(),
                   Username = reader["username"].AsString(),
               };

            return db.Read(sql, Make, parms).ToList();
        }

        public bool IsExist(string username)
        {
            string sql =
            @"SELECT id
                FROM tblUser 
                WHERE username = @username";

            object[] parms = { "@username", username };

            Func<IDataReader, int> Make = reader => reader["id"].AsId();

            return db.Read(sql, Make, parms).FirstOrDefault() > 0;
        }

        static Func<IDataReader, User> Make = reader =>
           new User
           {
               Id = reader["id"].AsId(),
               Username = reader["username"].AsString(),
               Password = reader["password"].AsString(),
               RoleId = reader["roleId"].AsInt(),
               RoomId = reader["roomId"].AsInt(),
               StatusId = reader["statusId"].AsInt()
           };

        object[] Take(User user)
        {
            return new object[]  
            {
                "@Id", user.Id,
                "@Username", user.Username,
                "@Password", user.Password,
                "@RoleId", user.RoleId,
                "@RoomId", user.RoomId,
                "@StatusId", user.StatusId
            };
        }

    }
}
