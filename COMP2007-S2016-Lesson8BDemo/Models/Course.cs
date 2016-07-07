namespace COMP2007_S2016_Lesson8BDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Course
    {
        [Key]
        public int CourseID { get; set; }

        [Required]
        [StringLength(100)]
        [Display (Name ="Title")]
        public string Title { get; set; }

        [Display(Name = "Credits")]
        public int Credits { get; set; }

        [Display(Name = "Department Name")]
        public int DepartmentID { get; set; }

        [Display(Name = "Department Name")]
        public virtual Department Department { get; set; }
    }
}
