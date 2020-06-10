using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictoriaDavydova.ThreeLayer.SSU.BLL.AbstractBLL;

namespace VictoriaDavydova.ThreeLayer.SSU.BLL.UsersPlusAwardsBLL
{
    public class AwardByUserLogic:IAwardByUserLogic
    {
        VictoriaDavydova.ThreeLayer.SSU.DAL.UsersPlusAwardsDAL.BaseAwardsByUsers baseAwardsByUsers = new VictoriaDavydova.ThreeLayer.SSU.DAL.UsersPlusAwardsDAL.BaseAwardsByUsers();

        public string AddAwardByUser(int idUser, int idAward)
        {
            return baseAwardsByUsers.AddAwardByUser(new VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser(idUser, idAward));
        }

        public string DeleteByIdUserIdAward(int idUser, int idAward)
        {
            return baseAwardsByUsers.DeleteAwardByUser(idUser, idAward);
        }

        public List<VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser> GetAllAwardsByUsers()
        {
            List<VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser> usersAwards = new List<Entities.AwardByUser>();
            foreach (var usersawards in baseAwardsByUsers.GetAllUsersWithAwards())
            {
                usersAwards.Add(usersawards);
            }
            return usersAwards;
        }
    }
}
