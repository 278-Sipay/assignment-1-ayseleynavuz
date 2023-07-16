using System;
using FluentValidation;
using Sipay.Bootcamp.AleynaYavuz.Models;

namespace Sipay.Bootcamp.AleynaYavuz.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Staff person name is required.")
                .Length(5, 100).WithMessage("Staff person name must be between 5 and 100 characters.");

            RuleFor(x => x.Lastname)
                .NotEmpty().WithMessage("Staff person lastname is required.")
                .Length(5, 100).WithMessage("Staff person lastname must be between 5 and 100 characters.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Staff person phone number is required.")
                .Matches(@"^\d+$").WithMessage("Staff person phone number is not valid.");

            RuleFor(x => x.AccessLevel)
                .NotEmpty().WithMessage("Staff person access level to system is required.")
                .InclusiveBetween(1, 5).WithMessage("Staff person access level must be between 1 and 5.");

            RuleFor(x => x.Salary)
                 .NotEmpty().WithMessage("Staff person salary is required.")
                  .InclusiveBetween(5000, 50000).WithMessage("Staff person salary must be between 5000 and 50000.");
        }
    }
}
