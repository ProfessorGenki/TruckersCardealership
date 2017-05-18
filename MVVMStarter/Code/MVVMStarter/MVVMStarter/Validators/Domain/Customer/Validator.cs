using MVVMStarter.Validators.App;
using System.Runtime.CompilerServices;
using System;

/// <summary>
/// NB: THIS CLASS IS OPTIONAL - ONLY DEFINE IT IF YOU NEED TO
///     DEFINE DOMAIN-SPECIFIC VALIDATOR METHODS
/// TEMPLATE: You must
/// 1) Create a file called Validator.cs in your domain folder(under Validators/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.Validators.Domain.Customer
{

    //public static ValidationOutcome ValidateIntInInterval(int value, int minValue, int MaxValue,
    //     [CallerMemberName] string propertyName = null)
    //{
    //    string message = propertyName + " " + " must be a number between " + minValue + " and " + MaxValue;
    //    return Validate<int>(value, v => (v >= minValue && v <= MaxValue), message);
    //}

    public static class Validator 
    {
        public static ValidationOutcome Validate<TValue>(TValue value, Func<TValue, bool> isValid, string message)
        {
            return (isValid(value) ? null : new ValidationOutcome(message));
        }

        public static void ThrowOnInvalid<TValue>(Func<TValue, ValidationOutcome> validator, TValue value)
        {
            ValidationOutcome vo = validator(value);
            if (vo != null)
            {
                throw new ValidationException(vo.Message);
            }
        }

        public static ValidationOutcome ValidatePhonenumber(int value, int minValue, int MaxValue,
         [CallerMemberName] string propertyPhonenumber = null)
        {
            string message = propertyPhonenumber + " " + " Skal indeholde præcist " + minValue + " numre";
            return Validate<int>(value, v => (v >= minValue && v <= MaxValue), message);
        }
    }
}
