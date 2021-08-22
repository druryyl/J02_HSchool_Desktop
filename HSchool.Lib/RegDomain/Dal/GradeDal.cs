using Dapper;
using HSchool.Lib.Helper;
using HSchool.Lib.RegDomain.Models.Entity;
using Nuna.Lib.DataAccessHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Dal
{
    public interface IGradeDal :
        IInsert<GradeModel>,
        IUpdate<GradeModel>,
        IDelete<IGradeKey>,
        IGetData<GradeModel, IGradeKey>,
        IListData<GradeModel>
    {
    }
    public class GradeDal : IGradeDal
    {
        public void Insert(GradeModel grade)
        {
            //  QUERY
            var sql = @"
                INSERT INTO
                    HSOL_Grade (
                        GradeID, GradeName)
                VALUES (
                        @GradeID, @GradeName)";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@GradeID", grade.GradeID, SqlDbType.VarChar);
            dp.AddParam("@GradeName", grade.GradeName, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Update(GradeModel grade)
        {
            //  QUERY
            var sql = @"
                UPDATE
                    HSOL_Grade 
                SET
                    GradeName = @GradeName
                WHERE
                    GradeID = @GradeID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@GradeID", grade.GradeID, SqlDbType.VarChar);
            dp.AddParam("@GradeName", grade.GradeName, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Delete(IGradeKey grade)
        {
            //  QUERY
            var sql = @"
                DELETE
                    HSOL_Grade 
                WHERE
                    GradeID = @GradeID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@GradeID", grade.GradeID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public GradeModel GetData(IGradeKey grade)
        {
            //  QUERY
            var sql = @"
                SELECT
                    GradeID, GradeName
                FROM
                    HSOL_Grade 
                WHERE
                    GradeID = @GradeID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@GradeID", grade.GradeID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.ReadSingle<GradeModel>(sql, dp);
        }

        public IEnumerable<GradeModel> ListData()
        {
            //  QUERY
            var sql = @"
                SELECT
                    GradeID, GradeName
                FROM
                    HSOL_Grade";

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.Read<GradeModel>(sql);
        }
    }
}
