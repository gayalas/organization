using OrganizationApi.Application.Interfaces;
using OrganizationApi.Domain.Models;

namespace OrganizationApi.Application.Services;

public class OrganizationService : IOrganizationService
{
    private readonly IOrganizationRepository _repository;

    public OrganizationService(IOrganizationRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Organization>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Organization?> GetByIdAsync(int organizationId)
    {
        return await _repository.GetByIdAsync(organizationId);
    }

    public async Task<Organization> CreateAsync(Organization organization)
    {
        return await _repository.AddAsync(organization);
    }

    public async Task<Organization> UpdateAsync(Organization organization)
    {
        return await _repository.UpdateAsync(organization);
    }

    public async Task DeleteAsync(int organizationId)
    {
        await _repository.DeleteAsync(organizationId);
    }
}
