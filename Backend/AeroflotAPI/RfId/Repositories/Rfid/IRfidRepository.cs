using AeroflotAPI.Models;

namespace AeroflotAPI.Repositories;

public interface IRfidRepository
{
    Task<IQueryable<Zone>> GetZonesByPlainId(string planeId);
    Task<bool> PostAddNewRfId(Equip equip);
    Task<IQueryable<Equip>> PostStartCheckZone(string idZone, string idChecker);
    Task<bool> PostEndCheckZone(string idZone, string idChecker);
    Task<Equip> GetRfid(string rfid);
    Task<string> GetZoneNameById(string idZone);
}