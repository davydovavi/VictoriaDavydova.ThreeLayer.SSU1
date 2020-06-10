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
    public class BaseAward:IBaseAwards
    {
        private string _myConnectionString = @"Data Source=DESKTOP-7FJQ5G2\SQLEXPRESS;Initial Catalog=UsersAwards;Integrated Security=True";
        public string AddAward(VictoriaDavydova.ThreeLayer.SSU.Entities.Award award)
        {
            using (var connection = new SqlConnection(_myConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddAward";
                    command.Parameters.Add("Title", SqlDbType.Char).Value = award.title;
                    var rowCount = command.ExecuteNonQuery();
                    return "Award successfully added. Rows Added = " + rowCount;
                }
                catch (Exception exception)
                {
                    return exception.StackTrace;
                }
            }
        }

        public string DeleteAward(int idAward)
        {
            using (var connection = new SqlConnection(_myConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DeleteAward";
                    command.Parameters.Add("IDAward", SqlDbType.Int).Value = idAward;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return "Award with id " + idAward + " successfully deleted";
                    }
                    else
                    {
                        return "Failed to remove award with id " + idAward;
                    }
                }
                catch (Exception exception)
                {
                    return exception.StackTrace;
                }
            }
        }

        public IEnumerable<VictoriaDavydova.ThreeLayer.SSU.Entities.Award> GetAllAwards()
        {
            List<VictoriaDavydova.ThreeLayer.SSU.Entities.Award> listAwards = new List<VictoriaDavydova.ThreeLayer.SSU.Entities.Award>();
            using (var connection = new SqlConnection(_myConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetAllAwards";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listAwards.Add(new VictoriaDavydova.ThreeLayer.SSU.Entities.Award((int)dataReader["IDAward"], (string)dataReader["Title"]));
                    }
                }
            }
            return listAwards;
        }

        public VictoriaDavydova.ThreeLayer.SSU.Entities.Award GetAwardByID(int idAward)
        {
            VictoriaDavydova.ThreeLayer.SSU.Entities.Award award = null;
            using (var connection = new SqlConnection(_myConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "FindAwardByID";
                command.Parameters.Add("@IDUser", SqlDbType.NChar).Value = idAward;
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        award = new VictoriaDavydova.ThreeLayer.SSU.Entities.Award((string)dataReader["Title"]);
                    }
                }
            }
            return award;

        }
    }
}
