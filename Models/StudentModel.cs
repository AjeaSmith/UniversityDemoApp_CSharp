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
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Enrollment")]
        public DateTime EnrollmentDate { get; set; }

        public List<EnrollmentModel> Enrollments { get; set; }

    }

}