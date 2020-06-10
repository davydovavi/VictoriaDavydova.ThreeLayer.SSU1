using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictoriaDavydova.ThreeLayer.SSU.BLL.AbstractBLL;

namespace VictoriaDavydova.ThreeLayer.SSU.BLL.UsersPlusAwardsBLL
{
    public class AwardLogic:IAwardLogic
    {
        VictoriaDavydova.ThreeLayer.SSU.DAL.UsersPlusAwardsDAL.BaseAward baseAwards = new VictoriaDavydova.ThreeLayer.SSU.DAL.UsersPlusAwardsDAL.BaseAward();
        public string AddAward(string title)
        {
            return baseAwards.AddAward(new VictoriaDavydova.ThreeLayer.SSU.Entities.Award(title));
        }

        public string DeleteByID(int idAward)
        {
            return baseAwards.DeleteAward(idAward);
        }

        public List<VictoriaDavydova.ThreeLayer.SSU.Entities.Award> GetAllAwards()
        {
            List<VictoriaDavydova.ThreeLayer.SSU.Entities.Award> awards = new List<Entities.Award>();
            foreach (var award in baseAwards.GetAllAwards())
            {
                awards.Add(award);
            }
            return awards;
        }

        public VictoriaDavydova.ThreeLayer.SSU.Entities.Award GetAwardByID(int idAward)
        {
            VictoriaDavydova.ThreeLayer.SSU.Entities.Award newAward = null;
            foreach (var award in baseAwards.GetAllAwards())
            {
                if (award.idAward == idAward)
                {
                    newAward = new VictoriaDavydova.ThreeLayer.SSU.Entities.Award(award.idAward, award.title);
                }
            }
            return newAward;
        }
    }
}
