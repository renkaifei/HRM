using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using HRM.Domain;
using HRM.Repository.Interface;

namespace HRM.Repository
{
    internal class UserGetOneByNameWithPwdRepository:DatabaseContext,IGetDataRepository
    {
        private UserDomain user;
        public UserGetOneByNameWithPwdRepository(UserDomain user)
        {
            this.user = user;
        } 
        public async Task GetData()
        {
            string sql = "select userID,userName from [user] where loginName = @LoginName and pwd = @Pwd";
            SqliteParameter prmLoginName = new SqliteParameter("@LoginName",SqliteType.Text){ Value = user.LoginName };
            SqliteParameter prmPwd = new SqliteParameter("@Pwd",SqliteType.Text){ Value = user.Pwd };
            DataTable dt = await FillDataAsync(sql,prmLoginName,prmPwd);
            if(dt.Rows.Count == 0) return;
            DataRow row = dt.Rows[0];
            user.UserID = Convert.ToInt32(row["userID"]);
            user.Name = row["userName"] as string;
        }
    }
}