using BusinessObjects;
using System.Collections.Generic;

namespace DataObjects
{
    
    public interface IUserDao : IBelongRoom
    {
        int AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int userId, int statusId);
        User GetUser(int userId, int statusId);
        User GetUser(string username, string password, int statusId);
        List<User> GetUsers(string searchValue, int roleId, int statusId, int startRow, int pageSize);
        int GetUsersCount(string searchValue, int roleId, int statusId);
        List<User> GetUsers(int roomId, int roleId, int statusId);
        List<User> GetUsersNoneRoom(int roleId, int statusId);
        bool IsExist(string username);
    }
}
