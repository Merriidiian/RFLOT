using AeroflotAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AeroflotAPI.Repositories;

public class Repository : IRepository
{
    public readonly DbSet<People> _peoples;

    public Repository(RfidContext context)
    {
        _peoples = context.People;
    }

    public async Task<string?> Authorisation(string login, string password)
    {
        var people = _peoples.FirstOrDefault(p => p.Login == login && p.Password == password);
        if (people == null)
            throw new Exception("Пользователь не найден");
        return people.Id;
    }

    public async Task<bool> Authorisation(string id)
    {
        var people = _peoples.FirstOrDefault(p => p.Id == id);
        return people != null;
    }
}