using FluentValidation;
using FluentValidation.Results;
using HSchool.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL.Validator
{
    public class LevelValidator : AbstractValidator<ILevelContext>
    {
        private const string ERR_PREFIX = "ERR-LEVEL";

        public LevelValidator()
        {
            /*--RULE Level
             *  201 - Nama Level tidak boleh kosong
             *  202 - Panjang Nama Level maximal 30 huruf
             *  203 - GradeID harus terisi
             *  204 - GradeName harus terisi
             *  205 - GradeName harus sama dengan look-up
             */
            RuleFor(x => x.Level.LevelName)
                .NotEmpty()
                .WithErrorCode($"{ERR_PREFIX}-201")
                .WithMessage("Nama Level tidak boleh kosong")
                //
                .MaximumLength(30)
                .WithErrorCode($"{ERR_PREFIX}-202")
                .WithMessage("Panjang Nama Level maximal 30 huruf");

            RuleFor(x => x.Level.GradeID)
                .NotEmpty()
                .WithErrorCode($"{ERR_PREFIX}-203")
                .WithMessage("Kode Grade tidak boleh kosong");

            RuleFor(x => x.Level.GradeName)
                .NotEmpty()
                .WithErrorCode($"{ERR_PREFIX}-204")
                .WithMessage("Nama Grade tidak boleh kosong")
                //
                .Equal(x => x.Grade.GradeName)
                .WithErrorCode($"{ERR_PREFIX}-205")
                .WithMessage("Grade tidak terdaftar");
        }

        protected override bool PreValidate(ValidationContext<ILevelContext> context, ValidationResult result)
        {
            if (context.InstanceToValidate is null)
            {
                var newError = new ValidationFailure("", "Context Level kosong")
                {
                    ErrorCode = $"{ERR_PREFIX}-100"
                };
                result.Errors.Add(newError);
                return false;
            }

            if (context.InstanceToValidate.Level is null)
            {
                var newError = new ValidationFailure("", "Data Level kosong")
                {
                    ErrorCode = $"{ERR_PREFIX}-101"
                };
                result.Errors.Add(newError);
                return false;
            }

            if (context.InstanceToValidate.Grade is null)
            {
                var newError = new ValidationFailure("", "Data Grade kosong atau invalid")
                {
                    ErrorCode = $"{ERR_PREFIX}-102"
                };
                result.Errors.Add(newError);
                return false;
            }

            return true;
        }
    }
}
