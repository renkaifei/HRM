using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace HRM.Repository
{
    internal class DatabaseContext
    {
        protected string dbName = "";
        private string connectionString = "";
        public DatabaseContext()
        {
            dbName = "hrm.db";
            connectionString = string.Format("Data Source={0};",dbName);
        }
        public async Task<DataTable> FillDataAsync(string sql,params SqliteParameter[] sqlParams)
        {
            using(SqliteConnection conn = new SqliteConnection(connectionString))
            {
                using(SqliteCommand cmd = new SqliteCommand(sql,conn))
                {
                    cmd.Parameters.AddRange(sqlParams);
                    await conn.OpenAsync();
                    using(SqliteDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = reader.GetSchemaTable();
                        return dt;
                    }
                }
            }
        }
        public async Task ExecuteNoQueryAsync(string sql,params SqliteParameter[] sqlParams)
        {
            using(SqliteConnection conn = new SqliteConnection(connectionString))
            {
                using(SqliteCommand cmd = new SqliteCommand(sql,conn))
                {
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

    }
}