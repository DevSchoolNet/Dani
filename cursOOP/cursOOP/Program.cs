using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OOPLibrary;

namespace cursOOP {
    class Program {
        static void Main(string[] args) {
            List<IUser> userList = new List<IUser>();
            var user = new User("asdf");
            userList.Add(user);
            var user1 = new Employee();
            userList.Add(user1);
            var user2 = new FrontOffice();
            userList.Add(user2);
            var user3 = new BackOffice();
            userList.Add(user3);
            var user4 = new User();
            userList.Add(user4);
            var user5 = new User("qwer");
            userList.Add(user5);
            var user6 = new User();
            var user7 = new User();
            var user8 = new User("rqweq");
            var user9 = new User();
            var user10 = new User();
            GC.Collect();
            Thread.Sleep(3000);
            Console.ReadKey();

            if (userList[2] is FrontOffice) {
                var fo = userList[2] as FrontOffice;
                fo.AddCustomer("zzz", "123");
            }
        }
    }
}
