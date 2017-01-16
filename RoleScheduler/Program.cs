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
            RunFirstRequestProcessing();

            RunSecondRequestProcessing();
        }

        static void RunFirstRequestProcessing()
        {
            //first web request
            CurrentUser.User = new AdminAttribute();
            new AddUserFromAdminCommand().Execute(); // Everything OK!
        }

        static void RunSecondRequestProcessing()
        {
            //second web request
            CurrentUser.User = new CommonUserAttribute();
            new TryAddUserFromUserCommand().Execute(); // Exception!
        }
    }
}
