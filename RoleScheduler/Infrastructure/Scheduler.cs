using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler.Infrastructure
{
    using System.Reflection;

    public class Scheduler
    {
        readonly Attribute _currentUser;
        public Scheduler()
        {
            _currentUser = CurrentUser.User;
        }

        public void AddToQueue(Command command)
        {

            var doesUserHavePermission = command.GetType().GetCustomAttribute(CurrentUser.User.GetType()) != null;
            if (doesUserHavePermission)
            {
                Console.WriteLine("Command successfully added to queue");
            }
            else
            {
                throw new Exception("Have no permissions!");
            }
        }
    }
}
