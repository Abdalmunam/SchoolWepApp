using System.ComponentModel.DataAnnotations;

namespace SchoolWepAppTest.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Student Name")]
        public string Name { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [Display(Name="Date of Birth")]
        public DateTime DoB { get; set; }
    }
}
