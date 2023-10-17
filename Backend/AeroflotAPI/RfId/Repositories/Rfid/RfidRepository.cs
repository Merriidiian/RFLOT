using AeroflotAPI.Models;

namespace AeroflotAPI.Repositories;

public class RfidRepository : IRfidRepository
{
    private readonly RfidContext _context;

    public RfidRepository(RfidContext context)
    {
        _context = context;
    }

    public async Task<IQueryable<Zone>> GetZonesByPlainId(string planeId)
    {
        var zones = _context.Zones.Where(z => z.IdPlane == planeId);
        await _context.AddRangeAsync();
        return zones;
    }

    public Task<bool> PostAddNewRfId(Equip equip)
    {
        throw new NotImplementedException();
    }

    public async Task<IQueryable<Equip>> PostStartCheckZone(string idZone, string idChecker)
    {
        try
        {
            var equips = _context.Equips.Where(r => r.IdZone == idZone);
            var checkFlag = _context.Zones.FirstOrDefault(r => r.Id == idZone).CheckFlag = true;
            var checkerName = _context.People.FirstOrDefault(p => p.Id == idChecker).FullName;
            _context.Zones.FirstOrDefault(c => c.Id == idZone).NameChecker = checkerName;
            await _context.SaveChangesAsync();
            return equips;
        }
        catch (Exception e)
        {
            throw new Exception("Ошибка");
        }
    }

    public async Task<bool> PostEndCheckZone(string idZone, string idChecker)
    {
        var people = _context.People.FirstOrDefault(p => p.Id == idChecker).FullName;
        var zone = _context.Zones.FirstOrDefault(r => r.NameChecker == people).CheckFlag = false;
        var zone2 = _context.Zones.FirstOrDefault(r => r.NameChecker == people).NameChecker = null;
        _context.SaveChangesAsync();
        return zone;
    }

    public async Task<Equip> GetRfid(string rfid)
    {
        var rfidItem = _context.Equips.FirstOrDefault(r => r.RfId == rfid);
        if (rfidItem == null) throw new Exception("Rfid не найден");

        return rfidItem;
    }

    public async Task<string> GetZoneNameById(string idZone)
    {
        var zoneName = _context.Zones.FirstOrDefault(z => z.Id == idZone).Name;
        return zoneName;
    }
}