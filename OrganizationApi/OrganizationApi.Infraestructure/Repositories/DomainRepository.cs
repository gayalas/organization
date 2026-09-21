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

    public async Task<Domains?> UpdateByUIdAsync(string uId, Domains domain)
    {
        var existingDomain = await _context.Domains.FirstOrDefaultAsync(o => o.UId == uId);
        
        if (existingDomain == null)
        {
            return null;
        }

        existingDomain.Name = domain.Name;
        // existingDomain.UId = domain.UId;
        existingDomain.DisplayName = domain.DisplayName;
        existingDomain.TimeZoneId = domain.TimeZoneId;
        existingDomain.CultureCode = domain.CultureCode;

        await _context.SaveChangesAsync();

        return existingDomain;
    }
}