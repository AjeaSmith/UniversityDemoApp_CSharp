using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UniversityDemo.Models
{
    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public virtual ICollection<EnrollmentModel> Enrollments { get; set; }
    }
}
