using OrganizationApi.Domain.Models;

namespace OrganizationApi.Application.Interfaces;

public interface IDomainService
{
    Task<List<Domains>> GetAllAsync();
}