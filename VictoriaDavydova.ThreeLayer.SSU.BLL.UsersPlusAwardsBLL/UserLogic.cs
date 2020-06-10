using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictoriaDavydova.ThreeLayer.SSU.BLL.AbstractBLL;

namespace VictoriaDavydova.ThreeLayer.SSU.BLL.UsersPlusAwardsBLL
{
    public class UserLogic:IUserLogic
    {
        VictoriaDavydova.ThreeLayer.SSU.DAL.UsersPlusAwardsDAL.BaseUser baseUsers = new VictoriaDavydova.ThreeLayer.SSU.DAL.UsersPlusAwardsDAL.BaseUser();
        public string AddUser(string fullName, string dateOfBirth, int age)
        {
            return baseUsers.AddUser(new VictoriaDavydova.ThreeLayer.SSU.Entities.User(fullName, dateOfBirth, age));
        }

        public string DeleteByID(int idUser)
        {
            return baseUsers.DeleteUser(idUser);
        }

        public List<VictoriaDavydova.ThreeLayer.SSU.Entities.User> GetAllUsers()
        {
            List<VictoriaDavydova.ThreeLayer.SSU.Entities.User> users = new List<Entities.User>();
            foreach (var user in baseUsers.GetAllUsers())
            {
                users.Add(user);
            }
            return users;
        }

        public VictoriaDavydova.ThreeLayer.SSU.Entities.User GetUserByID(int idUser)
        {
            VictoriaDavydova.ThreeLayer.SSU.Entities.User newuser = null;
            foreach (var user in baseUsers.GetAllUsers())
            {
                if (user.idUser == idUser)
                {
                    newuser = new VictoriaDavydova.ThreeLayer.SSU.Entities.User(user.idUser, user.fullName, user.dateOfBirth, user.age);
                }
            }
            return newuser;
        }

        /*public string ShowAllUsers()
        {
            string temp = "List of all users\nIDUser FullName DateOfBirth Age\n";
            foreach (var user in baseUsers.ShowAllUsers())
            {
                temp += $"{user.idUser} {user.fullName} {user.dateOfBirth} {user.age}\n";
            }
            return temp;
        }*/

        /*public string Find(string fullName)
        {
            string temp = "All users with name " + fullName + "\nIDUser FullName DateOfBirth Age\n";
            foreach (var user in baseUsers.FindUser(fullName))
            {
                temp += $"{user.idUser} {user.fullName}  {user.dateOfBirth} {user.age}";
            }
            return temp;
        }*/
    }
}
