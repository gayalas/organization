using OrganizationApi.Domain.Models;

namespace OrganizationApi.Application.Interfaces;

public interface IOrganizationService
{
    Task<List<Organization>> GetAllAsync();
    Task<Organization?> GetByIdAsync(int organizationId);
    Task<Organization> CreateAsync(Organization organization);
    Task<Organization> UpdateAsync(Organization organization);
    Task DeleteAsync(int organizationId);
}
