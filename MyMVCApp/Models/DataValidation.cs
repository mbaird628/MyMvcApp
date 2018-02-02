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
        [Display(Name= "String Length")]
        [StringLength(5,ErrorMessage ="Length can be no longer then 5 characters.")]
        public string StringLengthValidation { get; set; }

        [Display(Name ="String range")]
        [StringLength(10,MinimumLength=2)]
        public string StringRangeValidation { get; set; }

        [Display(Name="Required Property")]
        [Required]
        public string RequiredValidation { get; set; }

        // US Phone number in which areas code and the exchange code must start with 2.
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\(?([2-9][0-9]{2})\)?[-. ]?([2-9][0-9]{2})[-. ]?([0-9]{4})$", ErrorMessage = "Must be of the format: ###-###-#### or (###)###-####. Area and exchange codes must start wtih 2")]
        public string PhoneNumberValidation { get; set; }

        [DisplayName("Email Address")]
        [EmailAddress]
        public string EmailValidation { get; set; }

        [Display(Name ="Confirm email")]
        [Compare("EmailValidation")]
        public string ConfirmationEmailValidation { get; set; }

        [Display(Name="Number Range")]
        [Range(minimum:4,maximum:10)]
        public int NumberRangeValidation { get; set; }


    }
}