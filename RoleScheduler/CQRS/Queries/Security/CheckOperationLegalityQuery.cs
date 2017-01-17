using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler.CQRS.Queries
{
    using System.Reflection;
    using RoleScheduler.Infrastructure;

    class CheckOperationLegalityQuery
    {
        public Attribute RequestedUser { get; set; }
        public Command Command { get; set; }
        public bool Execute()
        {
            return Command.GetType().GetCustomAttribute(RequestedUser.GetType()) != null;
        }
    }
}
