using Home3D.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Home3D.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DevicesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetDevices()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "JsonData", "Devices.json");
        if (!System.IO.File.Exists(filePath))
            return NotFound("JSON file not found.");

        var jsonData = await System.IO.File.ReadAllTextAsync(filePath);
        var devices = JsonSerializer.Deserialize<List<Device>>(jsonData);
        return Ok(devices);
    }
}
