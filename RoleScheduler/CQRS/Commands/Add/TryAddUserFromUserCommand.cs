using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler
{
    using RoleScheduler.Attributes;
    using RoleScheduler.Infrastructure;

    [CommonUser]
    public class TryAddUserFromUserCommand : Command
    {
        public override void Execute()
        {
            new Scheduler().AddToQueue(new AddUserCommand());
        }
    }
}
