using System.ComponentModel.DataAnnotations;

namespace ChipChipApi.Models
{
    public class AccountRegistrationDto
    {
        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}
