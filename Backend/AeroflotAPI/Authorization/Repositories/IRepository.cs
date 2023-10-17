namespace AeroflotAPI.Repositories;

public interface IRepository
{
    Task<string> Authorisation(string login, string password);
    Task<bool> Authorisation(string id);
}