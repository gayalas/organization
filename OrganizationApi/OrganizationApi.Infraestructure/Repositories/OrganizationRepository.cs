using Microsoft.EntityFrameworkCore;
using OrganizationApi.Application.Interfaces;
using OrganizationApi.Domain.Models;
using OrganizationApi.Infraestructure.Data;

namespace OrganizationApi.Infraestructure.Repositories;

public class OrganizationRepository : IOrganizationRepository
{
    private readonly OrganizationDbContext _context;

    public OrganizationRepository(OrganizationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Organization>> GetAllAsync()
    {
        return await _context.Organizations
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Organization?> GetByIdAsync(int organizationId)
    {
        return await _context.Organizations
            .FirstOrDefaultAsync(x => x.OrganizationId == organizationId);
    }

    public async Task<Organization> AddAsync(Organization organization)
    {
        _context.Organizations.Add(organization);
        await _context.SaveChangesAsync();
        return organization;
    }

    public async Task<Organization> UpdateAsync(Organization organization)
    {
        _context.Organizations.Update(organization);
        await _context.SaveChangesAsync();
        return organization;
    }

    public async Task DeleteAsync(int organizationId)
    {
        var organization = await _context.Organizations
            .FirstOrDefaultAsync(x => x.OrganizationId == organizationId);

        if (organization is null)
        {
            return;
        }

        _context.Organizations.Remove(organization);
        await _context.SaveChangesAsync();
    }
}
