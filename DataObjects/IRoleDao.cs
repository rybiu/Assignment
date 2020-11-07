using BusinessObjects;

namespace DataObjects
{

    public interface IRoleDao
    {

        Role GetRole(int roleId);
        Role GetRole(string roleName);

    }
}
