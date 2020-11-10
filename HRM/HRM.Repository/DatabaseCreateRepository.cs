using System;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using HRM.Repository.Factory;

namespace HRM.Repository
{
    internal class DatabaseCreateRepository:DatabaseContext,ICreateRepository
    {
        public async Task CreateAsync()
        {
            StringBuilder sb = new StringBuilder();
            //添加用户表
            sb.Append("create table if not exists user(");
            sb.Append("userID INTEGER AUTO_INCREMENT");
            sb.Append(",userName TEXT default '' not null");
            sb.Append(",pwd TEXT not null default ''");
            sb.Append(",primary key(userID));");

            await ExecuteNoQueryAsync(sb.ToString());

            sb.Clear();
            sb.Append("create table if not exists employee(userID integer auto_increment");
            sb.Append(",employeeCode text not null default ''");
            sb.Append(",sex integer not null default 0"); // 0:男,1:女
            sb.Append(",birthDate text not null default ''");
            sb.Append(",designInstituteEnterDate DATETIME not null");
            sb.Append(",workDate datetime not null");
            sb.Append(",researchInstitute datetime not null");
            sb.Append(",technicalTitle varchar(128) not null default ''");
            sb.Append(",technicalTitleDate datetime not null");
            sb.Append(",");

        }
    }
}