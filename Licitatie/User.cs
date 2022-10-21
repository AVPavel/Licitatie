using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licitatie
{
    public class User
    {
        public static int UserTest(string username, string password)
        {
            string sql = "Select * from users where @UserName = username AND @PassWord = password";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ConnString")))
            {
                var number = connection.Query(sql, new { UserName = username, PassWord = password }).Count();
                return number;
            }

        }
    }
}
