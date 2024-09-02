//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day20Concepts
//{
//    public class FirstAndFirstDefault
//    {
//        public void BasicFirstVsFirstDefault()
//        {
//            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            var methodSyntax = numbers.First(x => x > 5);

//            Console.ReadLine();
//        }

//        public void ComplexFirst()
//        {
//            var users = new List<User>()
//            {
//                new User() { Id = 1, UserName = "Admin", Password = "Admin" },
//                new User() { Id = 1, UserName = "UserA", Password = "UserA" },
//                new User() { Id = 1, UserName = "UserB", Password = "UserB" },
//                new User() { Id = 1, UserName = "UserC", Password = "UserC" },
//            };

//            var methodSyntax = users.FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin");

//            var Mixed = (from user in users
//                         select user).FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin");
           
//            Console.ReadLine();
//        }
//    }
//}
