using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{

    public class Role : BusinessObject
    {
        public enum VALUE { ADMIN, WORKER, USER };

        public int Id { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }

    }
}
