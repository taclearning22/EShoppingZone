using System.ComponentModel.DataAnnotations;

namespace EShoppingZone.Models
{
    public class User
    {
        [Required]
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        [Required]
        [MinLength(5)]
        public string UserName { get; set; }
        
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public DateTime LastLoggedIn { get; set; }
        public string UserType { get; set; }

    }
}
