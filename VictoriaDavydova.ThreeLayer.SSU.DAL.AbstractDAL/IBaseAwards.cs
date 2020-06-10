using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriaDavydova.ThreeLayer.SSU.DAL.AbstractDAL
{
    public interface IBaseAwards
    {
        string AddAward(VictoriaDavydova.ThreeLayer.SSU.Entities.Award award);
        string DeleteAward(int idAward);
        IEnumerable<VictoriaDavydova.ThreeLayer.SSU.Entities.Award> GetAllAwards();
        VictoriaDavydova.ThreeLayer.SSU.Entities.Award GetAwardByID(int idAward);
    }
}
