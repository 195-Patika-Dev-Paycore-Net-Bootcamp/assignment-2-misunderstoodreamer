using FluentValidation;
using System.Text.RegularExpressions;

namespace CagatayYagmur_Week2
// TODO: Id should be incremented. Client should not enter the Id
// Id should be increase every instance is created.
{
    public class StaffValidator
    {
        public class ProductValidator : AbstractValidator<Staff>
        {
            readonly Regex regExName = new Regex("^[a-zA-Z]*$");
            public ProductValidator()
            {

                RuleFor(x => x.Name)
                    .Matches(regExName)
                    .MinimumLength(3).WithMessage("Name has to be minimum 3 letters")
                    .MaximumLength(20).WithMessage("Name has to be maximum 20 letters");

                RuleFor(x => x.LastName)
                    .Matches(regExName)
                    .MinimumLength(3).WithMessage("Name has to be minimum 3 letters")
                    .MaximumLength(20).WithMessage("Name has to be maximum 20 letters");


                RuleFor(x => x.PhoneNumber)
                    .Length(11).WithMessage("Your phone number has to be 11 numbers. For example: 05551234567");

                
                RuleFor(x => x.Email)
                    .NotNull().WithMessage("Email cannot be empty.")
                    .EmailAddress().WithMessage("Please enter a valid email adress.");

                RuleFor(x => x.Salary)
                    .NotNull().WithMessage("Salary cannot be empty.")
                    .GreaterThan(2000).WithMessage("Salary cannot be lower than 2000 dollars.")
                    .LessThan(9000).WithMessage("Salary cannot be higher than 2000 dollars.");

                RuleFor(x => x.DateOfBirth)
                    .NotNull().WithMessage("Salary cannot be empty.");

                RuleFor(x => x.Id)
                    .NotNull().WithMessage("Id cannot be empty.");
            }
        }
    }
}
