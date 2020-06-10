using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriaDavydova.ThreeLayer.SSU.DAL.AbstractDAL
{
    public interface IBaseUsers
    {
        string AddUser(VictoriaDavydova.ThreeLayer.SSU.Entities.User user);
        string DeleteUser(int idUser);
        IEnumerable<VictoriaDavydova.ThreeLayer.SSU.Entities.User> GetAllUsers();
        VictoriaDavydova.ThreeLayer.SSU.Entities.User GetUserByID(int idUser);
        //int AddAwardForUser(int idUser, int idAward);
    }
}
