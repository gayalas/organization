using OrganizationApi.Application.Interfaces;
using OrganizationApi.Domain.Models;

namespace OrganizationApi.Application.Services;

public class DomainService : IDomainService
{
    private readonly IDomainRepository _repository;

    public DomainService(IDomainRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Domains>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }
}