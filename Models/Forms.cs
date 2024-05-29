using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MvcMovie.Models
{

    public class LoginForms
    {
        [JsonPropertyName("email")]
        //for used in the label
        [DisplayName("Email: ")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Input must be in email form!")]
        [Required]
        public required string Email { get; set; }

        [Required]
        [DisplayName("Password:")]
        //for used in the label:
        [JsonPropertyName("password")]
        public required string Password { get; set; }
    }
}