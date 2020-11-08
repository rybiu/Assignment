using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataObjects.AdoNet
{
    // Data access object for Category
    // ** DAO Pattern

    public class CategoryDao : ICategoryDao
    {
        static Db db = new Db();

        public List<Category> GetCategories(int statusId)
        {
            string sql =
            @"SELECT id, name, statusId
                FROM tblCategory 
                WHERE statusId = @statusId";

            object[] parms = { "@statusId", statusId };

            return db.Read(sql, Make, parms).ToList();
        }

        public Category GetCategory(int categoryId, int statusId)
        {
            string sql =
            @"SELECT id, name, statusId
                FROM tblCategory 
                WHERE id = @id AND statusId = @statusId";

            object[] parms = { "@id", categoryId, "@statusId", statusId };

            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public int IsExist(string categoryName, int statusId)
        {
            string sql =
            @"SELECT id, name, statusId
                FROM tblCategory 
                WHERE name = @name AND statusId = @statusId";

            object[] parms = { "@name", categoryName, "@statusId", statusId };

            Category category = db.Read(sql, Make, parms).FirstOrDefault();

            return category != null ? category.Id : -1;
        }

        static Func<IDataReader, Category> Make = reader =>
           new Category
           {
               Id = reader["id"].AsId(),
               Name = reader["name"].AsString(),
               StatusId = reader["statusId"].AsInt()
           };

        object[] Take(Category category)
        {
            return new object[]  
            {
                "@Id", category.Id,
                "@Name", category.Name,
                "@StatusId", category.StatusId
            };
        }

    }
}
