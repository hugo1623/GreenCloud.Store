using System.ComponentModel.DataAnnotations;

namespace GreenCloud.Store.Entity
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string FirsName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
