using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler
{
    using RoleScheduler.Attributes;
    using RoleScheduler.Entities;
    using RoleScheduler.Infrastructure;

    [Admin]
    class GroupDeleteByAdminCommand : Command
    {
        public List<User>  Users { get; set; }
        public override void Execute()
        {
            foreach (var user in Users)
            {
                new Dispatcher().Push(new DeleteUserCommand() { User = user });
            }
        }
    }
}
