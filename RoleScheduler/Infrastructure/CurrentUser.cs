using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler.Infrastructure
{
     class CurrentUser
    {
         public static Attribute User { get; set; } // Context.Request emulation due to simplify code

         static CurrentUser() { }
    }
}
