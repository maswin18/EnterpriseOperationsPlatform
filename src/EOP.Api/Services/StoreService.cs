using EOP.Api.Data;
using EOP.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EOP.Api.Services;

public class StoreService : IStoreService
{
    private readonly ApplicationDbContext _context;

    public StoreService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Store>> GetAllStoresAsync()
    {
        return await _context.Stores.ToListAsync();
    }
}