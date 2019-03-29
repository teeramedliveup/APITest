using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMP.Data.Helpers;
using WMP.Models;

namespace WMP.Data.Repositories
{
    public class UsersRepository
    {
        DBHelper DBHelper = null;

        public UsersRepository()
        {
            DBHelper = new DBHelper();
        }

        public users Signin(string username, string password)
        {
            users result = new users();
            //try
            //{
            //    using (IDbConnection db = new SqlConnection(@"Data Source=tech-head-warehouse.database.windows.net;Initial Catalog=TH_WarehouseLog;User ID=TechHeadWH;Password=TeCh|-|e@d\/\/|-|"))
            //    {
            //        string readSp = "select_users";
            //        result = db.Query<users>(readSp, ,commandType: CommandType.StoredProcedure).FirstOrDefault();

            //    }

            //}

            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            if (!(username.Equals("stave6699") && password.Equals("KO1233215")))
            {
                return null;
            }

            return result;
        }
    }
}
