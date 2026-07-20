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
        var stores = new List<Store>
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
                UpdatedAt = DateTime.Now
            },

            new Store
            {
                StoreId = 2,
                StoreCode = "002",
                StoreName = "Cherry Hill Mall",
                SbsId = 2,
                SbsName = "Mothercare",
                Address = "Cherry Hill",
                City = "Cherry Hill",
                Region = "NJ",
                Status = "Open",
                UpdatedAt = DateTime.Now
            }
        };

        return Ok(stores);
    }
}