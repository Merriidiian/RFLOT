using AeroflotAPI.DTOs;
using AeroflotAPI.Repositories;
using AutoMapper;

namespace AeroflotAPI.Services.RfId;

public class RfidService : IRfidService
{
    private readonly IMapper _mapper;
    private readonly IRfidRepository _repository;

    public RfidService(IRfidRepository repository, IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<Dictionary<string, IQueryable<ZonesDto>>> GetZonesByPlainId(string planeId)
    {
        try
        {
            var repositoryResult = await _repository.GetZonesByPlainId(planeId);
            var dtos = new List<ZonesDto>();
            foreach (var r in repositoryResult) dtos.Add(_mapper.Map<ZonesDto>(r));

            var result = new Dictionary<string, IQueryable<ZonesDto>>();
            result.Add("zones", dtos.AsQueryable());
            return result;
        }
        catch (Exception e)
        {
            throw new Exception("Ошибка получения зон");
        }
    }

    public Task<bool> PostAddNewRfId(RfidDto equip)
    {
        throw new NotImplementedException();
    }

    public async Task<Dictionary<string, IQueryable<RfidDto>>> PostStartCheckZone(string idZone, string idChecker)
    {
        var repos = await _repository.PostStartCheckZone(idZone, idChecker);
        var listRfid = new List<RfidDto>();
        foreach (var l in repos) listRfid.Add(_mapper.Map<RfidDto>(l));

        var result = new Dictionary<string, IQueryable<RfidDto>>
            { { "rfids", listRfid.AsQueryable() } };
        return result;
    }

    public async Task<bool> PostEndCheckZone(string idZone, string idChecker)
    {
        try
        {
            await _repository.PostEndCheckZone(idZone, idChecker);
            return true;
        }

        catch (Exception e)
        {
            return false;
        }
    }

    public async Task<RfidDto> GetRfid(string rfid)
    {
        var rfidItem = await _repository.GetRfid(rfid);
        var rfidDto = _mapper.Map<RfidDto>(rfidItem);
        rfidDto.ZoneName = await _repository.GetZoneNameById(rfidItem.IdZone);
        return rfidDto;
    }
}