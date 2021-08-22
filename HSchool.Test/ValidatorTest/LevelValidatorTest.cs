using FluentValidation;
using FluentValidation.TestHelper;
using HSchool.Lib.RegDomain.BL.Validator;
using HSchool.Lib.RegDomain.Models;
using HSchool.Lib.RegDomain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HSchool.Test.ValidatorTest
{

    public class LevelValidatorTest
    {
        private readonly IValidator<ILevelContext> _validator;

        public LevelValidatorTest()
        {
            _validator = new LevelValidator();
        }

        private class Context : ILevelContext
        {
            public Context(LevelModel lavel, GradeModel grade)
            {
                Level = lavel;
                Grade = grade;
            }
            public LevelModel Level { get; }
            public GradeModel Grade { get; }
            public bool IsDeleted { get; }
        }

        public LevelModel Level() =>
            new LevelModel
            {
                LevelID = "A1",
                LevelName = "A2",
                GradeID = "A3",
                GradeName = "A4"
            };


        public GradeModel Grade() =>
            new GradeModel
            {
                GradeID = "A3",
                GradeName = "A4"
            };

        [Fact]
        public void ValidTest()
        {
            //  ARRANGE
            var context = new Context(Level(), Grade());

            //  ACT
            _validator.ValidateAndThrow(context);
        }

        [Fact]
        public void ERR_LEVEL_100_Context_Kosong()
        {
            //  ARRANGE
            Context context = null;

            //  ACT
            var result = _validator.TestValidate(context);

            //  ASSERT
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-LEVEL-100");
        }

        [Fact]
        public void ERR_LEVEL_101_Level_Kosong()
        {
            //  ARRANGE
            var context = new Context(null, Grade());

            //  ACT
            var result = _validator.TestValidate(context);
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-LEVEL-101");
        }

        [Fact]
        public void ERR_LEVEL_102_Level_Kosong()
        {
            //  ARRANGE
            var context = new Context(Level(), null);

            //  ACT
            var result = _validator.TestValidate(context);
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-LEVEL-102");
        }


        [Fact]
        public void ERR_LEVEL_201_NamaLevel_Kosong()
        {
            //  ARRANGE
            var lavel = Level();
            lavel.LevelName = string.Empty;
            var context = new Context(lavel, Grade());

            //  ACT
            var result = _validator.TestValidate(context);

            //  ASSERT
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-LEVEL-201");
        }

        [Fact]
        public void ERR_LEVEL_202_NamaLevel_PanjangLebihDari30()
        {
            //  ARRANGE
            var lavel = Level();
            lavel.LevelName = new String('A', 30 + 1);
            var context = new Context(lavel, Grade());

            //  ACT
            var result = _validator.TestValidate(context);

            //  ASSERT
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-LEVEL-202");
        }

        [Fact]
        public void ERR_LEVEL_203_GradeID_Kosong()
        {
            //  ARRANGE
            var lavel = Level();
            lavel.GradeID = string.Empty;
            var context = new Context(lavel, Grade());

            //  ACT
            var result = _validator.TestValidate(context);

            //  ASSERT
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-LEVEL-203");
        }

        [Fact]
        public void ERR_LEVEL_204_GradeName_Kosong()
        {
            //  ARRANGE
            var lavel = Level();
            lavel.GradeName = string.Empty;
            var context = new Context(lavel, Grade());

            //  ACT
            var result = _validator.TestValidate(context);

            //  ASSERT
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-LEVEL-204");
        }

        [Fact]
        public void ERR_LEVEL_205_GradeName_BedaDgnLookup()
        {
            //  ARRANGE
            var lavel = Level();
            lavel.GradeName = "X";
            var context = new Context(lavel, Grade());

            //  ACT
            var result = _validator.TestValidate(context);

            //  ASSERT
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-LEVEL-205");
        }
    }
}
