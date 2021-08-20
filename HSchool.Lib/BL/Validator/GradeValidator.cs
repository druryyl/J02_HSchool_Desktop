using FluentValidation;
using FluentValidation.Results;
using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL.Validator
{

    public class GradeValidator : AbstractValidator<IGradeContext>
    {
        private const string ERR_PREFIX = "ERR-GRADE";

        public GradeValidator()
        {
            /*--RULE Grade
             *  201 - Nama Grade tidak boleh kosong
             *  202 - Panjang Nama Grade maximal 30 huruf
             */
            RuleFor(x => x.Grade.GradeName)
                .NotEmpty()
                .WithErrorCode($"{ERR_PREFIX}-201")
                .WithMessage("Nama Grade tidak boleh kosong")
                //
                .MaximumLength(30)
                .WithErrorCode($"{ERR_PREFIX}-202")
                .WithMessage("Panjang Nama Grade maximal 30 huruf");
        }

        protected override bool PreValidate(ValidationContext<IGradeContext> context, ValidationResult result)
        {
            if (context.InstanceToValidate is null)
            {
                var newError = new ValidationFailure("", "Context Grade kosong")
                {
                    ErrorCode = $"{ERR_PREFIX}-100"
                };
                result.Errors.Add(newError);
                return false;
            }

            if (context.InstanceToValidate.Grade is null)
            {
                var newError = new ValidationFailure("", "Data Grade kosong")
                {
                    ErrorCode = $"{ERR_PREFIX}-101"
                };
                result.Errors.Add(newError);
                return false;
            }
            return true;
        }
    }
}
