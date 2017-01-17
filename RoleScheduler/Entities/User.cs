using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler.Entities
{
    class User
    {
        public bool Active { get; set; }

        public User()
        {
            Active = true;
        }
    }
}
