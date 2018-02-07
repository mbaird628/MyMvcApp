using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MyMVCApp.CustomValidation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class DateGreaterThan : ValidationAttribute, IClientValidatable
    {
        string otherPropertyName;

        public DateGreaterThan(string otherPropertyName, string errorMessage)
            : base(errorMessage)
        {
            this.otherPropertyName = otherPropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            ValidationResult results = ValidationResult.Success;

            try
            {
                // Get a reference to the start date.
                var startDateReference = validationContext.ObjectType.GetProperty(this.otherPropertyName);

                if (startDateReference.PropertyType.Equals(new DateTime().GetType()))
                {
                    DateTime endDate = (DateTime)value;
                    DateTime startDate = (DateTime)startDateReference.GetValue(validationContext.ObjectInstance, null);

                    if (endDate.CompareTo(startDate) < 1)
                    {
                        results = new ValidationResult(ErrorMessageString);
                    }
                }
                else
                {
                    results = new ValidationResult("An error occurred while validating the property. The property is not a DateTime value");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            string errorMessage = ErrorMessageString;

            ModelClientValidationRule mvr = new ModelClientValidationRule();
            mvr.ErrorMessage = errorMessage;
            mvr.ValidationType = "dategreaterthan";
            mvr.ValidationParameters.Add("startdate", otherPropertyName);
            yield return mvr;

        }
    }
}
