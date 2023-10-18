using System.ComponentModel.DataAnnotations;

namespace AeroflotAPI.Models;

public class Equip
{
    [Key] [Required] public string RfId { get; set; }
    [Required] public string IdZone { get; set; }
    [Required] public string Name { get; set; }
    [Required] [DataType(DataType.Date)] public DateTimeOffset DataExploitationBegin { get; set; }
    [Required] [DataType(DataType.Date)] public DateTimeOffset DataExploitationFinish { get; set; }
    [Required] public string EquipmentInformation { get; set; }
    [Required] public string PlanePlace { get; set; }
    [Required] public int Status { get; set; }
}