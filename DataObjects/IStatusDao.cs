using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{

    public interface IStatusDao
    {
        Status GetStatus(int statusId);
        Status GetStatus(string statusName);

    }
}
