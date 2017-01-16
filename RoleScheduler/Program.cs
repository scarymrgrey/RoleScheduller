using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler
{
    using RoleScheduler.Attributes;
    using RoleScheduler.Infrastructure;

    class Program
    {
        static void Main(string[] args)
        {
            RunRequestProcessing();
        }

        static void RunRequestProcessing()
        {
            CurrentUser.User = new AdminAttribute();
            new AddUserFromAdminCommand().Execute(); // Everything OK!

            CurrentUser.User = new CommonUserAttribute();
            new TryAddUserFromUserCommand().Execute(); // Exception!
        }
    }
}
