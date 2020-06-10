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
    public class BaseUser:IBaseUsers
    {
        private string _myConnectionString = @"Data Source=DESKTOP-7FJQ5G2;Initial Catalog=UsersAwards;Integrated Security=True";
        public string AddUser(VictoriaDavydova.ThreeLayer.SSU.Entities.User user)
        {
            using (var connection = new SqlConnection(_myConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddUser";
                    command.Parameters.Add("FullName", SqlDbType.Char).Value = user.fullName;
                    command.Parameters.Add("DateOfBirth", SqlDbType.Char).Value = user.dateOfBirth;
                    command.Parameters.Add("Age", SqlDbType.Char).Value = user.age;
                    var rowCount = command.ExecuteNonQuery();
                    return "User successfully added. Rows Added = " + rowCount;
                }
                catch (Exception exception)
                {
                    return exception.StackTrace;
                }
            }
        }

        public string DeleteUser(int idUser)
        {
            using (var connection = new SqlConnection(_myConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DeleteUser";
                    command.Parameters.Add("IDUser", SqlDbType.Int).Value = idUser;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return "User with id " + idUser + " successfully deleted";
                    }
                    else
                    {
                        return "Failed to remove user with id " + idUser;
                    }
                }
                catch (Exception exception)
                {
                    return exception.StackTrace;
                }
            }
        }

        public IEnumerable<VictoriaDavydova.ThreeLayer.SSU.Entities.User> GetAllUsers()
        {
            List<VictoriaDavydova.ThreeLayer.SSU.Entities.User> listUsers = new List<VictoriaDavydova.ThreeLayer.SSU.Entities.User>();
            using (var connection = new SqlConnection(_myConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetAllUsers";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listUsers.Add(new VictoriaDavydova.ThreeLayer.SSU.Entities.User((int)dataReader["IDUser"], (string)dataReader["FullName"], (string)dataReader["DateOfBirth"], (int)dataReader["Age"]));
                    }
                }
            }
            return listUsers;
        }

        public VictoriaDavydova.ThreeLayer.SSU.Entities.User GetUserByID(int idUser)
        {
            VictoriaDavydova.ThreeLayer.SSU.Entities.User user = null;
            using (var connection = new SqlConnection(_myConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "FindUserByID";
                command.Parameters.Add("@IDUser", SqlDbType.NChar).Value = idUser;
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                      user =  new VictoriaDavydova.ThreeLayer.SSU.Entities.User((string)dataReader["FullName"], (string)dataReader["DateOfBirth"], (int)dataReader["Age"]);
                    }
                }
            }
            return user;
            
        }
    }
}
