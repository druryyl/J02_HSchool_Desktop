﻿using Dapper;
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
    public interface IPersonDal :
        IInsert<PersonModel>,
        IUpdate<PersonModel>,
        IDelete<IPersonKey>,
        IGetData<PersonModel, IPersonKey>,
        IListData<PersonModel>
    {
    }

    public class PersonDal : IPersonDal
    {
        public void Insert(PersonModel person)
        {
            var sql = @"
                INSERT INTO 
                    HSOL_Person (
                        PersonID, PersonName, NickName,
                        BirthDate, BirthPlace, Gender,
                        FullAddr, ShortAddr, City,
                        PhoneNo, Email)
                VALUES (
                        @PersonID, @PersonName, @NickName,
                        @BirthDate, @BirthPlace, @Gender,
                        @FullAddr, @ShortAddr, @City,
                        @PhoneNo, @Email) ";

            var dp = new DynamicParameters();
            dp.AddParam("@PersonID", person.PersonID, SqlDbType.VarChar);
            dp.AddParam("@PersonName", person.PersonName, SqlDbType.VarChar);
            dp.AddParam("@NickName", person.NickName, SqlDbType.VarChar);

            dp.AddParam("@BirthDate", person.BirthDate, SqlDbType.DateTime);
            dp.AddParam("@BirthPlace", person.BirthPlace, SqlDbType.VarChar);
            dp.AddParam("@Gender", person.Gender, SqlDbType.Int);
            
            dp.AddParam("@FullAddr", person.FullAddr, SqlDbType.VarChar);
            dp.AddParam("@ShortAddr", person.ShortAddr, SqlDbType.VarChar);
            dp.AddParam("@City", person.City, SqlDbType.VarChar);
            
            dp.AddParam("@PhoneNo", person.PhoneNo, SqlDbType.VarChar);
            dp.AddParam("@Email", person.Email, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Update(PersonModel person)
        {
            var sql = @"
                UPDATE
                    HSOL_Person
                SET
                    PersonName = @PersonName, 
                    NickName = @NickName,
                    BirthDate = @BirthDate, 
                    BirthPlace = @BirthPlace, 
                    Gender = @Gender,
                    FullAddr = @FullAddr, 
                    ShortAddr = @ShortAddr, 
                    City = @City,
                    PhoneNo = @PhoneNo, 
                    Email = @Email
                WHERE
                    PersonID = @PersonID ";

            var dp = new DynamicParameters();
            dp.AddParam("@PersonID", person.PersonID, SqlDbType.VarChar);
            dp.AddParam("@PersonName", person.PersonName, SqlDbType.VarChar);
            dp.AddParam("@NickName", person.NickName, SqlDbType.VarChar);

            dp.AddParam("@BirthDate", person.BirthDate, SqlDbType.DateTime);
            dp.AddParam("@BirthPlace", person.BirthPlace, SqlDbType.VarChar);
            dp.AddParam("@Gender", person.Gender, SqlDbType.Int);

            dp.AddParam("@FullAddr", person.FullAddr, SqlDbType.VarChar);
            dp.AddParam("@ShortAddr", person.ShortAddr, SqlDbType.VarChar);
            dp.AddParam("@City", person.City, SqlDbType.VarChar);

            dp.AddParam("@PhoneNo", person.PhoneNo, SqlDbType.VarChar);
            dp.AddParam("@Email", person.Email, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public void Delete(IPersonKey person)
        {
            var sql = @"
                DELETE
                    HSOL_Person
                WHERE
                    PersonID = @PersonID ";

            var dp = new DynamicParameters();
            dp.AddParam("@PersonID", person.PersonID, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                conn.Execute(sql, dp);
        }

        public PersonModel GetData(IPersonKey person)
        {
            var sql = @"
                SELECT
                    PersonID, PersonName, NickName,
                    BirthDate, BirthPlace, Gender,
                    FullAddr, ShortAddr, City,
                    PhoneNo, Email
                FROM
                    HSOL_Person
                WHERE
                    PersonID = @PersonID ";

            var dp = new DynamicParameters();
            dp.AddParam("@PersonID", person.PersonID, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.ReadSingle<PersonModel>(sql, dp);
        }

        public IEnumerable<PersonModel> ListData()
        {
            var sql = @"
                SELECT
                    PersonID, PersonName, NickName,
                    BirthDate, BirthPlace, Gender,
                    FullAddr, ShortAddr, City,
                    PhoneNo, Email
                FROM
                    HSOL_Person ";

            var dp = new DynamicParameters();

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
                return conn.Read<PersonModel>(sql, dp);
        }
    }
}