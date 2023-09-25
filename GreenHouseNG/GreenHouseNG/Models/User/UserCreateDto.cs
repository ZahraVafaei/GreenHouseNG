using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace GreenHouseNG.Models.User
{
    public class UserCreateDto
    {
        [Required]
        public int IdUser { get; set; }
        [Required]
        public string Uname { get; set; } = null!;
        // = null!;: This is the default value assignment for the property.
        // It initializes the Uname property with a default value of null
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;

    }
}
