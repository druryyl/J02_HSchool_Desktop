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

    public class PersonValidator : AbstractValidator<IPersonContext>
    {
        private const string ERR_PREFIX = "ERR-PERSON";

        public PersonValidator()
        {
            /*--RULE Person
             *  201 - Nama Person tidak boleh kosong
             *  202 - Panjang Nama Person maximal 30 huruf
             */
            RuleFor(x => x.Person.PersonName)
                .NotEmpty()
                .WithErrorCode($"{ERR_PREFIX}-201")
                .WithMessage("Nama Person tidak boleh kosong")
                //
                .MaximumLength(30)
                .WithErrorCode($"{ERR_PREFIX}-202")
                .WithMessage("Panjang Nama Person maximal 30 huruf");
        }

        protected override bool PreValidate(ValidationContext<IPersonContext> context, ValidationResult result)
        {
            if (context.InstanceToValidate is null)
            {
                var newError = new ValidationFailure("", "Context Person kosong")
                {
                    ErrorCode = $"{ERR_PREFIX}-100"
                };
                result.Errors.Add(newError);
                return false;
            }

            if (context.InstanceToValidate.Person is null)
            {
                var newError = new ValidationFailure("", "Data Person kosong")
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
