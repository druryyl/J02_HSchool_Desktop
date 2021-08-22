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

    public interface IRegDal :
        IInsert<RegModel>,
        IUpdate<RegModel>,
        IDelete<IRegKey>,
        IGetData<RegModel, IRegKey>,
        IListData<RegModel, IAcademicYearKey>
    {
    }
    public class RegDal : IRegDal
    {
        public void Insert(RegModel reg)
        {
            //  QUERY
            var sql = @"
                INSERT INTO
                    HSOL_Reg (
                        RegID, RegDate, PersonID, 
                        AcademicYearID, GradeID)
                VALUES (
                        @RegID, @RegDate, @PersonID, 
                        @AcademicYearID, @GradeID)";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", reg.RegID, SqlDbType.VarChar);
            dp.AddParam("@RegDate", reg.RegDate, SqlDbType.DateTime);
            dp.AddParam("@PersonID", reg.PersonID, SqlDbType.VarChar);
            dp.AddParam("@AcademicYear", reg.AcademicYearID, SqlDbType.VarChar);
            dp.AddParam("@GradeID", reg.GradeID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Update(RegModel reg)
        {
            //  QUERY
            var sql = @"
                UPDATE
                    HSOL_Reg 
                SET
                    RegDate = @RegDate,
                    PersonID = @PersonID, 
                    AcademicYearID = @AcademicYearID
                    GradeID = @GradeID, 
                WHERE
                    RegID = @RegID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", reg.RegID, SqlDbType.VarChar);
            dp.AddParam("@RegDate", reg.RegDate, SqlDbType.DateTime);
            dp.AddParam("@PersonID", reg.PersonID, SqlDbType.VarChar);
            dp.AddParam("@GradeID", reg.GradeID, SqlDbType.VarChar);
            dp.AddParam("@AcademicYearID", reg.AcademicYearID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Delete(IRegKey reg)
        {
            //  QUERY
            var sql = @"
                DELETE
                    HSOL_Reg 
                WHERE
                    RegID = @RegID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", reg.RegID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public RegModel GetData(IRegKey reg)
        {
            //  QUERY
            var sql = @"
                SELECT
                    aa.RegID, aa.RegDate, aa.PersonID, 
                    aa.AcademicYearID, aa.GradeID, 
                    ISNULL(bb.PersonName, '') PersonName,
                    ISNULL(bb.BirthDate, '') BirthDate,
                    ISNULL(bb.BirthPlace, '') BirthPlace,
                    ISNULL(bb.Gender, '') Gender,
                    ISNULL(bb.FullAddr, '') FullAddr,
                    ISNULL(bb.ShortAddr, '') ShortAddr,
                    ISNULL(bb.City, '') City,
                    ISNULL(bb.PhoneNo, '') PhoneNo,
                    ISNULL(bb.Email, '') Email,
                    ISNULL(cc.AcademicYearName, '') AcademicYearName,
                    ISNULL(dd.GradeName, '') GradeName
                FROM
                    HSOL_Reg aa
                    LEFT JOIN HSOL_Person bb ON aa.PersonID = bb.PersonID
                    LEFT JOIN HSOL_AcademicYear cc ON  aa.AcademicYearID = cc.AcademicYearID
                    LEFT JOIN HSOL_Grade dd ON aa.GradeID = cc.GradeID
                WHERE
                    aa.RegID = @RegID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@RegID", reg.RegID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.ReadSingle<RegModel>(sql, dp);
        }

        public IEnumerable<RegModel> ListData(IAcademicYearKey filter)
        {
            //  QUERY
            var sql = @"
                SELECT
                    aa.RegID, aa.RegDate, aa.PersonID, 
                    aa.AcademicYearID, aa.GradeID, 
                    ISNULL(bb.PersonName, '') PersonName,
                    ISNULL(bb.BirthDate, '') BirthDate,
                    ISNULL(bb.BirthPlace, '') BirthPlace,
                    ISNULL(bb.Gender, '') Gender,
                    ISNULL(bb.FullAddr, '') FullAddr,
                    ISNULL(bb.ShortAddr, '') ShortAddr,
                    ISNULL(bb.City, '') City,
                    ISNULL(bb.PhoneNo, '') PhoneNo,
                    ISNULL(bb.Email, '') Email,
                    ISNULL(cc.AcademicYearName, '') AcademicYearName,
                    ISNULL(dd.GradeName, '') GradeName
                FROM
                    HSOL_Reg aa
                    LEFT JOIN HSOL_Person bb ON aa.PersonID = bb.PersonID
                    LEFT JOIN HSOL_AcademicYear cc ON  aa.AcademicYearID = cc.AcademicYearID
                    LEFT JOIN HSOL_Grade dd ON aa.GradeID = cc.GradeID
                WHERE
                    aa.AcademicYearID = @AcademicYearID";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@AcademicYearID", filter.AcademicYearID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.Read<RegModel>(sql, dp);
        }
    }
}
