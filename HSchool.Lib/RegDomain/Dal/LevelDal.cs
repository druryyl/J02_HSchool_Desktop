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

    public interface ILevelDal :
        IInsert<LevelModel>,
        IUpdate<LevelModel>,
        IDelete<ILevelKey>,
        IGetData<LevelModel, ILevelKey>,
        IListData<LevelModel, IGradeKey>
    {
    }
    public class LevelDal : ILevelDal
    {
        public void Insert(LevelModel level)
        {
            //  QUERY
            var sql = @"
                INSERT INTO
                    HSOL_Level (
                        LevelID, LevelName, GradeID)
                VALUES (
                        @LevelID, @LevelName, @GradeID)";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@LevelID", level.LevelID, SqlDbType.VarChar);
            dp.AddParam("@LevelName", level.LevelName, SqlDbType.VarChar);
            dp.AddParam("@GradeID", level.GradeID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Update(LevelModel level)
        {
            //  QUERY
            var sql = @"
                UPDATE
                    HSOL_Level 
                SET
                    LevelName = @LevelName,
                    GradeID = @GradeID
                WHERE
                    LevelID = @LevelID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@LevelID", level.LevelID, SqlDbType.VarChar);
            dp.AddParam("@LevelName", level.LevelName, SqlDbType.VarChar);
            dp.AddParam("@GradeID", level.GradeID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Delete(ILevelKey level)
        {
            //  QUERY
            var sql = @"
                DELETE
                    HSOL_Level 
                WHERE
                    LevelID = @LevelID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@LevelID", level.LevelID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public LevelModel GetData(ILevelKey level)
        {
            //  QUERY
            var sql = @"
                SELECT
                    aa.LevelID, aa.LevelName, aa.GradeID,
                    ISNULL(bb.GradeName, '') GradeName
                FROM
                    HSOL_Level aa
                    LEFT JOIN HSOL_Grade bb ON aa.GradeID = bb.GradeID
                WHERE
                    aa.LevelID = @LevelID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@LevelID", level.LevelID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.ReadSingle<LevelModel>(sql, dp);
        }

        public IEnumerable<LevelModel> ListData(IGradeKey filter)
        {
            //  QUERY
            var sql = @"
                SELECT
                    aa.LevelID, aa.LevelName, aa.GradeID,
                    ISNULL(bb.GradeName, '') GradeName
                FROM
                    HSOL_Level aa
                    LEFT JOIN HSOL_Grade bb ON aa.GradeID = bb.GradeID
                WHERE
                    aa.GradeID = @GradeID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@GradeID", filter.GradeID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.Read<LevelModel>(sql, dp);
        }
    }
}
