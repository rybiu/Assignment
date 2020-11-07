using BusinessObjects;
using System;
using System.Data;
using System.Linq;

namespace DataObjects.AdoNet
{
    // Data access object for Role
    // ** DAO Pattern

    public class RoleDao : IRoleDao
    {
        static Db db = new Db();

        public Role GetRole(int roleId)
        {
            string sql =
            @"SELECT id, name 
              FROM tblRole 
              WHERE id = @id";

            object[] parms = { "@id", roleId };

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public Role GetRole(string roleName)
        {
            string sql =
            @"SELECT id, name
              FROM tblRole 
              WHERE name = @name";

            object[] parms = { "@name", roleName };

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        static Func<IDataReader, Role> Make = reader =>
           new Role
           {
               Id = reader["id"].AsId(),
               Name = reader["name"].AsString(),
           };

        object[] Take(Role role)
        {
            return new object[]  
            {
                "@id", role.Id,
                "@name", role.Name
            };
        }

    }
}
