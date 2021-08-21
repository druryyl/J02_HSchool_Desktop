using FluentAssertions;
using HSchool.Lib.Dal;
using HSchool.Lib.Models.Entity;
using Nuna.Lib.TransactionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HSchool.Test.DalTest
{

    public class GradeDalTest
    {
        private readonly IGradeDal _gradeDal;

        public GradeDalTest()
        {
            _gradeDal = new GradeDal();
        }

        private GradeEntity Grade() =>
            new GradeEntity
            {
                GradeID = "A1",
                GradeName = "A2"
            };

        [Fact]
        public void InsertTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ACT
                _gradeDal.Insert(Grade());
            }
        }

        [Fact]
        public void UpdateTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                _gradeDal.Insert(Grade());

                //  ACT
                _gradeDal.Update(Grade());
            }
        }

        [Fact]
        public void DeleteTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                _gradeDal.Insert(Grade());

                //  ACT
                _gradeDal.Delete(Grade());
            }
        }

        [Fact]
        public void GetDataTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                var expected = Grade();
                _gradeDal.Insert(expected);

                //  ACT
                var actual = _gradeDal.GetData(Grade());

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
                var expected = new List<GradeEntity> { Grade() };
                _gradeDal.Insert(Grade());

                //  ACT
                var actual = _gradeDal.ListData();

                //  ASSERT
                actual.Should().BeEquivalentTo(expected);
            }
        }
    }
}
