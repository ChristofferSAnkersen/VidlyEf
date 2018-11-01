using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidlyEf.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.PasAsYouGo || customer.MembershipTypeId == MembershipType.Unknown)
            {
                return ValidationResult.Success;
            }

            if (customer.DateOfBirth == null)
            {
                return new ValidationResult("Birthdate is required.");
            }

            var age = DateTime.Today.Year - customer.DateOfBirth.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customers should be 18 years of age, or older, to be a member.");
        }
    }
}