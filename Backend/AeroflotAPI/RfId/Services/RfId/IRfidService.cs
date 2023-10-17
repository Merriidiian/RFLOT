using AeroflotAPI.DTOs;

namespace AeroflotAPI.Services.RfId;

public interface IRfidService
{
    Task<Dictionary<string, IQueryable<ZonesDto>>> GetZonesByPlainId(string planeId);
    Task<bool> PostAddNewRfId(RfidDto equip);
    Task<Dictionary<string, IQueryable<RfidDto>>> PostStartCheckZone(string idZone, string idChecker);
    Task<bool> PostEndCheckZone(string idZone, string idChecker);
    Task<RfidDto> GetRfid(string rfid);
}