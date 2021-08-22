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

    public interface IStudentDal :
        IInsert<StudentModel>,
        IUpdate<StudentModel>,
        IDelete<IStudentKey>,
        IGetData<StudentModel, IStudentKey>,
        IListData<StudentModel, ILevelKey>
    {
    }
    public class StudentDal : IStudentDal
    {
        public void Insert(StudentModel student)
        {
            //  QUERY
            var sql = @"
                INSERT INTO
                    HSOL_Student (
                        StudentID, PersonID, LevelID)
                VALUES (
                        @StudentID, @PersonID, @LevelID)";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@StudentID", student.StudentID, SqlDbType.VarChar);
            dp.AddParam("@PersonID", student.PersonID, SqlDbType.VarChar);
            dp.AddParam("@LevelID", student.LevelID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Update(StudentModel student)
        {
            //  QUERY
            var sql = @"
                UPDATE
                    HSOL_Student 
                SET
                    PersonID = @PersonID,
                    LevelID = @LevelID
                WHERE
                    StudentID = @StudentID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@StudentID", student.StudentID, SqlDbType.VarChar);
            dp.AddParam("@PersonID", student.PersonID, SqlDbType.VarChar);
            dp.AddParam("@LevelID", student.LevelID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Delete(IStudentKey student)
        {
            //  QUERY
            var sql = @"
                DELETE
                    HSOL_Student 
                WHERE
                    StudentID = @StudentID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@StudentID", student.StudentID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public StudentModel GetData(IStudentKey student)
        {
            //  QUERY
            var sql = @"
                SELECT
                    aa.StudentID, aa.PersonID, aa.LevelID,
                    ISNULL(bb.LevelName,'') LevelName,
                    ISNULL(cc.PersonName, '') PersonName
                FROM
                    HSOL_Student aa
                    LEFT JOIN HSOL_Level bb ON aa.LevelID = bb.LevelID
                    LEFT JOIN HSOL_Person cc ON aa.PersonID = cc.PersonID
                WHERE
                    aa.StudentID = @StudentID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@StudentID", student.StudentID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.ReadSingle<StudentModel>(sql, dp);
        }

        public IEnumerable<StudentModel> ListData(ILevelKey filter)
        {
            //  QUERY
            var sql = @"
                SELECT
                    aa.StudentID, aa.PersonID, aa.LevelID,
                    ISNULL(bb.LevelName,'') LevelName
                FROM
                    HSOL_Student aa
                    LEFT JOIN HSOL_Level bb ON aa.LevelID = bb.LevelID
                WHERE
                    aa.LevelID = @LevelID ";

            //  PARAMETER
            var dp = new DynamicParameters();
            dp.AddParam("@LevelID", filter.LevelID, SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.Read<StudentModel>(sql, dp);
        }
    }
}
