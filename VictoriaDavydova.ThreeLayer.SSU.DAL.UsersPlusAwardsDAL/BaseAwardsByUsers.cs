using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VictoriaDavydova.ThreeLayer.SSU.DAL.AbstractDAL;

namespace VictoriaDavydova.ThreeLayer.SSU.DAL.UsersPlusAwardsDAL
{
    public class BaseAwardsByUsers:IBaseAwardsByUsers
    {
        string myConnectionString = @"Data Source=DESKTOP-7FJQ5G2\SQLEXPRESS;Initial Catalog=UsersAwards;Integrated Security=True";
        public string AddAwardByUser(VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser awardByUser)
        {
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddAwardForUser";
                    command.Parameters.Add("IDUser", SqlDbType.Char).Value = awardByUser.idUser;
                    command.Parameters.Add("IDAward", SqlDbType.Char).Value = awardByUser.idAward;
                    var rowCount = command.ExecuteNonQuery();
                    return "AwardByUser successfully added. Rows Added = " + rowCount;
                }
                catch (Exception exception)
                {
                    return exception.StackTrace;
                }
            }
        }

        public string DeleteAwardByUser(int idUser, int idAward)
        {
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DeleteAwardForUser";
                    command.Parameters.Add("IDUser", SqlDbType.Int).Value = idUser;
                    command.Parameters.Add("IDAward", SqlDbType.Int).Value = idAward;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return "Award with id " + idAward + " by id user " + idUser + "successfully deleted";
                    }
                    else
                    {
                        return "Failed to remove award with id " + idAward + " by id user " + idUser;
                    }
                }
                catch (Exception exception)
                {
                    return exception.StackTrace;
                }
            }
        }

        public IEnumerable<VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser> GetAllUsersWithAwards()
        {
            List<VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser> listUsers = new List<VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser>();
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetAllUsersWithAwards";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listUsers.Add(new VictoriaDavydova.ThreeLayer.SSU.Entities.AwardByUser((int)dataReader["IDUser"], (int)dataReader["IDAward"]));
                    }
                }
            }
            return listUsers;
        }

        /*public IEnumerable<VictoriaDavydova.ThreeLayer.SSU.Entities.Award> ShowAwardsByUserId(int idUser)
        {
            List<VictoriaDavydova.ThreeLayer.SSU.Entities.Award> listAwards = new List<VictoriaDavydova.ThreeLayer.SSU.Entities.Award>();
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("IDUser", SqlDbType.Int).Value = idUser;
                command.CommandText = "GetAwardsForUser";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listAwards.Add(new VictoriaDavydova.ThreeLayer.SSU.Entities.Award((int)dataReader["ID"], (int)dataReader["IDAward"]));

                    }
                }
            }
            return listAwards;
        }*/
    }
}
