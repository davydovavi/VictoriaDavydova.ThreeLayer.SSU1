using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriaDavydova.ThreeLayer.SSU.BLL.AbstractBLL
{
    public interface IAwardByUserLogic
    {
        string AddAwardByUser(int idUser, int idAward);
        string DeleteByIdUserIdAward(int idUser, int idAward);
        List<VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser> GetAllAwardsByUsers();
    }
}
