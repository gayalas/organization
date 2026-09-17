using Microsoft.AspNetCore.Mvc;
using OrganizationApi.Application.Interfaces;
using OrganizationApi.Domain.Models;

namespace OrganizationApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrganizationController : ControllerBase
{
    private readonly IOrganizationService _service;

    public OrganizationController(IOrganizationService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Organization>>> GetAll()
    {
        var organizations = await _service.GetAllAsync();
        return Ok(organizations);
    }

    [HttpGet("{organizationId:int}")]
    public async Task<ActionResult<Organization>> GetById(int organizationId)
    {
        var organization = await _service.GetByIdAsync(organizationId);
        if (organization is null)
        {
            return NotFound();
        }

        return Ok(organization);
    }

    [HttpPost]
    public async Task<ActionResult<Organization>> Create([FromBody] Organization organization)
    {
        var created = await _service.CreateAsync(organization);
        return CreatedAtAction(nameof(GetById), new { organizationId = created.OrganizationId }, created);
    }

    [HttpPut]
    public async Task<ActionResult<Organization>> Update([FromBody] Organization organization)
    {
        var updated = await _service.UpdateAsync(organization);
        return Ok(updated);
    }

    [HttpDelete("{organizationId:int}")]
    public async Task<IActionResult> Delete(int organizationId)
    {
        await _service.DeleteAsync(organizationId);
        return NoContent();
    }
}