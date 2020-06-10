using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace VictoriaDavydova.ThreeLayer.SSU1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Add user");
            Console.WriteLine("2 - Delete user");
            Console.WriteLine("3 - Show all users");
            Console.WriteLine("4 - Add award");
            Console.WriteLine("5 - Delete award");
            Console.WriteLine("6 - Show all awards");
            Console.WriteLine("7 - Add award for user");
            Console.WriteLine("8 - Show users with awards");

            while (true)
            {
                Console.WriteLine("Enter action: ");
                var action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        LogicPL.AddUser();
                        break;
                    case "2":
                        LogicPL.DeleteUser();
                        break;
                    case "3":
                        LogicPL.GetAllUsers();
                        break;
                    case "4":
                        LogicPL.AddAward();
                        break;
                    case "5":
                        LogicPL.DeleteAward();
                        break;
                    case "6":
                        LogicPL.GetAllAwards();
                        break;
                    case "7":
                        LogicPL.AddAwardForUser();
                        break;
                    case "8":
                        LogicPL.GetAllUsersWithAwards();
                        break;
                    default:
                        break;
                }
            }

        }
    
    }
}
