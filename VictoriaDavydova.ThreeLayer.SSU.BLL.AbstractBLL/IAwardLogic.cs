using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriaDavydova.ThreeLayer.SSU.BLL.AbstractBLL
{
    public interface IAwardLogic
    {
        string AddAward(string title);
        string DeleteByID(int idAward);
        List<VictoriaDavydova.ThreeLayer.SSU.Entities.Award> GetAllAwards();
        VictoriaDavydova.ThreeLayer.SSU.Entities.Award GetAwardByID(int idAward);
        //string ShowAllAwards();
    }
}
