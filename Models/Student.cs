using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsList.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(70, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(70)]
        public string Subject { get; set; }

        [Range(1, 9999)]
        [DataType(DataType.Currency)]
        [Display(Name = "Actual Payment")]
        public decimal StudentNumber { get; set; }
    }
}
