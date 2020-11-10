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
                        object[] arrObj;
                        int fieldCount = reader.FieldCount;
                        DataTable schemaDT = reader.GetSchemaTable();
                        DataTable dt = new DataTable();
                        for(int i =0;i<schemaDT.Rows.Count ;i++)
                        {
                            dt.Columns.Add(new DataColumn(){ 
                                ColumnName = schemaDT.Rows[i]["ColumnName"].ToString(),
                                DataType = Type.GetType(schemaDT.Rows[i]["DataType"].ToString()),
                                AllowDBNull = Convert.ToBoolean(schemaDT.Rows[i]["AllowDBNull"])
                              });
                        }
                        dt.BeginLoadData();
                        while(await reader.ReadAsync())
                        {
                            arrObj = new object[fieldCount];
                            reader.GetValues(arrObj);
                            for(int i =0;i<fieldCount;i++)
                            {
                                Console.Write(arrObj[i]);
                            }
                            dt.LoadDataRow(arrObj,true);
                        }
                        dt.EndLoadData();
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