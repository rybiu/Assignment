using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.AdoNet
{
    // Data access object for Category
    // ** DAO Pattern

    public class RequestDao : IRequestDao
    {
        static Db db = new Db();

        public int AddRequest(int userId, string requestDescription, int statusRequestInitialId, int deviceId)
        {
            string sql =
            @"INSERT INTO tblRequest (userId, requestDate, requestDescription, statusId, deviceId) 
                VALUES (@userId, @requestDate, @requestDescription, @statusId, @deviceId)";

            object[] parms = Take(new Request() {  
                UserId = userId, 
                RequestDate = DateTime.Now,
                RequestDescription = requestDescription,
                StatusId = statusRequestInitialId,
                DeviceId = deviceId
            });

            return db.Insert(sql, parms);
        }

        public bool StartRequest(int id, int workerId, int statusRequestStartId)
        {
            string sql =
            @"UPDATE tblRequest 
                SET statusId = @statusId,
                startDate = @startDate, 
                workerId = @workerId 
                WHERE id = @id";

            object[] parms = Take(new Request()
            {
                Id = id,
                StatusId = statusRequestStartId,
                StartDate = DateTime.Now,
                WorkerId = workerId
            });

            return db.Update(sql, parms) > 0;
        }

        public bool FinishRequest(int id, string repairDescription, int statusRequestFinishId)
        {
            string sql =
            @"UPDATE tblRequest 
                SET statusId = @statusId,
                finishDate = @finishDate, 
                repairDescription = @repairDescription 
                WHERE id = @id";

            object[] parms = Take(new Request()
            {
                Id = id,
                StatusId = statusRequestFinishId,
                FinishDate = DateTime.Today,
                RepairDescription = repairDescription
            });

            return db.Update(sql, parms) > 0;
        }

        public List<Request> GetRequests(int deviceId, int startRow, int pageSize)
        {
            string sql =
            @"SELECT id, userId, deviceId, workerId, statusId, requestDate, requestDescription, 
                startDate, finishDate, repairDescription 
                FROM tblRequest 
                WHERE deviceId = @deviceId
                ORDER BY id
                OFFSET @startRow ROWS
                FETCH NEXT @pageSize ROWS ONLY";

            object[] parms = new object[] { "@deviceId", deviceId, "@startRow", startRow, "@pageSize", pageSize };

            return db.Read(sql, Make, parms).ToList();
        }

        public int GetRequestsCount(int deviceId)
        {
            string sql =
            @"SELECT COUNT(*) AS count
                FROM tblRequest 
                WHERE deviceId = @deviceId";

            object[] parms = new object[] { "@deviceId", deviceId };

            Func<IDataReader, int> Make = reader => reader["count"].AsInt();

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        static Func<IDataReader, Request> Make = reader =>
           new Request
           {
               Id = reader["id"].AsId(),
               RequestDate = reader["requestDate"].AsDateTime(),
               RequestDescription = reader["requestDescription"].AsString(),
               StartDate = reader["startDate"].AsDateTime(),
               FinishDate = reader["finishDate"].AsDateTime(),
               RepairDescription = reader["repairDescription"].AsString(),
               UserId = reader["userId"].AsId(),
               DeviceId = reader["deviceId"].AsId(),
               WorkerId = reader["workerId"].AsId(),
               StatusId = reader["statusId"].AsId(),
           };

        object[] Take(Request request)
        {
            return new object[]  
            {
                "@Id", request.Id,
                "@requestDate", request.RequestDate,
                "@requestDescription", request.RequestDescription,
                "@startDate", request.StartDate,
                "@finishDate", request.FinishDate,
                "@repairDescription", request.RepairDescription,
                "@userId", request.UserId,
                "@deviceId", request.DeviceId,
                "@workerId", request.WorkerId,
                "@statusId", request.StatusId
            };
        }

    }
}
