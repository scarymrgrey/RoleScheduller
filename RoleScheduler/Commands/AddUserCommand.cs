using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler
{
    using RoleScheduler.Attributes;

    [Admin]
    class AddUserCommand : Command
    {
        public override void Execute()
        {
            // 1) create new user
            // 2) send email
        }
    }
}
