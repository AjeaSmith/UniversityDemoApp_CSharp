using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityDemo.Models
{
    public class StudentModel
    {
        [Key]
        [Display(Name = "#")]
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        [MinLength(3, ErrorMessage = "First Name must be at least 3 characters long")]
        public string FirstName { get; set; }

        [MinLength(3, ErrorMessage = "Last Name must be at least 3 characters long")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Enrollment")]
        [DataType(DataType.Date, ErrorMessage = "This must a date format. e.g. mm/dd/yyyy ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public List<EnrollmentModel> Enrollments { get; set; }

    }

}