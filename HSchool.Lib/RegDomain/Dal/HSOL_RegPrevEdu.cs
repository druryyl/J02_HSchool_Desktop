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

    public interface IRegPrevEduDal :
        IInsert<RegPrevEduModel>,
        IDelete<IRegKey>,
        IListData<RegPrevEduModel, IRegKey>
    {
    }
    public class RegPrevEduDal : IRegPrevEduDal
    {
        public void Insert(RegPrevEduModel reg)
        {
            //  QUERY
            var sql = @"
                INSERT INTO
                    HSOL_RegPrevEdu (
                        RegID, PreviousEdu, PreviousEduType,
                        YearAttended, HighestGrade, IsAce)
                VALUES (
                        @RegID, @PreviousEdu, @PreviousEduType,
                        @YearAttended, @HighestGrade, @IsAce)";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", reg.RegID, SqlDbType.VarChar);
            dp.AddParam("@PreviousEdu", reg.PreviousEdu, SqlDbType.VarChar);
            dp.AddParam("@PreviousEduType", reg.PreviousEduType, SqlDbType.VarChar);
            dp.AddParam("@YearAttended", reg.YearAttended, SqlDbType.VarChar);
            dp.AddParam("@HighestGrade", reg.HighestGrade, SqlDbType.VarChar);
            dp.AddParam("@IsAce", reg.IsAce, SqlDbType.VarChar);


            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Delete(IRegKey reg)
        {
            //  QUERY
            var sql = @"
                DELETE
                    HSOL_RegPrevEdu 
                WHERE
                    RegID = @RegID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", reg.RegID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public IEnumerable<RegPrevEduModel> ListData(IRegKey filter)
        {
            //  QUERY
            var sql = @"
                SELECT
                    RegID, PreviousEdu, PreviousEduType,
                    YearAttended, HighestGrade, IsAce
                FROM
                    HSOL_RegPrevEdu
                WHERE
                    RegID = RegID";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", filter.RegID, SqlDbType.VarChar);


            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.Read<RegPrevEduModel>(sql, dp);
        }
    }
}
