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

    public class LevelDalTest
    {
        private readonly ILevelDal _levelDal;

        public LevelDalTest()
        {
            _levelDal = new LevelDal();
        }

        private LevelEntity Level() =>
            new LevelEntity
            {
                LevelID = "A1",
                LevelName = "A2",
                GradeID = "A3",
                GradeName = ""
            };

        [Fact]
        public void InsertTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ACT
                _levelDal.Insert(Level());
            }
        }

        [Fact]
        public void UpdateTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                _levelDal.Insert(Level());

                //  ACT
                _levelDal.Update(Level());
            }
        }

        [Fact]
        public void DeleteTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                _levelDal.Insert(Level());

                //  ACT
                _levelDal.Delete(Level());
            }
        }

        [Fact]
        public void GetDataTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                var expected = Level();
                _levelDal.Insert(expected);

                //  ACT
                var actual = _levelDal.GetData(Level());

                //  ASSERT
                actual.Should().BeEquivalentTo(expected);
            }
        }

        [Fact]
        public void ListDataByGradeTest()
        {
            using (var trans = TransHelper.NewScope())
            {
                //  ARRANGE
                var expected = new List<LevelEntity> { Level() };
                _levelDal.Insert(Level());

                //  ACT
                var actual = _levelDal.ListData(Level());

                //  ASSERT
                actual.Should().BeEquivalentTo(expected);
            }
        }
    }
}
