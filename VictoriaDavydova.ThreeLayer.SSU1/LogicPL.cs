using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictoriaDavydova.ThreeLayer.SSU.BLL.AbstractBLL;
using VictoriaDavydova.ThreeLayer.SSU.BLL.UsersPlusAwardsBLL;
using VictoriaDavydova.ThreeLayer.SSU.Entities;

namespace VictoriaDavydova.ThreeLayer.SSU1
{
    public static class LogicPL
    {
        private static IUserLogic userLogic = new UserLogic();
        private static IAwardLogic awardLogic = new AwardLogic();
        private static IAwardByUserLogic awardByUserLogic = new AwardByUserLogic();

        public static void AddUser()
        {
            Console.WriteLine("Enter full name");
            var fullName = Console.ReadLine();

            Console.WriteLine("Enter date of birth");
            var dateOfBirth = Console.ReadLine();

            Console.WriteLine("Enter age");
            var age = Console.ReadLine();

            userLogic.AddUser(fullName, dateOfBirth, int.Parse(age));
        }

        public static void AddAward()
        {
            Console.WriteLine("Enter award's title");
            var title = Console.ReadLine();

            awardLogic.AddAward(title);
        }

        public static void DeleteUser()
        {
            Console.WriteLine("Enter id user for delete");
            int value = int.Parse(Console.ReadLine());

            userLogic.DeleteByID(value);
        }

        public static void DeleteAward()
        {
            Console.WriteLine("Enter id award for delete");
            int value = int.Parse(Console.ReadLine());

            awardLogic.DeleteByID(value);
        }

        public static void AddAwardForUser()
        {
            Console.WriteLine("Eneter user id");
            var idUser = Console.ReadLine();

            Console.WriteLine("Enter award id");
            var idAward = Console.ReadLine();



            awardByUserLogic.AddAwardByUser(int.Parse(idUser), int.Parse(idAward));
        }

        public static void GetAllUsers()
        {
            foreach (var item in userLogic.GetAllUsers())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllAwards()
        {
            foreach (var item in awardLogic.GetAllAwards())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllUsersWithAwards()
        {
            foreach (var item in awardByUserLogic.GetAllAwardsByUsers())
            {
                Console.WriteLine(item);
            }
        }

    }
}
