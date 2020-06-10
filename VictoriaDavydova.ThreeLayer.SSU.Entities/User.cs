using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoriaDavydova.ThreeLayer.SSU.Entities
{
    public class User
    {
        public int idUser { get; set; }
        public string fullName { get; set; }
        public string dateOfBirth { get; set; }
        public int age { get; set; }
        //public List<Award> usersAwards { get; set; }

        public User(int idUser, string fullName, string dateOfBirth, int age)
        {
            this.idUser = idUser;
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
            this.age = age;
        }

       
        public User(string fullName, string dateOfBirth, int age)
        {
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
            this.age = age;
        }

        
        public override string ToString()
        {
            return $"{idUser} {fullName} {dateOfBirth} {age}";

        }
    }
}
