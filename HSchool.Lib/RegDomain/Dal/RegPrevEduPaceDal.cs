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

    public interface IRegPrevEduPaceDal :
        IInsert<RegPrevEduPaceModel>,
        IDelete<IRegKey>,
        IListData<RegPrevEduPaceModel, IRegKey>
    {
    }
    public class RegPrevEduPaceDal : IRegPrevEduPaceDal
    {
        public void Insert(RegPrevEduPaceModel reg)
        {
            //  QUERY
            var sql = @"
                INSERT INTO
                    HSOL_RegPrevEduPace (
                        RegID, PaceTypeID, LevelID)
                VALUES (
                        @RegID, @PaceTypeID, @LevelID)";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", reg.RegID, SqlDbType.VarChar);
            dp.AddParam("@PaceTypeID", reg.PaceTypeID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Delete(IRegKey reg)
        {
            //  QUERY
            var sql = @"
                DELETE
                    HSOL_RegPrevEduPace 
                WHERE
                    RegID = @RegID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", reg.RegID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public IEnumerable<RegPrevEduPaceModel> ListData(IRegKey filter)
        {
            //  QUERY
            var sql = @"
                SELECT
                    RegID, PaceTypeID
                FROM
                    HSOL_RegPrevEduPace
                WHERE
                    RegID = @RegID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", filter.RegID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.Read<RegPrevEduPaceModel>(sql, dp);
        }
    }
}
