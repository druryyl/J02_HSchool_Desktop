using FluentAssertions;
using HSchool.Lib.RegDomain.Dal;
using HSchool.Lib.RegDomain.Models.Entity;
using Nuna.Lib.TransactionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HSchool.Test.DalTest
{

    public class PersonDalTest
    {
        private readonly IPersonDal _personDal;

        public PersonDalTest()
        {
            _personDal = new PersonDal();
        }

        private PersonModel Person() =>
            new PersonModel
            {
                PersonID = "A1",
                PersonName = "A2",
                NickName = "A3",

                BirthDate = new DateTime(2000,4,5),
                BirthPlace = "A5",
                Gender = GenderEnum.Female,

                FullAddr = "A6",
                ShortAddr = "A7",
                City = "A8",
                PhoneNo = "A9",
                Email = "A10@yahoo.com"
            };

        [Fact]
        public void InsertTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ACT
                _personDal.Insert(Person());
            }
        }

        [Fact]
        public void UpdateTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                _personDal.Insert(Person());

                //  ACT
                _personDal.Update(Person());
            }
        }

        [Fact]
        public void DeleteTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                _personDal.Insert(Person());

                //  ACT
                _personDal.Delete(Person());
            }
        }

        [Fact]
        public void GetDataTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                var expected = Person();
                _personDal.Insert(expected);

                //  ACT
                var actual = _personDal.GetData(Person());

                //  ASSERT
                actual.Should().BeEquivalentTo(expected);
            }
        }

        [Fact]
        public void ListDataTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                var expected = new List<PersonModel> { Person() };
                _personDal.Insert(Person());

                //  ACT
                var actual = _personDal.ListData();

                //  ASSERT
                actual.Should().BeEquivalentTo(expected);
            }
        }
    }
}
