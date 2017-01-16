using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler.Entities
{
    class ScheduleTask
    {
        public Command Command { get; set; }

        public Attribute CurrentUserAttribute { get; set; }

        public bool AlreadyExecuted { get; set; }
    }
}
