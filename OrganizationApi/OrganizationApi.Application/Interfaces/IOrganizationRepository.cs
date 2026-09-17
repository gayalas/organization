using OrganizationApi.Domain.Models;

namespace OrganizationApi.Application.Interfaces;

public interface IOrganizationRepository
{
    Task<List<Organization>> GetAllAsync();
    Task<Organization?> GetByIdAsync(int organizationId);
    Task<Organization> AddAsync(Organization organization);
    Task<Organization> UpdateAsync(Organization organization);
    Task DeleteAsync(int organizationId);
}
