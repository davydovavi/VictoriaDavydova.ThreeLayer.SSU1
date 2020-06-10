using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriaDavydova.ThreeLayer.SSU.BLL.AbstractBLL
{
    public interface IUserLogic
    {
        string AddUser(string fullName, string dateOfBirth, int age);
        string DeleteByID(int idUser);
        //string ShowAllUsers();
        List<VictoriaDavydova.ThreeLayer.SSU.Entities.User> GetAllUsers();
        VictoriaDavydova.ThreeLayer.SSU.Entities.User GetUserByID(int idUser);
        //string Find(string fullName);
    }
}
