using System.ComponentModel.DataAnnotations;

namespace AeroflotAPI.Models;

public class Zone
{
    [Key] [Required] public string Id { get; set; }
    [Required] public string IdPlane { get; set; }
    [Required] public string Name { get; set; }
    [Required] public bool CheckFlag { get; set; }
    public string? NameChecker { get; set; }
}