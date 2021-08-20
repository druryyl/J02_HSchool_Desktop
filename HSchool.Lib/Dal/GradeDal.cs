using Dapper;
using HSchool.Lib.Helper;
using HSchool.Lib.Models.Entity;
using Nuna.Lib.DataAccessHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Dal
{
    public interface IGradeDal :
        IInsert<GradeEntity>,
        IUpdate<GradeEntity>,
        IDelete<IGradeKey>,
        IGetData<GradeEntity, IGradeKey>,
        IListData<GradeEntity>
    {
    }
    public class GradeDal : IGradeDal
    {
        public void Insert(GradeEntity grade)
        {
            //  QUERY
            var sql = @"
                INSERT INTO
                    VAKSN_Grade (
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

        public void Update(GradeEntity grade)
        {
            //  QUERY
            var sql = @"
                UPDATE
                    VAKSN_Grade 
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
                    VAKSN_Grade 
                WHERE
                    GradeID = @GradeID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@GradeID", grade.GradeID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public GradeEntity GetData(IGradeKey grade)
        {
            //  QUERY
            var sql = @"
                SELECT
                    GradeID, GradeName
                FROM
                    VAKSN_Grade 
                WHERE
                    GradeID = @GradeID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@GradeID", grade.GradeID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.ReadSingle<GradeEntity>(sql, dp);
        }

        public IEnumerable<GradeEntity> ListData()
        {
            //  QUERY
            var sql = @"
                SELECT
                    GradeID, GradeName
                FROM
                    VAKSN_Grade";

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.Read<GradeEntity>(sql);
        }
    }
}
