using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler.CQRS.Queries
{
    using System.Reflection;
    using RoleScheduler.Entities;
    using RoleScheduler.Infrastructure;

    class GetCurrentUserQuery
    {

        public User Execute()
        {
            return new User() {Active = true}; // Data layer mock
        }
    }
}
