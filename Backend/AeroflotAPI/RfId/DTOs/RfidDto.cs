namespace AeroflotAPI.DTOs;

public class RfidDto
{
    public string RfId { get; set; }
    public string? ZoneName { get; set; }
    public string Name { get; set; }
    public DataTimes DataTimes { get; set; }
    public string EquipmentInformation { get; set; }
    public string PlanePlace { get; set; }
    public int Status { get; set; }
}

public class DataTimes
{
    public long DataExploitationBegin { get; set; }
    public long DataExploitationFinish { get; set; }
}