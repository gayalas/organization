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
}