using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleScheduler
{
    using RoleScheduler.Attributes;
    using RoleScheduler.Entities;
    using RoleScheduler.Infrastructure;

    class Program
    {
        static void Main(string[] args)
        {
            RunFirstRequestProcessing(); // Everything OK!

            // RunSecondRequestProcessing(); // Exception!

            GroupDeleteByAdminRequest(); // OK when admin calls base commands

            SelfDeleteByAdminRequest();// OK when CommonUser calls base commands



        }

        static void RunFirstRequestProcessing()
        {
            //first web request
            CurrentUser.User = new AdminAttribute();
            new AddUserFromAdminCommand().Execute();
        }

        

        static void RunSecondRequestProcessing()
        {
            //second web request
            CurrentUser.User = new CommonUserAttribute();
            new TryAddUserFromUserCommand().Execute(); 
        }

        static void GroupDeleteByAdminRequest()
        {
            CurrentUser.User = new AdminAttribute();
            new GroupDeleteByAdminCommand() {Users = new List<User>() {new User(),new User()} }.Execute();
        }
        static void SelfDeleteByAdminRequest()
        {
            CurrentUser.User = new CommonUserAttribute();
            new SelfDeleteByUserCommand().Execute();
        }
        
    }
}
