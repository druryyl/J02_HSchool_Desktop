using FluentValidation;
using FluentValidation.TestHelper;
using HSchool.Lib.BL.Validator;
using HSchool.Lib.Models.Entity;
using HSchool.Lib.Models.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HSchool.Test.ValidatorTest
{

    public class GradeValidatorTest
    {
        private readonly IValidator<IGradeContext> _validator;

        public GradeValidatorTest()
        {
            _validator = new GradeValidator();
        }

        private class Context : IGradeContext
        {
            public Context(GradeEntity grade)
            {
                Grade = grade;
            }
            public GradeEntity Grade { get; }
            public bool IsDeleted { get; }
        }

        public GradeEntity Grade() =>
            new GradeEntity
            {
                GradeID = "A1",
                GradeName = "A2"
            };

        [Fact]
        public void ValidTest()
        {
            //  ARRANGE
            var context = new Context(Grade());

            //  ACT
            _validator.ValidateAndThrow(context);
        }

        [Fact]
        public void ERR_GRADE_100_Context_Kosong()
        {
            //  ARRANGE
            Context context = null;

            //  ACT
            var result = _validator.TestValidate(context);

            //  ASSERT
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-GRADE-100");
        }

        [Fact]
        public void ERR_GRADE_101_Grade_Kosong()
        {
            //  ARRANGE
            var context = new Context(null);

            //  ACT
            var result = _validator.TestValidate(context);
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-GRADE-101");
        }

        [Fact]
        public void ERR_GRADE_201_NamaGrade_Kosong()
        {
            //  ARRANGE
            var grade = Grade();
            grade.GradeName = string.Empty;
            var context = new Context(grade);

            //  ACT
            var result = _validator.TestValidate(context);

            //  ASSERT
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-GRADE-201");
        }

        [Fact]
        public void ERR_GRADE_202_NamaGrade_PanjangLebihDari30()
        {
            //  ARRANGE
            var grade = Grade();
            grade.GradeName = new String('A', 30 + 1);
            var context = new Context(grade);

            //  ACT
            var result = _validator.TestValidate(context);

            //  ASSERT
            result.ShouldHaveAnyValidationError()
                .WithErrorCode("ERR-GRADE-202");
        }
    }
}
