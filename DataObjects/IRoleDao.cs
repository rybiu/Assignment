using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{

    public interface IRoleDao
    {

        Role GetRole(int roleId);
        Role GetRole(string roleName);

    }
}
