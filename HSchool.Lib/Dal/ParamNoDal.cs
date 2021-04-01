using Dapper;
using Intersolusi.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Dal
{
    public class ParamNoDal : IParamNoDal
    {

        public void Insert(ParamNoModel paramNo)
        {
            var sql = @"
                INSERT INTO 
                    HSOL_ParamNo (
                        ParamID, ParamValue)
                VALUES (
                        @ParamID, @ParamValue) ";

            var dp = new DynamicParameters();
            dp.AddParam("@ParamID", paramNo.ParamID, SqlDbType.VarChar);
            dp.AddParam("@ParamValue", paramNo.ParamValue, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Update(ParamNoModel paramNo)
        {
            var sql = @"
                UPDATE
                    HSOL_ParamNo 
                SET
                    ParamValue = @ParamValue
                WHERE
                    ParamID = @ParamID ";

            var dp = new DynamicParameters();
            dp.AddParam("@ParamID", paramNo.ParamID, SqlDbType.VarChar);
            dp.AddParam("@ParamValue", paramNo.ParamValue, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Delete(IParamNoKey key)
        {
            var sql = @"
                DELETE 
                    HSOL_ParamNo
                WHERE
                    ParamID = @ParamID ";

            var dp = new DynamicParameters();
            dp.AddParam("@ParamID", key.ParamID, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public ParamNoModel GetData(IParamNoKey key)
        {
            var sql = @"
                SELECT
                    ParamID, ParamValue
                FROM
                    HSOL_ParamNo
                WHERE
                    ParamID = @ParamID ";

            var dp = new DynamicParameters();
            dp.AddParam("@ParamID", key.ParamID, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.ReadSingle<ParamNoModel>(sql, dp);
        }

        public IEnumerable<ParamNoModel> ListData()
        {
            var sql = @"
                SELECT
                    ParamValue
                FROM
                    HSOL_ParamNo ";

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.Read<ParamNoModel>(sql);
        }
    }
}
