using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriaDavydova.ThreeLayer.SSU.Entities
{
    public class Award
    {
        public int idAward { get; set; }
        public string title { get; set; }
        //public List<User> usersByaward { get; set; }

        public Award(int idAward, string title)
        {
            this.idAward = idAward;
            this.title = title;
        }

        public Award(string title)
        {
            this.title = title;
        }

        public override string ToString()
        {
            return $"{idAward} {title}";
        }
    }
}
