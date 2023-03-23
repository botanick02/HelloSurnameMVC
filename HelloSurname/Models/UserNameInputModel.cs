using System.ComponentModel.DataAnnotations;

namespace HelloSurname.Models
{
    public class UserNameInputModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}
