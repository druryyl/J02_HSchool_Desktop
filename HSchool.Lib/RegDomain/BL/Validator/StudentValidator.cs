using FluentValidation;
using FluentValidation.Results;
using HSchool.Lib.RegDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.BL.Validator
{

    public class StudentValidator : AbstractValidator<IStudentContext>
    {
        private const string ERR_PREFIX = "ERR-STUDN";

        public StudentValidator()
        {
            /*--RULE Student
             *  201 - PersonID harus terisi
             *  202 - PersonName harus terisi
             *  203 - PersonName harus sama dengan look-up
             *  204 - LevelID harus terisi
             *  205 - LevelName harus terisi
             *  206 - LevelName harus sama dengan look-up
             *  
             */
            RuleFor(x => x.Student.PersonID)
                .NotEmpty()
                .WithErrorCode($"{ERR_PREFIX}-201")
                .WithMessage("Kode Person tidak boleh kosong");

            RuleFor(x => x.Student.PersonName)
                .NotEmpty()
                .WithErrorCode($"{ERR_PREFIX}-202")
                .WithMessage("Nama Person tidak boleh kosong")
                //
                .Equal(x => x.Person.PersonName)
                .WithErrorCode($"{ERR_PREFIX}-203")
                .WithMessage("Person tidak terdaftar");

            RuleFor(x => x.Student.LevelID)
                .NotEmpty()
                .WithErrorCode($"{ERR_PREFIX}-204")
                .WithMessage("LevelID tidak boleh kosong");

            RuleFor(x => x.Student.LevelName)
                .NotEmpty()
                .WithErrorCode($"{ERR_PREFIX}-202")
                .WithMessage("LevelName tidak boleh kosong")
                //
                .Equal(x => x.Level.LevelName)
                .WithErrorCode($"{ERR_PREFIX}-203")
                .WithMessage("Level tidak terdaftar");

        }

        protected override bool PreValidate(ValidationContext<IStudentContext> context, ValidationResult result)
        {
            if (context.InstanceToValidate is null)
            {
                var newError = new ValidationFailure("", "Context Student kosong")
                {
                    ErrorCode = $"{ERR_PREFIX}-100"
                };
                result.Errors.Add(newError);
                return false;
            }

            if (context.InstanceToValidate.Student is null)
            {
                var newError = new ValidationFailure("", "Data Student kosong")
                {
                    ErrorCode = $"{ERR_PREFIX}-101"
                };
                result.Errors.Add(newError);
                return false;
            }

            if (context.InstanceToValidate.Person is null)
            {
                var newError = new ValidationFailure("", "Data Person kosong atau invalid")
                {
                    ErrorCode = $"{ERR_PREFIX}-102"
                };
                result.Errors.Add(newError);
                return false;
            }

            if (context.InstanceToValidate.Level is null)
            {
                var newError = new ValidationFailure("", "Data Level kosong atau invalid")
                {
                    ErrorCode = $"{ERR_PREFIX}-103"
                };
                result.Errors.Add(newError);
                return false;
            }
            return true;
        }
    }
}
