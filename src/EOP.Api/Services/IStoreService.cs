using EOP.Api.Models;

namespace EOP.Api.Services;

public interface IStoreService
{
    Task<List<Store>> GetAllStoresAsync();
}