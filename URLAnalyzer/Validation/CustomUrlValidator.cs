using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace URLAnalyzer.CustomValidators
{
    public class CustomUrlValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
                       ValidationContext validationContext)
        {
            // If downloading from the site fails, cause a Validation error:
            try
            {
                WebClient client = new WebClient();
                client.DownloadString(value.ToString());
            }
            catch (Exception e)
            {
                return new ValidationResult("URL is not a valid website.  " + e.Message);
            }
            return ValidationResult.Success;
        }
    }
}
