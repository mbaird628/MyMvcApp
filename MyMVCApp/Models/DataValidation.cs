using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{
    public class DataValidation
    {
        [Display(Name= "String Length Validation")]
        [StringLength(5,ErrorMessage ="Need 5 characters.")]
        public string StringLengthValidation { get; set; }

        [Display(Name ="String range Validation")]
        [StringLength(10,MinimumLength=2)]
        public string StringRangeValidation { get; set; }

        [Display(Name="Required Property Validation")]
        [Required]
        public string RequiredValidation { get; set; }

        // US Phone number in which areas code and the exchange code must start with 2.
        [RegularExpression(@"^\(?([2-9][0-9]{2})\)?[-. ]?([2-9][0-9]{2})[-. ]?([0-9]{4})$", ErrorMessage = "Must be of the format: ###-###-#### or (###)###-####. Area and exchange codes must start wtih 2")]
        public string PhoneNumberValidation { get; set; }

        [DisplayName("Email Address Validation")]
        [EmailAddress]
        public string EmailValidation { get; set; }

        [Display(Name ="Confirm email validation")]
        [Compare("EmailValidation")]
        public string ConfirmationEmailValidation { get; set; }

        [Display(Name="Number Range Validation")]
        [Range(minimum:4,maximum:10)]
        public int NumberRangeValidation { get; set; }

    }
}