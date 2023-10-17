using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AeroflotAPI.Models;

public class ReportZone
{
    [Key] [Required] public int IdReportZone { get; set; }
    [Required] public string IdZone { get; set; }
    [Required] public string IdChecker { get; set; }
    [Required] public string TypeCheck { get; set; }
    [Required] public string ZoneName { get; set; }
    [Required] public string IdPlane { get; set; }
    [Required] [DataType(DataType.Date)] public DateTimeOffset DateTimeStartGroup { get; set; }
    [Required] [DataType(DataType.Date)] public DateTimeOffset DateTimeFinishGroup { get; set; }

    [Required] [MaybeNull] public string BadEquipJson { get; set; }
}