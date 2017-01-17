using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler
{
    using RoleScheduler.Attributes;
    using RoleScheduler.Infrastructure;

    [Admin]
    class AddUserFromAdminCommand :Command
    {
        public override void Execute()
        {
            new Scheduler().AddToQueue(new AddUserCommand());
            new Scheduler().AddToQueue(new SendEmailComand());
        }
    }
}
