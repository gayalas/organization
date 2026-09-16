using Microsoft.EntityFrameworkCore;
using OrganizationApi.Application.Interfaces;
using OrganizationApi.Domain.Models;
using OrganizationApi.Infraestructure.Data;

namespace OrganizationApi.Infraestructure.Repositories;

public class DomainRepository : IDomainRepository
{
    private readonly OrganizationDbContext _context;

    public DomainRepository(OrganizationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Domains>> GetAllAsync()
    {
        return await _context.Domains
            .ToListAsync();
    }

    Task<List<Domains>> IDomainRepository.GetAllAsync()
    {
        throw new NotImplementedException();
    }
}