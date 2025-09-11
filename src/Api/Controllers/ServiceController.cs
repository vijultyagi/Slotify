using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/services")]
public class ServiceController
{
    [HttpGet]
    public async Task<IActionResult> GetServices()
    {
        return new OkObjectResult(new List<string> { "Service1", "Service25" });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetServiceById(Guid id)
    {
        return new OkObjectResult("Service1");
    }

    public async Task<IActionResult> CreateService([FromBody] string service)
    {
        return new CreatedResult($"/api/services/{Guid.NewGuid()}", service);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateService(Guid id, [FromBody] string service)
    {
        return new OkObjectResult(service);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteService(Guid id)
    {
        return new NoContentResult();
    }
}