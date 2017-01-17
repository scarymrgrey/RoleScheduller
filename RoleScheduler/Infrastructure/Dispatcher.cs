using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler.Infrastructure
{
    using System.Reflection;
    using RoleScheduler.CQRS.Queries;

    public class Dispatcher
    {
        readonly Attribute _currentUser;
        public Dispatcher()
        {
            _currentUser = CurrentUser.User;
        }

        public void Push(Command command)
        {

            var doesUserHavePermission = new CheckOperationLegalityQuery() {Command = command,RequestedUser = _currentUser}.Execute();
            if (doesUserHavePermission)
            {
                Console.WriteLine(string.Format("Command {0} successfully pushed",command.GetType().Name));
            }
            else
            {
                throw new Exception("Have no permissions!");
            }
        }
    }
}
