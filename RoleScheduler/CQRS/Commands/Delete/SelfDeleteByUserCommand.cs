using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler
{
    using RoleScheduler.Attributes;
    using RoleScheduler.CQRS.Queries;
    using RoleScheduler.Infrastructure;

    [CommonUser]
    class SelfDeleteByUserCommand : Command
    {
        public override void Execute()
        {
            var currentUser = new GetCurrentUserQuery().Execute();
            new Dispatcher().Push(new DeleteUserCommand() {User = currentUser});

        }
    }
}
