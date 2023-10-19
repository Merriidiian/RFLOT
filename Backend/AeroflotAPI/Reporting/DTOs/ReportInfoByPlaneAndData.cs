namespace AeroflotAPI.Reporting.DTOs;

public class ReportInfoByPlaneAndData
{
    public string PlaneId { get; set; }
    public string DataBegin { get; set; }
    public string DataEnd { get; set; }
    public string Type { get; set; }

    public string Zone { get; set; }
}