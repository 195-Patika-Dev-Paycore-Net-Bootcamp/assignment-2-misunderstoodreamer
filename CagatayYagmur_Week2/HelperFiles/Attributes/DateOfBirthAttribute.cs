using System;
using System.ComponentModel.DataAnnotations;

// this code is originally taken from https://github.com/pcupdev/ptk-pyc-webapi/blob/main/PycTest/Attibute/DateOfBirthAttribute.cs
// then made adjustments for our project.

namespace CagatayYagmur_Week2
{
    public class DateOfBirthAttribute : ValidationAttribute
    {
        DateTime maxDate = new DateTime(2002, 10, 10);
        DateTime minDate = new DateTime(1945, 11, 11);
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                // https://www.tutorialspoint.com/datetime-compare-method-in-chash
                DateTime date = Convert.ToDateTime(value);
                var max = maxDate;
                var min = minDate;
                var msg = string.Format($"Please enter a value between {min:MM/dd/yyyy} and {max:MM/dd/yyyy}");
                if (DateTime.Compare( min, date ) > 0 || DateTime.Compare( date, max ) > 0)
                    return new ValidationResult(msg);
                else
                    return ValidationResult.Success;
            }
            catch (Exception)
            {
                return new ValidationResult("Invalid Date of Birth");
            }
        }

    }
}
