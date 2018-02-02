using MyMVCApp.CustomValidation;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyMVCApp.Models
{

    public class CustomValidation
    {
        
        [DisplayName("Start date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DisplayName("End date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [DateGreaterThan("StartDate", "End date must be greater than the start date.")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [CustomValidationAttributeDemo.ValidationAttributes.ValidBirthDate(ErrorMessage = "Birth Date can not be greater than current date")]
        public DateTime BirthDate { get; set; }

    }
}