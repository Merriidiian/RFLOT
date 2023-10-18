using System.ComponentModel.DataAnnotations;

namespace AeroflotAPI.Models;

public class People
{
    [Key] [Required] public string Id { get; set; }
    [Required] public string FullName { get; set; }
    [Required] public string Login { get; set; }
    [Required] public string Password { get; set; }
    [Required] public string Role { get; set; }
}