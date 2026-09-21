using Microsoft.AspNetCore.Mvc;
using OrganizationApi.Application.Interfaces;
using OrganizationApi.Domain.Models;

namespace OrganizationApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DomainController : ControllerBase
{
    private readonly IDomainService _service;

    public DomainController(IDomainService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Domains>>> GetAll()
    {
        var domains = await _service.GetAllAsync();

        return Ok(domains);
    }
    [HttpPut("{uId}")]
    public async Task<ActionResult<Domains?>> UpdateByUId(string uId, [FromBody] Domains domain)
    {
        var updatedDomain = await _service.UpdateByUIdAsync(uId, domain);

        if (updatedDomain == null)
        {
            return NotFound();
        }

        return Ok(updatedDomain);
    }
}