using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler
{
    using RoleScheduler.Attributes;

    [Admin]
    [CommonUser]
    class SendEmailComand : Command
    {
        public override void Execute()
        {
            // 2) send email
        }
    }
}
