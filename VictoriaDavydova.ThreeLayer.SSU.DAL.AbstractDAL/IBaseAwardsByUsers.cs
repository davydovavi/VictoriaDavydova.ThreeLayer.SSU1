using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriaDavydova.ThreeLayer.SSU.DAL.AbstractDAL
{
    public interface IBaseAwardsByUsers
    {
        string AddAwardByUser(VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser awardByUser);
        string DeleteAwardByUser(int idUser, int idAward);
        //IEnumerable<VictoriaDavydova.ThreeLayer.SSU.Entities.Award> ShowAwardsByUserId(int idUser);
        IEnumerable<VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser> GetAllUsersWithAwards();
    }
}
