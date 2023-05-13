using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
