using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            UserId = 
                Guid.NewGuid(); 
        }

        [Key]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        [EmailAddress]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        public string Username { get; set; }

        [Required]
        [MaxLength(128)]
        public string Password { get; set; }

        [MaxLength(800)]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(150)]
        public string Role { get; set; }

        [MaxLength(10)]
        public DateTime Birthday { get; set; }

        [MaxLength(800)]
        public string? Description { get; set; }
    }
}
