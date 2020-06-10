using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriaDavydova.ThreeLayer.SSU.Entities
{
    public class AwardByUser
    {
        public int idUser;
        public int idAward;

        public AwardByUser()
        {

        }

        public AwardByUser(int idUser, int idAward)
        {
            this.idUser = idUser;
            this.idAward = idAward;
        }
       
    }
}
