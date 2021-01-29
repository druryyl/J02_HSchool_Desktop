using Dapper;
using Intersolusi.Helper.DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersolusi.Helper.Dapper
{
    public static class DapperHelper
    {
        public static void AddParam(this DynamicParameters cmd, string param, object value, SqlDbType type)
        {
            DbType dbType = TypeConvertor.ToDbType(type);
            if (dbType == DbType.AnsiString)
            {
                var length = value.ToString().Length;
                cmd.Add(param, value, dbType, ParameterDirection.Input, length);
            }
            else
            {
                cmd.Add(param, value, dbType, ParameterDirection.Input);
            }
        }

        public static IEnumerable<T> Read<T>(this SqlConnection conn, string sql, DynamicParameters param = null)
        {
            var result = conn.Query<T>(sql, param);
            if (result.Any())
                return result;
            else
                return default;
        }
        public static T ReadSingle<T>(this SqlConnection conn, string sql, DynamicParameters param)
        {
            return conn.QueryFirstOrDefault<T>(sql, param);
        }

        public static int InsertBulk<T>(this SqlConnection conn, string sql, IEnumerable<T> listData)
        {
            return conn.Execute(sql, listData);
        }

        public static void Execute(this string sql, string connString, DynamicParameters param = null)
        {
            using (var conn = new SqlConnection(connString))
                conn.Execute(sql, param);
        }

        public static T ReadSingle<T>(this string sql, string connString, DynamicParameters param = null)
        {
            using (var conn = new SqlConnection(connString))
                return conn.ReadSingle<T>(sql, param);
        }

        public static IEnumerable<T> Read<T>(this string sql, string connString, DynamicParameters param = null)
        {
            using (var conn = new SqlConnection(connString))
                return conn.Read<T>(sql, param);
        }


    }
}