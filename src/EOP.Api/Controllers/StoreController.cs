using Microsoft.AspNetCore.Mvc;
using EOP.Api.Models;
using EOP.Api.Services;

namespace EOP.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StoreController : ControllerBase
{
    private readonly IStoreService _storeService;

    public StoreController(IStoreService storeService)
    {
        _storeService = storeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetStores()
    {
        var stores = await _storeService.GetAllStoresAsync();

        return Ok(stores);
    }
}