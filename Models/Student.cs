using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicASP.Models
{
    public class Student
    {
        [Key]
        [Required(ErrorMessage ="ID Should be 001 to 999 only")]
        [DisplayName("Student ID")]
        public string Id { get; set; }
        [Required]
        [DisplayName("Student name")]
        public string Name { get; set; }
        [DisplayName("Test score")]
        [Range(0,100)]
        public int Score { get; set; }
    }
}
