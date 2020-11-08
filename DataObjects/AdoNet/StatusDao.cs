using BusinessObjects;
using System;
using System.Data;
using System.Linq;

namespace DataObjects.AdoNet
{
    // Data access object for Status
    // ** DAO Pattern

    public class StatusDao : IStatusDao
    {
        static Db db = new Db();

        public Status GetStatus(int statusId)
        {
            string sql =
            @"SELECT id, name, description 
              FROM tblStatus 
              WHERE id = @id";

            object[] parms = { "@id", statusId };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public Status GetStatus(string statusName)
        {
            string sql =
            @"SELECT id, name, description 
              FROM tblStatus 
              WHERE name = @name";

            object[] parms = { "@name", statusName };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        static Func<IDataReader, Status> Make = reader =>
           new Status
           {
               Id = reader["id"].AsId(),
               Name = reader["name"].AsString(),
               Description = reader["description"].AsString()
           };

        object[] Take(Status status)
        {
            return new object[]  
            {
                "@Id", status.Id,
                "@name", status.Name,
                "@description", status.Description
            };
        }

    }
}
