using System.ComponentModel.DataAnnotations;

namespace ApiDemo.Models;

public class UserModel
{
    [Required]
    [MinLength(10)]
    public string FirstName { get; set; }
}
