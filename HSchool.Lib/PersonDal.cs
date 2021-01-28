using HSchool.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib
{
    public interface IPersonDal
    {
        void Insert(PersonModel person);
        void Update(PersonModel person);
        void Delete(IPersonKey person);
        PersonModel GetData(IPersonKey person);
        IEnumerable<PersonModel> Search(string personName);
    }

    public class PersonDal : IPersonDal
    {
        public void Insert(PersonModel person)
        {
            var sql = @"
                INSERT INTO HSOL_Person (
                    PersonID, PersonName, NickName, 
                    BirthDate, BirthPlace, Gender, 
                    FullAddr, ShortAddr, City, 
                    PhoneNo, Email)
                VALUES (
                    @PersonID, @PersonName, @NickName, 
                    @BirthDate, @BirthPlace, @Gender, 
                    @FullAddr, @ShortAddr, @City, 
                    @PhoneNo, @Email) ";
            
        }

        public void Update(PersonModel person)
        {
            throw new NotImplementedException();
        }

        public void Delete(IPersonKey person)
        {
            throw new NotImplementedException();
        }

        public PersonModel GetData(IPersonKey person)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonModel> Search(string personName)
        {
            throw new NotImplementedException();
        }
    }
}
