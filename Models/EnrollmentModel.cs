using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDemo.Models
{
    public class EnrollmentModel
    {
        [Key]
        public int EnrollmentId { get; set; }

        [ForeignKey("CourseModel")]
        public int CourseId { get; set; }

        [ForeignKey("StudentModel")]
        public int StudentId { get; set; }

        public char Grade { get; set; }

        public virtual CourseModel Course { get; set; }
        public virtual StudentModel Student { get; set; }

    }
}
