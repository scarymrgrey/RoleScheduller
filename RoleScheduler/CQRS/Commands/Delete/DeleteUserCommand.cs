using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler
{
    using RoleScheduler.Attributes;
    using RoleScheduler.Entities;

    [Admin]
    [CommonUser]
    class DeleteUserCommand : Command
    {
        public User User { get; set; }

        public override void Execute()
        {
            User.Active = false;
        }
    }
}
