using Microsoft.AspNetCore.Mvc;
using EOP.Api.Models;

namespace EOP.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StoreController : ControllerBase
{
    [HttpGet]
    public IActionResult GetStores()
    {
        var stores = new[]
        {
            new Store
            {
                StoreId = 1,
                StoreCode = "001",
                StoreName = "Philadelphia Center City",
                SbsId = 1,
                SbsName = "Mothercare",
                Address = "123 Market Street",
                City = "Philadelphia",
                Region = "PA",
                Status = "Open",
                UpdateAt = DateTime.Now
            }
        };

        return Ok(stores);
    }
}